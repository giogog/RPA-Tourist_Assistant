using Application.Service;
using Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Threading.Tasks;
using UiPath.Mail;

namespace Tourist_Assistant.Controllers
{
    public abstract class EmailController : ControllerBase
    {
        public virtual async Task<List<MailMessage>> ExecuteMailRetrievalWorkFlow()
        {
            var result = await RunWorkflowAsync(AppSettings.GetWorkflowPath(new[]{"Infrastructure"},"GetDates.xaml"));

            
            var MailService = new EmailService(mail);
            
            return await MailService.GetMailsAsync(new EmailOptions()
                        { 
                            Top = 50, 
                            OrderByDate = EOrderByDate.NewestFirst, 
                            OnlyUnreadMessages = false,
                            StartDate = (DateTime)result["StartDate_dt"], 
                            EndDate = (DateTime)result["EndDate_dt"]    
                        });
        }
    }
}