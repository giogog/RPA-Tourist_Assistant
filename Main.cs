using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tourist_Assistant.Controllers;
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
            
            var values = await ExecuteMailParseWorkFlow(message);
            await CheckMiglWorkFlow();
            
            var journeyType = values.Where(v=>v.Key.Contains("Eres") || v.Key.Contains("You are"))
                .Select(v=>v.Value.FirstOrDefault())
                .First();
            if(journeyType == null)
                throw new Exception("Couldn't Parse Journey Type");
            
            await TypeOfJourneylWorkFlow(journeyType);
            
            var flightType = values.Where(v=>v.Key.Contains("Viajas con") || v.Key.Contains("You travel with"))
                .Select(v=>v.Value.FirstOrDefault())
                .First();
            if(flightType == null)
                throw new Exception("Couldn't Parse Flight Type");
            
            await TravelInformationlWorkFlow(flightType);
            
            break;
            
         
        }
        //string text = stringBuilder.ToString();
        //System.IO.File.WriteAllText("rame.txt",text);
    }    
            
}