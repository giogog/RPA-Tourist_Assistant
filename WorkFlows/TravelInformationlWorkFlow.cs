using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tourist_Assistant.Domain.Models;
using Tourist_Assistant.Domain.Helpers;
using UiPath.CodedWorkflows;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;
using Tourist_Assistant.WorkFlows;

namespace Tourist_Assistant.Workflows
{
    public class TravelInformationlWorkFlow : WorkflowBase
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
        public async Task Execute(Client clientContext)
        {
            if(clientContext.FlightType == null)
                throw new Exception("Couldn't Parse Flight Type");
            
            var travelInformationScreen = uiAutomation.Attach("Travelinformation",_targetAppOptions);
            
            if(clientContext.FlightType=="Commercial flight" || clientContext.FlightType=="Vuelo comercial")
                travelInformationScreen.Click("CommercialFlight",_clickOptions);
            else
                travelInformationScreen.Click("PrivateFlight",_clickOptions);

            var in_variables = new Dictionary<string,object>();
            string search;
            if(clientContext.JourneyType=="Visiting Colombia" || clientContext.JourneyType =="Visitando Colombia"){
                search = clientContext.ArrivalAirport;
            }     
            else{
                search = clientContext.DepartureAirport;     
            }
            
            in_variables.Add("in_AirportName",search);
            var WorkFlowTask = Task.Run(() => RunWorkflow("Infrastructure\\GoogleSearch.xaml",in_variables));
            
            travelInformationScreen.TypeInto("TravelDate",clientContext.ArrivalDate.ToFormattedDateString());
            travelInformationScreen.TypeInto("FlightNum",clientContext.FlightNum.KeepNumbersOnly());
            travelInformationScreen.TypeInto("Country","UNITED STATES");
            travelInformationScreen.Click("ChooseFirst",_clickOptions);
            
            var result = await WorkFlowTask;
            string code = (string)result["out_Code"];
            
            
            foreach(var airport in airports){
                if(airport.Trim().ToLower().Contains(code.Trim().ToLower())){
                    
                    travelInformationScreen.TypeInto("ImmigrationCheckpoint",airport);
                    string airportSelector = "<webctrl parentid='dropdown-PuntoControl' tag='A' innertext='"+airport+"' />";
                    
                    travelInformationScreen.Click(Target.FromSelector(airportSelector),_clickOptions);

                    break;
                }
            }
            
            travelInformationScreen.Click("Continue",_clickOptions);
        }    
        
    }

}