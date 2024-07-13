using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;

namespace Tourist_Assistant.WorkFlows
{
    public class TypeOfJourneyWorkflow : CodedWorkflow
    {
        [Workflow]
        public async Task Execute(string journeyType)
        {
            await CheckMig();
                        
            var clickOptions = new ClickOptions{ InteractionMode = NChildInteractionMode.Simulate };
            Log("Complete TypeOfJourney Form " + journeyType);
            var homescreen = uiAutomation.Attach("TypeOfJourney");
            if(journeyType=="Visiting Colombia" || journeyType=="Visitando Colombia")
                homescreen.Click("toColombia",clickOptions);
            else
                homescreen.Click("fromColombia",clickOptions);
            
            homescreen.Click("Air",clickOptions);
            
            homescreen.Click("Continue",clickOptions);
                
        }
        
        public async Task CheckMig(){
            Log("Navigate to CheckMig");
            var homescreen = uiAutomation.Attach("WebPage");
            homescreen.Click("Do Checkmig");

        }
    }
}