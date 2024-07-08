using Domain.Helpers;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using UiPath.Mail;
using UiPath.Mail.Activities.Api;

namespace Application.Service
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
        
        public async Task<List<MailMessage>> GetMailsAsync(EmailOptions MailOptions)
        {
            var token = new System.Threading.CancellationToken();
            var emails = await ImapService.GetMessagesAsync(MailOptions,token);
            return emails.Where(m=>m.DateAsDateTime() > MailOptions.StartDate && m.DateAsDateTime() < MailOptions.EndDate).ToList();

        }
        
        
    }
}