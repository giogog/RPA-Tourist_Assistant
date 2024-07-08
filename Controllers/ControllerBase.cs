using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Application.Service;
using Domain.Helpers;
using Tourist_Assistant;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Interfaces;
using UiPath.Mail;

namespace Tourist_Assistant.Controllers
{
    
    public class ControllerBase : CodedWorkflow
    {
        private EmailService _mailService;
        

        
        public async Task<Dictionary<string, List<string>>> ExecuteMailParse(MailMessage message)
        {
            Log("Parse Email");
            return _mailService.ParseEmailMessage(message);
        } 
            
        
        
        
        public List<MailMessage> ExecuteMailRetrievalWorkFlow()
        {
            Log("Mail Retrival");
            //var result = RunWorkflow(AppSettings.GetWorkflowPath(new[]{"Infrastructure"},"GetDates.xaml"));
            DateTime startDate = new DateTime(2024,7,8,0,0,0);
            DateTime endDate = new DateTime(2024,7,8,22,59,0);
            _mailService = new EmailService(mail);
            
            
            return _mailService.GetMailsAsync(new EmailOptions()
                        { 
                            Top = 100, 
                            OrderByDate = EOrderByDate.NewestFirst, 
                            OnlyUnreadMessages = false,
                            StartDate = startDate,
                            EndDate = endDate    
                            //StartDate = (DateTime)result["StartDate_dt"], 
                            //EndDate = (DateTime)result["EndDate_dt"]    
                        });
        }
        
        
        
        public async Task OpenBrowser()
        {
            Log("Open Browser");
            uiAutomation.Open("WebPage");
        }
        public async Task NavigateToCheckMig(){
            Log("Navigate to CheckMig");
            var homescreen = uiAutomation.Attach("WebPage");
            homescreen.Click("Do Checkmig");

        }
        
        public async Task TypeOfJourney(string Type)
        {
            Log("Complete TypeOfJourney Form " + Type);
            var homescreen = uiAutomation.Attach("TypeOfJourney");
            if(Type=="Visiting Colombia" || Type=="Visitando Colombia")
                homescreen.Click("toColombia");
            else
                homescreen.Click("fromColombia");
            
            homescreen.Click("Air");
            
            homescreen.Click("Continue");
        }  
        
        
        public async Task TravelInformation(string Type)
        {
            Log("Complete TravelInformation Form " + Type);
            var homescreen = uiAutomation.Attach("Travelinformation");
            if(Type=="Commercial flight" || Type=="Vuelo comercial")
                homescreen.Click("CommercialFlight");
            else
                homescreen.Click("PrivateFlight");
            
        }
        
    }
}