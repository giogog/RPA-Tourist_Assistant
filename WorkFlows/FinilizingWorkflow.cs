using System;
using System.Threading.Tasks;
using Tourist_Assistant.Application.Models;
using UiPath.CodedWorkflows;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;

namespace Tourist_Assistant.WorkFlows
{
    public class FinilizingWorkflow : WorkflowBase
    {
        [Workflow]
        public async Task Execute(Client clientContext,string airportCity)
        {
            Log("FinilizingWorkflow");
            ChangeTargetAppOptions(opt=>{opt.Timeout = 5; opt.OpenMode = NAppOpenMode.Never;});
            var HostindDataTask = Task.Run(() => HostingData(clientContext,airportCity));
            await Task.Delay(2000);
            var QuestionsTask = Task.Run(() => Questions());
            await Task.Delay(2000);
            ChangeTargetAppOptions(opt=>{opt.Timeout = 10; opt.OpenMode = NAppOpenMode.Never;});
            var TermsTask = Task.Run(() => TermsAndConditions());
            await Task.Delay(2000);
            var ConfirmationTask = Task.Run(() => Confirmation(clientContext.PassportNum));
            try{
                Log("Waiting for hosting data and questions");
                await Task.WhenAll(HostindDataTask,QuestionsTask);
                 
            }catch(Exception ex){
                Log("hosting data and questions Faulted");
                HostindDataTask.Dispose();
                QuestionsTask.Dispose();
            }
            
            Log("Waiting for TermsTask and ConfirmationTask");
            await Task.WhenAll(TermsTask,ConfirmationTask);
            
            
        }
        
        public void HostingData(Client clientContext,string airportCity)
        {
            var hostingDataScreen = uiAutomation.Attach("HostingData",_targetAppOptions);
            airportCity = airportCity.Split(",")[0].Trim();
            
            var citySelector = "<webctrl parentid='dropdown-CiudadHospedaje' tag='A' visibleinnertext='"+airportCity+"*' />";
            bool appears = hostingDataScreen.WaitState("City",NCheckStateMode.WaitAppear,3);
            if(appears){
                Log("Airport City Appears");
                hostingDataScreen.TypeInto("City",airportCity); 
                hostingDataScreen.Click(Target.FromSelector(citySelector),_clickOptions);
                hostingDataScreen.TypeInto("Address",clientContext.Address); 
                hostingDataScreen.TypeInto("PhoneNumber",clientContext.PhoneNumber); 
                hostingDataScreen.Click("Continue",_clickOptions);    
            }
            
            
        }
        
        public void Questions(){
            var questionsScreen = uiAutomation.Attach("Questions",_targetAppOptions);
            bool appears = questionsScreen.WaitState("City",NCheckStateMode.WaitAppear,3);
            if(appears)
            {
                Log("Question Appears");
                questionsScreen.Click("No",_clickOptions);
                questionsScreen.Click("Continue",_clickOptions); 
            }

            
        }
        
        public async Task TermsAndConditions(){
            var termsScreen = uiAutomation.Attach("Terms",_targetAppOptions);
            await Task.Delay(1000);
            termsScreen.Click("Accept",_clickOptions);
            termsScreen.Click("Continue",_clickOptions);
        }
        
        public async Task Confirmation(string personalId){
            var confirmationScreen = uiAutomation.Attach("Confirmation");
            await Task.Delay(1000);
            confirmationScreen.Click("Download",_clickOptions);
            await DownloadPdf(personalId);
            confirmationScreen.Dispose();
        }
        
        public async Task DownloadPdf(string personalId){
            var downloadScreen = uiAutomation.Attach("Download",_targetAppOptions);
            await Task.Delay(1000);
            string path = AppSettings.BasePath+"PDFs\\"+personalId+".pdf";
            downloadScreen.TypeInto("Path",path);
            ChangeClickOptions(opt => opt.InteractionMode = NChildInteractionMode.WindowMessages);
            downloadScreen.Click("Save",_clickOptions);
        }
        
        
    }
}