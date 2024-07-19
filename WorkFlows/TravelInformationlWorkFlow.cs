using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tourist_Assistant.Application.Models;
using Tourist_Assistant.Application.Helpers;
using UiPath.CodedWorkflows;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;
using Tourist_Assistant.WorkFlows;

namespace Tourist_Assistant.Workflows
{
    public class TravelInformationlWorkflow : WorkflowBase
    {
        private static readonly Dictionary<string, string> airports = new Dictionary<string, string>
        {
            { "ARMENIA (AXM), EL EDEN AIRPORT", "ARMENIA, QUINDIO" },
            { "BARRANQUILLLA (BAQ), ERNESTO CORTISSOZ AIRPORT", "BARRANQUILLA, ATLÁNTICO" },
            { "BOGOTA D.C (BOG), EL DORADO AIRPORT", "BOGOTÁ, D.C., BOGOTÁ, D.C." },
            { "BUCARAMANGA (BGA), PALONEGRO AIRPORT", "BUCARAMANGA, SANTANDER" },
            { "CALI (CLO), ALFONSO BONILLA ARAGON AIRPORT", "CALI, VALLE DEL CAUCA" },
            { "CARTAGENA (CTG), RAFAEL NUÑEZ AIRPORT", "CARTAGENA, BOLÍVAR" },
            { "CUCUTA (CUC), CAMILO DAZA AIRPORT", "CÚCUTA, NORTE DE SANTANDER" },
            { "LETICIA (LET), ALFREDO VASQUEZ COBO AIRPORT", "LETICIA, AMAZONAS" },
            { "MEDELLIN (MDE), JOSÉ MARÍA CORDOVA AIRPORT", "MEDELLÍN, ANTIOQUIA" },
            { "MEDELLIN (MDE), ENRIQUE OLAYA HERRERA AIRPORT", "MEDELLÍN, ANTIOQUIA" },
            { "PEREIRA (PEI), MATECAÑA AIRPORT", "PEREIRA, RISARALDA" },
            { "RIOHACHA (RCH), ALMIRANTE PADILLA AIRPORT", "RIOHACHA, LA GUAJIRA" },
            { "SAN ANDRÉS ISLAND (ADZ), GUSTAVO ROJAS PINILLA AIRPORT", "SAN ANDRÉS, ARCHIPIÉLAGO DE SAN ANDRÉS, PROVIDENCIA Y SANTA CATALINA" },
            { "SANTA MARTA (SMR), SIMON BOLIVAR AIRPORT", "SANTA MARTA, MAGDALENA" },
            { "TUMACO (TCO), MULTIMODAL AERIAL", "SAN ANDRES DE TUMACO, NARIÑO" },
            { "VALLEDUPAR (VUP), ALFONSO LOPEZ PUMAREJO AIRPORT", "VALLEDUPAR, CESAR" }
        };

        
        
        [Workflow]
        public async Task<string> Execute(Client clientContext)
        {
            Log("TravelInformationlWorkflow");

            if(clientContext.FlightType == null)
                throw new Exception("Couldn't Parse Flight Type");
            
            var travelInformationScreen = uiAutomation.Attach("Travelinformation",_targetAppOptions);
            await Task.Delay(2000);
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
            var WorkFlowTask = Task.Run(() => RunWorkflow("Sequences\\GoogleSearch.xaml",in_variables));
            await Task.Delay(1500);
            travelInformationScreen.TypeInto("TravelDate",clientContext.ArrivalDate.ToFormattedDateString());
            travelInformationScreen.TypeInto("FlightNum",clientContext.FlightNum.KeepNumbersOnly());
            travelInformationScreen.TypeInto("Country","UNITED STATES");
            travelInformationScreen.Click("ChooseFirst",_clickOptions);
            
            var result = await WorkFlowTask;
            string code = (string)result["out_Code"];
            string out_city = string.Empty;
            Log(code);
            
            foreach(var airport in airports.Keys){
                if(airport.Trim().ToLower().Contains(code.Trim().ToLower())){
                    string airportSelector = "<webctrl parentid='dropdown-PuntoControl' tag='A' innertext='"+airport.Split(",")[0].Trim()+"*' />";
                    //travelInformationScreen.TypeInto("ImmigrationCheckpoint",airport.Split(",")[0].Trim());
                    
                    travelInformationScreen.Click(Target.FromSelector(airportSelector),_clickOptions);
                    out_city = airports[airport];
                    break;
                }
            }
            
            var CheckErrorTask = Task.Run(() => CheckError(travelInformationScreen));
            travelInformationScreen.Click("Continue",_clickOptions);
//            bool ErrorAppears = travelInformationScreen.WaitState("CheckError",NCheckStateMode.WaitAppear,3);
//            if(ErrorAppears){
//                Log("Error Appears");
//                travelInformationScreen.Dispose();
//                throw new Exception("Invalid Airport");
//            }else{
//                Log("Error not Appears");
                
//            }
            await CheckErrorTask;
            
            return out_city;
        }    
        
        
        public async Task CheckError(UiTargetApp travelInformationScreen)
        {
           bool ErrorAppears = travelInformationScreen.WaitState("CheckError",NCheckStateMode.WaitAppear,3);
            if(ErrorAppears){
                Log("Error Appears");
                travelInformationScreen.Dispose();
                throw new Exception("Invalid Airport");
            } 
        }
        
    }

}