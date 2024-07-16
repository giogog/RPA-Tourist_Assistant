using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;

namespace Tourist_Assistant.WorkFlows
{
    public class TypeOfJourneyWorkflow : WorkflowBase
    {
        [Workflow]
        public async Task Execute(string journeyType)
        {
            await CheckMig();
                        
            //var _clickOptions = new ClickOptions{ InteractionMode = NChildInteractionMode.Simulate };
            Log("Complete TypeOfJourney Form " + journeyType);
            var typeofjurneyScreen = uiAutomation.Attach("TypeOfJourney",_targetAppOptions);
            if(journeyType=="Visiting Colombia" || journeyType=="Visitando Colombia")
                typeofjurneyScreen.Click("toColombia",_clickOptions);
            else
                typeofjurneyScreen.Click("fromColombia",_clickOptions);
            
            typeofjurneyScreen.Click("Air",_clickOptions);
            
            typeofjurneyScreen.Click("Continue",_clickOptions);
                
        }
        
        public async Task CheckMig(){
            Log("Navigate to CheckMig");
            var homescreen = uiAutomation.Attach("WebPage",_targetAppOptions);
            homescreen.Click("Do Checkmig",_clickOptions);

        }
    }
}