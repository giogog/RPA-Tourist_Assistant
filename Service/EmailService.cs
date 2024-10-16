using Domain.Helpers;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Tourist_Assistant.Application.Helpers;
using Tourist_Assistant.Application.Models;
using UiPath.Mail;
using UiPath.Mail.Activities.Api;

namespace Tourist_Assistant.Service
{
    public class EmailService
    {
        private IImapMailService ImapService {get;set;}
        
        public EmailService(IMailService mail){
            ImapService = mail.Imap(new ImapConnectionOptions(EmailSettings.ServerName,EmailSettings.Port)
                {
                    Email = EmailSettings.Email,
                    Password = EmailSettings.Password,
                    SecureConnection =EmailSettings.SecureConnections,
                    Timeout = EmailSettings.Timeout
                });
        }
        
        public List<MailMessage> GetMails(EmailOptions MailOptions)
        {
            var emails = ImapService.GetMessages(MailOptions);
            return emails
                .Where(m=>m.DateAsDateTime() > MailOptions.StartDate && m.DateAsDateTime() < MailOptions.EndDate)
                .Where(m=>m.Subject.Contains("Re") == false)
                .Where(m=>m.Subject.Contains("EN"))
                .ToList();
        }
        
        public static Dictionary<string, List<string>> ParseEmailMessage(MailMessage message){
            
            var doc = new HtmlDocument();
            doc.LoadHtml(message.BodyAsHtml());
            
            HashSet<string> specificKeys = new HashSet<string>();
            if(message.Subject.Contains("ES")){
                specificKeys = new HashSet<string> { "Apellidos/Apellidos (como se muestran en su pasaporte)", "Nombres/nombres (como se muestra en su pasaporte)","Su dirección de correo electrónico","Fecha de nacimiento","Género",
                    "Número de pasaporte","País emisor del pasaporte","Eres","Viajas con","Aeropuerto de salida a Colombia","Aeropuerto de salida de Colombia","Aeropuerto de llegada a Colombia","Número de vuelo","Número de vuelo (bajo el cual aterrizará en Colombia)","","Fecha de salida de Colombia","Fecha de llegada a Colombia","Nombre y dirección (ciudad, calle #)","Número de teléfono local","Aeropuerto de salida de Colombia"};
            }else if(message.Subject.Contains("EN")){
                specificKeys = new HashSet<string> { "Last/Family names (as shown on your passport)", "First/Given names (as shown on your passport)","Your e-mail address","Date of birth","Gender","Passport number","Passport issuing country",
                    "You are","You travel with","Airport of departure to Colombia","Airport of arrival in Colombia","Airport of departure from Colombia","Date of arrival in Colombia","Date of leaving Colombia","Flight number","Flight number (you will be landing under in Colombia)","Name and address (city, street #) of accommodation point","Local phone number","Name and address (city, street #)"};
            }

            if(specificKeys.Count() == 0)
                return new Dictionary<string,List<string>>();
       
            var dictionary = new Dictionary<string, List<string>>();
            string currentKey = null;
            try{
                foreach (var row in doc.DocumentNode.SelectNodes("//table//tr"))
                {
                    var cells = row.SelectNodes("td");
                    if (cells != null && cells.Count == 2)
                    {
                        var fontElement = cells[1].SelectSingleNode("font");
                        if (fontElement != null && specificKeys.Contains(currentKey))
                        {
                            if(dictionary.ContainsKey(currentKey)){
                                var value = dictionary[currentKey];
                                value.Add(fontElement.InnerText.Trim());
                                dictionary[currentKey] = value;
                            }else{
                                dictionary[currentKey] = new List<string>(){fontElement.InnerText.Trim()};
                            }
                            
                            if(fontElement.InnerText.Trim()=="Carlos Andres")
                            System.IO.File.WriteAllText("html.txt",message.BodyAsHtml());
                        }
                    }
                    else if (cells != null && cells.Count == 1)
                    {
                        var strongElement = cells[0].SelectSingleNode("font/strong");
                        if (strongElement != null)
                        {
                            currentKey = strongElement.InnerText.Trim().TrimEnd(':');
                        }
                    }
                }
            }catch(Exception ex){
                Console.WriteLine("Parse Failed");
                Console.WriteLine(ex);
                throw;
            }

            return dictionary;

        }
        
        public async Task SendMail(List<Client> clients){
            
        }
    }
}