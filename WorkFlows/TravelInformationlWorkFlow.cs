using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tourist_Assistant.Domain.Models;
using Tourist_Assistant.Domain.Helpers;
using UiPath.CodedWorkflows;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;

namespace Tourist_Assistant.Workflows
{
    public class TravelInformationlWorkFlow : CodedWorkflow
    {
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
        
        
        [Workflow]
        public async Task Execute(Email emailContext)
        {
            var clickOptions = new ClickOptions{ InteractionMode = NChildInteractionMode.Simulate };
            if(emailContext.FlightType == null)
                throw new Exception("Couldn't Parse Flight Type");
            
            Log("Complete TravelInformation Form " + emailContext.FlightType);
            var homescreen = uiAutomation.Attach("Travelinformation");
            if(emailContext.FlightType=="Commercial flight" || emailContext.FlightType=="Vuelo comercial")
                homescreen.Click("CommercialFlight",clickOptions);
            else
                homescreen.Click("PrivateFlight",clickOptions);

            var in_variables = new Dictionary<string,object>();
            string search;
            if(emailContext.JourneyType=="Visiting Colombia" || emailContext.JourneyType =="Visitando Colombia"){
                search = emailContext.ArrivalAirport;
            }     
            else{
                search = emailContext.DepartureAirport;     
            }
            
            in_variables.Add("in_AirportName",search);
            var WorkFlowTask = Task.Run(() => RunWorkflow("Infrastructure\\GoogleSearch.xaml",in_variables));
            
            homescreen.TypeInto("TravelDate",emailContext.ArrivalDate.ToFormattedDateString());
            homescreen.TypeInto("FlightNum",emailContext.FlightNum.KeepNumbersOnly());
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