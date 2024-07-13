using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Domain.Models;
using Tourist_Assistant.ObjectRepository;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Excel;
using UiPath.Excel.Activities;
using UiPath.Excel.Activities.API;
using UiPath.Excel.Activities.API.Models;
using UiPath.Mail.Activities.Api;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;

namespace Tourist_Assistant.Domain.Helpers;

public static class EmailFillExtension
{
    public static Email FillEmailModel(this Dictionary<string,List<string>> context)
    {
        try{
            var memberNum = context.FirstOrDefault(v=>v.Key.Contains("Last/Family names (as shown on your passport)") || 
            v.Key.Contains("Apellidos/Apellidos (como se muestran en su pasaporte)")).Value.Count();
        
            Email emailContext = new Email();
            emailContext.Name = context.FirstOrDefault(v=>v.Key.Contains("First/Given names (as shown on your passport)") || v.Key.Contains("Nombres/nombres (como se muestra en su pasaporte)")).ReturnDictionaryListValue();
            emailContext.Surname = context.FirstOrDefault(v => v.Key.Contains("Last/Family names (as shown on your passport)") || v.Key.Contains("Apellidos/Apellidos (como se muestran en su pasaporte)")).ReturnDictionaryListValue();
            emailContext.BirthDate = context.FirstOrDefault(v => v.Key.Contains("Date of birth") || v.Key.Contains("Fecha de nacimiento")).ReturnDictionaryListValue();
            emailContext.Gender = context.FirstOrDefault(v => v.Key.Contains("Gender") || v.Key.Contains("Género")).ReturnDictionaryListValue();
            emailContext.PassportNum = context.FirstOrDefault(v => v.Key.Contains("Passport number") || v.Key.Contains("Número de pasaporte")).ReturnDictionaryListValue();
            emailContext.PassportCountry = context.FirstOrDefault(v => v.Key.Contains("Passport issuing country") || v.Key.Contains("País emisor del pasaporte")).ReturnDictionaryListValue();
            emailContext.JourneyType = context.FirstOrDefault(v => v.Key.Contains("You are") || v.Key.Contains("Eres")).Value[0];
            emailContext.FlightType = context.FirstOrDefault(v => v.Key.Contains("You travel with") || v.Key.Contains("Viajas con")).Value[0];
            emailContext.DepartureAirport = context.FirstOrDefault(v => v.Key.Contains("Airport of departure to Colombia") || v.Key.Contains("Aeropuerto de salida a Colombia") || v.Key.Contains("Aeropuerto de salida de Colombia")).ReturnDictionaryStringValue();
            emailContext.ArrivalAirport = context.Where(v => v.Key.Contains("Airport of arrival in Colombia") || v.Key.Contains("Aeropuerto de llegada a Colombia"))?.FirstOrDefault().ReturnDictionaryStringValue();  
            emailContext.ArrivalDate = context.FirstOrDefault(v => v.Key.Contains("Date of arrival in Colombia") || v.Key.Contains("Fecha de salida de Colombia") || v.Key.Contains("Fecha de llegada a Colombia")).ReturnDictionaryStringValue();
            emailContext.FlightNum = context.FirstOrDefault(v => v.Key.Contains("Flight number (you will be landing under in Colombia)") || v.Key.Contains("Número de vuelo") || v.Key.Contains("Número de vuelo (bajo el cual aterrizará en Colombia)")).ReturnDictionaryStringValue();            
            emailContext.Address = context.FirstOrDefault(v => v.Key.Contains("Name and address (city, street #)") || v.Key.Contains("Nombre y dirección (ciudad, calle #)")).ReturnDictionaryStringValue();
            emailContext.PhoneNumber = context.FirstOrDefault(v => v.Key.Contains("Local phone number") || v.Key.Contains("Número de teléfono local")).ReturnDictionaryStringValue();
            emailContext.NumberOfTourists = memberNum;
            return emailContext;
            
        }catch(Exception ex){
            Console.WriteLine(ex);
            throw;
        }

        
        
        
        
    }
}    
