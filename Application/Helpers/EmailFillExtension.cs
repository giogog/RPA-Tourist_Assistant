using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Tourist_Assistant.Application.Models;

namespace Tourist_Assistant.Application.Helpers;

public static class EmailFillExtension
{
    public static List<Client> FillClientModel(this Dictionary<string,List<string>> context)
    {
        try{
            var memberNum = context.FirstOrDefault(v=>v.Key.Contains("Last/Family names (as shown on your passport)") || 
            v.Key.Contains("Apellidos/Apellidos (como se muestran en su pasaporte)")).Value.Count();
            
            List<Client> clients = new List<Client>();
            for(int i = 0; i<memberNum;i++)
            {
                Client clientContext = new Client();
                clientContext.Name = context.FirstOrDefault(v=>v.Key.Contains("First/Given names (as shown on your passport)") || v.Key.Contains("Nombres/nombres (como se muestra en su pasaporte)")).ReturnDictionaryStringValue(i);
                clientContext.Surname = context.FirstOrDefault(v => v.Key.Contains("Last/Family names (as shown on your passport)") || v.Key.Contains("Apellidos/Apellidos (como se muestran en su pasaporte)")).ReturnDictionaryStringValue(i);
                clientContext.BirthDate = context.FirstOrDefault(v => v.Key.Contains("Date of birth") || v.Key.Contains("Fecha de nacimiento")).ReturnDictionaryStringValue(i);
                clientContext.Gender = context.FirstOrDefault(v => v.Key.Contains("Gender") || v.Key.Contains("Género")).ReturnDictionaryStringValue(i);
                clientContext.PassportNum = context.FirstOrDefault(v => v.Key.Contains("Passport number") || v.Key.Contains("Número de pasaporte")).ReturnDictionaryStringValue(i);
                clientContext.PassportCountry = context.FirstOrDefault(v => v.Key.Contains("Passport issuing country") || v.Key.Contains("País emisor del pasaporte")).ReturnDictionaryStringValue(i);
                clientContext.JourneyType = context.FirstOrDefault(v => v.Key.Contains("You are") || v.Key.Contains("Eres")).ReturnDictionaryStringValue(0);
                clientContext.FlightType = context.FirstOrDefault(v => v.Key.Contains("You travel with") || v.Key.Contains("Viajas con")).ReturnDictionaryStringValue(0);
                clientContext.DepartureAirport = context.FirstOrDefault(v => v.Key.Contains("Airport of departure to Colombia") || v.Key.Contains("Airport of departure from Colombia") || v.Key.Contains("Aeropuerto de salida a Colombia") || v.Key.Contains("Aeropuerto de salida de Colombia")).ReturnDictionaryStringValue(0);
                clientContext.ArrivalAirport = context.Where(v => v.Key.Contains("Airport of arrival in Colombia") || v.Key.Contains("Aeropuerto de llegada a Colombia"))?.FirstOrDefault().ReturnDictionaryStringValue(0);  
                clientContext.ArrivalDate = context.FirstOrDefault(v => v.Key.Contains("Date of arrival in Colombia") || v.Key.Contains("Date of leaving Colombia") || v.Key.Contains("Fecha de salida de Colombia") || v.Key.Contains("Fecha de llegada a Colombia")).ReturnDictionaryStringValue(0);
                clientContext.FlightNum = context.FirstOrDefault(v => v.Key.Contains("Flight number (you will be landing under in Colombia)") || v.Key.Contains("Flight number") || v.Key.Contains("Número de vuelo") || v.Key.Contains("Número de vuelo (bajo el cual aterrizará en Colombia)")).ReturnDictionaryStringValue(0);            
                clientContext.Address = context.FirstOrDefault(v => v.Key.Contains("Name and address (city, street #)") || v.Key.Contains("Nombre y dirección (ciudad, calle #)")).ReturnDictionaryStringValue(0);
                clientContext.PhoneNumber = context.FirstOrDefault(v => v.Key.Contains("Local phone number") || v.Key.Contains("Número de teléfono local")).ReturnDictionaryStringValue(0);
                clientContext.Email = context.FirstOrDefault(v => v.Key.Contains("Your e-mail address") || v.Key.Contains("Su dirección de correo electrónico")).ReturnDictionaryStringValue(0);
                clientContext.NumberOfTourists = memberNum;
                clients.Add(clientContext);
            }

            return clients;
            
        }catch(Exception ex){
            Console.WriteLine(ex);
            throw;
        }

        
        
        
        
    }
}    
