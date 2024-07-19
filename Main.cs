using System.Collections.Generic;
using System.Net.Mail;
using System.Threading.Tasks;
using Tourist_Assistant.WorkFlows;
using Tourist_Assistant.Application.Helpers;
using UiPath.CodedWorkflows;
using UiPath.Mail;
using System;
using Tourist_Assistant.Application.Models;
using System.Linq;

namespace Tourist_Assistant;
public class Main:WorkflowBase
{

    [Workflow]
    public async Task Execute()
    {
        //Kill all processes
        RunWorkflow("Sequences\\QuiteChrome.xaml");
        
        //Get Mails
        var emailWorkflowResult = await RunWorkflowAsync("WorkFlows\\EmailWorkflow.cs");
        var emails = (List<MailMessage>)emailWorkflowResult["Output"];
        await RunWorkflowAsync("Sequences\\CreateReport.xaml");
        
        foreach (var message in emails)
        {      
            Log(message.Subject +" "+message.DateAsDateTime().ToString());
            
            //Get Data from mail html context and write into Dictionary
            var context = await ExecuteMailParse(message);   
            
            List<Client> clients = new List<Client>();
            try{
               //Get Data from Dictionary and write into List of Client models 
               clients = context.FillClientModel();     
            }catch(Exception ex){
                
                RunWorkflow("Sequences\\QuiteChrome.xaml");
                await RunWorkflowAsync("Sequences\\CheckReport.xaml", new Dictionary<string,object> 
                    { 
                        { "in_Status", "Failed" },
                        { "in_Email", message.Subject +" "+message.DateAsDateTime().ToString() } 
                    });
                Log(ex.Message);
                continue;
            }
            
            
            //Check if this mail is already done
            var checkReport = await RunWorkflowAsync("Sequences\\CheckReport.xaml", new Dictionary<string,object> 
                    { 
                        { "in_Status", "" },
                        { "in_Email", message.Subject +" "+message.DateAsDateTime().ToString() } 
                    });
            
            var status = (bool)checkReport["out_Status"];
            if(!status)
                continue;
            try{
                //Start Process over Mail content, each mail can have couple of clients that is why we return List of clients
                foreach (var clientContext in clients){
                    Log(clientContext.Name);
                    
                    //each workflow fills a Form 
                    await RunWorkflowAsync("WorkFlows\\TypeOfJourneyWorkflow.cs", new Dictionary<string,object> 
                    { 
                        { "journeyType", clientContext.JourneyType } 
                    });
                    
                    var travelInfo = await RunWorkflowAsync("WorkFlows\\TravelInformationlWorkFlow.cs", new Dictionary<string,object> 
                    { 
                        { "clientContext", clientContext } 
                    });
                    
                    await RunWorkflowAsync("WorkFlows\\PersonalInfoWorkflow.cs", new Dictionary<string,object> 
                    { 
                        { "clientContext", clientContext } 
                    });
                    
                    await RunWorkflowAsync("WorkFlows\\FinilizingWorkflow.cs", new Dictionary<string,object> 
                    { 
                        { "clientContext", clientContext },
                        { "airportCity", (string)travelInfo["Output"] } 
                    });    
                    
                }
                 
                
                var Ids = clients.Select(c => c.PassportNum).ToArray();
                var subjectMail = clients.Select(c => c.Email).FirstOrDefault();
                var subjectName = clients.Select(c => c.Name).FirstOrDefault();
                
                await RunWorkflowAsync("Sequences\\SendMail.xaml", new Dictionary<string,object> 
                    { 
                        { "in_persoanlIds", Ids },
                        { "in_subjectEmail", subjectMail } ,
                        { "in_subjectName", subjectName } 
                    });
                
                await RunWorkflowAsync("Sequences\\CheckReport.xaml", new Dictionary<string,object> 
                    { 
                        { "in_Status", "Done" },
                        { "in_Email", message.Subject +" "+message.DateAsDateTime().ToString() } 
                    });

            }
            catch(Exception ex){
                RunWorkflow("Sequences\\QuiteChrome.xaml");
                await RunWorkflowAsync("Sequences\\CheckReport.xaml", new Dictionary<string,object> 
                    { 
                        { "in_Status", "Failed" },
                        { "in_Email", message.Subject +" "+message.DateAsDateTime().ToString() } 
                    });
                Log(ex.Message);
            }
            
            
        }
    }


}