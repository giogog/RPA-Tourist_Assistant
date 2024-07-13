using System.Collections.Generic;
using System.Net.Mail;
using System.Threading.Tasks;
using Tourist_Assistant.WorkFlows;
using Tourist_Assistant.Domain.Helpers;
using UiPath.CodedWorkflows;
using UiPath.Mail;

namespace Tourist_Assistant;
public class Main:WorkflowBase
{

    [Workflow]
    public async Task Execute()
    {
        
        var emailWorkflowResult = await RunWorkflowAsync("WorkFlows\\EmailWorkflow.cs");
        var emails = (List<MailMessage>)emailWorkflowResult["Output"];
        
        
        foreach (var message in emails)
        {      
            Log(message.Subject +" "+message.DateAsDateTime().ToString());
            
       
            var context = await ExecuteMailParse(message);            
            var emailContext = context.FillEmailModel();
            
            await RunWorkflowAsync("WorkFlows\\TypeOfJourneyWorkflow.cs", new Dictionary<string,object> 
            { 
                { "journeyType", emailContext.JourneyType } 
            });
            
            await RunWorkflowAsync("WorkFlows\\TravelInformationlWorkFlow.cs", new Dictionary<string,object> 
            { 
                { "emailContext", emailContext } 
            });
                
   
            
            break;           
            
         
        }
    }


}