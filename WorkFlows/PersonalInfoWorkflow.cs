using System.Collections.Generic;
using System.Threading.Tasks;
using Tourist_Assistant.Domain.Helpers;
using Tourist_Assistant.Domain.Models;
using UiPath.CodedWorkflows;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;

namespace Tourist_Assistant.WorkFlows
{
    public class PersonalInfoWorkflow : WorkflowBase
    {
        [Workflow]
        public async Task Execute(Client clientContext)
        {
            
            var personalInformationScreen = uiAutomation.Attach("Personalinformation");
            
            //Nationality
            var GetCountryTask = Task.Run(()=>RunWorkflow("Infrastructure\\GetCountry.xaml",new Dictionary<string,object> {{"in_Country", clientContext.PassportCountry}}));
            
            Log(clientContext.PassportNum);
            //ID Number
            personalInformationScreen.TypeInto("IdNumber",clientContext.PassportNum);
            
            
            var names = GetFirstAndSecondNames(clientContext);
            
            //First Name1
            personalInformationScreen.TypeInto("FirstName1",names["Name1"]);
            
            if(names.ContainsKey("Name2")){
                //First Name2
                personalInformationScreen.TypeInto("FirstName2",names["Name2"]);    
            }
            
            //Surname1
            personalInformationScreen.TypeInto("SurName1",names["Surname1"]);
            
            if(names.ContainsKey("Surname2")){
                //Surname2
                personalInformationScreen.TypeInto("SurName2",names["Surname2"]);    
            }
            
            var GetCountryTaskResult = await GetCountryTask;
            string nationality = (string)GetCountryTaskResult["out_Country"];
            Log(nationality);
            string countrySelector = "<webctrl aaname='"+nationality.Trim()+"' parentid='dropdown-Nacionalidad' tag='A' />";
            personalInformationScreen.Click(Target.FromSelector(countrySelector),_clickOptions);
            //personalInformationScreen.TypeInto("Nationality",nationality);
            await Task.Delay(1000);
            //Gender
            string genderSelector;
            if(clientContext.Gender != null){
                genderSelector = "<webctrl tag='LABEL' visibleinnertext='"+clientContext.Gender.ToProperCase()+"' />";   
            }
            else{
                genderSelector = "<webctrl tag='LABEL' visibleinnertext='Other' />";
            }
            personalInformationScreen.Click(Target.FromSelector(genderSelector),_clickOptions);
            
            Log(nationality);
            //ID type
            if(clientContext.PassportCountry.Contains("COLOMBIA")){
                personalInformationScreen.Click("Cedula",_clickOptions);
            }
            else{
                personalInformationScreen.Click("Pasaporte",_clickOptions);
            }
            
            
            
            personalInformationScreen.TypeInto("DateOfBirth",clientContext.BirthDate.ToFormattedDateString());
            personalInformationScreen.Click("Purpose",_clickOptions);
            personalInformationScreen.TypeInto("Email","info@checkmigcolombia.us");
            personalInformationScreen.TypeInto("ConfirmEmail","info@checkmigcolombia.us");
            


        }
        
        public Dictionary<string,string> GetFirstAndSecondNames(Client clientContext){
            var names = new Dictionary<string,string>();
            
            
            if(!string.IsNullOrEmpty(clientContext.Name)){
                if(clientContext.Name.Contains(" ")){
                    names.Add("Name1", clientContext.Name.Split(" ")[0].Trim());
                    names.Add("Name2", clientContext.Name.Split(" ")[1].Trim());
                }
                else{
                    names.Add("Name1", clientContext.Name.Trim());
                }    
            }
            
            
            
            if(!string.IsNullOrEmpty(clientContext.Surname)){
                if(clientContext.Surname.Contains(" ")){
                    names.Add("Surname1", clientContext.Surname.Split(" ")[0].Trim());
                    names.Add("Surname2", clientContext.Surname.Split(" ")[1].Trim());
                }
                else{
                    names.Add("Surname1", clientContext.Surname.Trim());
                }    
            }
            
            
            return names;
        }
    }
}