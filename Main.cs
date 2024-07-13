using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Service;
using Tourist_Assistant.Controllers;
using Tourist_Assistant.Domain.Helpers;
using UiPath.CodedWorkflows;
using UiPath.Mail;

namespace Tourist_Assistant;
public class Main:ControllerBase
{

    [Workflow]
    public async Task Execute()
    {
        
        var EmailsTask = Task.Run(() => ExecuteMailRetrievalWorkFlow()); 
        var OpenPageTask = OpenBrowserlWorkFlow();
        
        
        await Task.WhenAll(EmailsTask,OpenPageTask);
        
        var emails = await EmailsTask;
        //var stringBuilder = new StringBuilder();
        foreach (var message in emails)
        {      
            Log(message.Subject +" "+message.DateAsDateTime().ToString());
            
       
            var context = await ExecuteMailParseWorkFlow(message);
            await CheckMiglWorkFlow();
            
            var emailContext = context.FillEmailModel();
            
            
            
            await TypeOfJourneylWorkFlow(emailContext.JourneyType);
                
            await TravelInformationlWorkFlow(emailContext);    
                
   
            
            break;           
            
         
        }
        //string text = stringBuilder.ToString();
        //System.IO.File.WriteAllText("rame.txt",text);
    }


}