using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Application.Service;
using Domain.Helpers;
using Domain.Models;
using Tourist_Assistant;
using Tourist_Assistant.Domain.Helpers;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.DescriptorIntegration;
using UiPath.CodedWorkflows.Interfaces;
using UiPath.Mail;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;

namespace Tourist_Assistant.Controllers
{
    
    public class ControllerBase : CodedWorkflow
    {
        private EmailService _mailService;
        private static readonly List<string> airports = new List<string>
        {
            "ARMENIA (AXM), EL EDEN AIRPORT",
            "BARRANQUILLLA (BAQ), ERNESTO CORTISSOZ AIRPORT",
            "BOGOTA D.C (BOG), EL DORADO AIRPORT",
            "BUCARAMANGA (BGA), PALONEGRO AIRPORT",
            "CALI (CLO), ALFONSO BONILLA ARAGON AIRPORT",
            "CARTAGENA (CTG), RAFAEL NUÑEZ AIRPORT",
            "CUCUTA (CUC), CAMILO DAZA AIRPORT",
            "LETICIA (LET), ALFREDO VASQUEZ COBO AIRPORT",
            "MEDELLIN (MDE), JOSÉ MARÍA CORDOVA AIRPORT",
            "MEDELLIN (MDE), ENRIQUE OLAYA HERRERA AIRPORT",
            "PEREIRA (PEI), MATECAÑA AIRPORT",
            "RIOHACHA (RCH), ALMIRANTE PADILLA AIRPORT",
            "SAN ANDRÉS ISLAND (ADZ), GUSTAVO ROJAS PINILLA AIRPORT",
            "SANTA MARTA (SMR), SIMON BOLIVAR AIRPORT",
            "TUMACO (TCO), MULTIMODAL AERIAL",
            "VALLEDUPAR (VUP), ALFONSO LOPEZ PUMAREJO AIRPORT"
        };
        

        
        public async Task<Dictionary<string, List<string>>> ExecuteMailParseWorkFlow(MailMessage message)
        {
            Log("Parse Email");
            return _mailService.ParseEmailMessage(message);
        } 
            
    
        public List<MailMessage> ExecuteMailRetrievalWorkFlow()
        {
            Log("Mail Retrival");
            //var result = RunWorkflow(AppSettings.GetWorkflowPath(new[]{"Infrastructure"},"GetDates.xaml"));
            DateTime startDate = new DateTime(2024,7,11,0,0,0);
            DateTime endDate = new DateTime(2024,7,11,23,59,0);
            _mailService = new EmailService(mail);
            
            
            return _mailService.GetMails(new EmailOptions()
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
        
        public async Task OpenBrowserlWorkFlow()
        {
            Log("Open Browser");
            uiAutomation.Open("WebPage");
        }
        
        public async Task CheckMiglWorkFlow(){
            Log("Navigate to CheckMig");
            var homescreen = uiAutomation.Attach("WebPage");
            homescreen.Click("Do Checkmig");

        }
        
        public async Task TypeOfJourneylWorkFlow(string Type)
        {
            
            var clickOptions = new ClickOptions{ InteractionMode = NChildInteractionMode.Simulate };
            Log("Complete TypeOfJourney Form " + Type);
            var homescreen = uiAutomation.Attach("TypeOfJourney");
            if(Type=="Visiting Colombia" || Type=="Visitando Colombia")
                homescreen.Click("toColombia",clickOptions);
            else
                homescreen.Click("fromColombia",clickOptions);
            
            homescreen.Click("Air",clickOptions);
            
            homescreen.Click("Continue",clickOptions);
        }  
        
        
        public async Task TravelInformationlWorkFlow(Email context)
        {
            var clickOptions = new ClickOptions{ InteractionMode = NChildInteractionMode.Simulate };
            if(context.FlightType == null)
                throw new Exception("Couldn't Parse Flight Type");
            
            Log("Complete TravelInformation Form " + context.FlightType);
            var homescreen = uiAutomation.Attach("Travelinformation");
            if(context.FlightType=="Commercial flight" || context.FlightType=="Vuelo comercial")
                homescreen.Click("CommercialFlight",clickOptions);
            else
                homescreen.Click("PrivateFlight",clickOptions);

            var in_variables = new Dictionary<string,object>();
            string search;
            if(context.JourneyType=="Visiting Colombia" || context.JourneyType =="Visitando Colombia"){
                search = context.ArrivalAirport;
            }     
            else{
                search = context.DepartureAirport;     
            }
            
            in_variables.Add("in_AirportName",search);
            var WorkFlowTask = Task.Run(() => RunWorkflow(AppSettings.GetWorkflowPath(new[]{"Infrastructure"},"GoogleSearch.xaml"),in_variables));
            
            homescreen.TypeInto("TravelDate",context.ArrivalDate.ToFormattedDateString());
            homescreen.TypeInto("FlightNum",context.FlightNum.KeepNumbersOnly());
            homescreen.TypeInto("Country","UNITED STATES");
            homescreen.Click("ChooseFirst",clickOptions);
            
            var result = await WorkFlowTask;
            string code = (string)result["out_Code"];
            
            
            foreach(var airport in airports){
                if(airport.Trim().ToLower().Contains(code.Trim().ToLower())){
                    
                    homescreen.TypeInto("ImmigrationCheckpoint",airport);
                    string airportSelector = "<webctrl parentid='dropdown-PuntoControl' tag='A' innertext='"+airport+"' />";
                    
                    homescreen.Click(Target.FromSelector(airportSelector),clickOptions);

                    break;
                }
            }
            
            
            
            
            
            
            
        }
        
    }
}