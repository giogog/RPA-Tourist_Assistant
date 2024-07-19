using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Threading.Tasks;
using Tourist_Assistant.Service;
using Domain.Helpers;
using UiPath.CodedWorkflows;
using UiPath.Mail;

namespace Tourist_Assistant.WorkFlows
{
    public class EmailWorkflow : WorkflowBase
    {
        private EmailService _mailService;
        [Workflow]
        public async Task<List<MailMessage>> Execute()
        {
            var EmailsTask = Task.Run(() => RetrieveMails()); 
            var OpenPageTask = OpenBrowser();
            
            
            await Task.WhenAll(EmailsTask,OpenPageTask);
            
            
            return await EmailsTask;
        
        }
        
        public List<MailMessage> RetrieveMails()
        {
            Log("Mail Retrival");
            //var result = RunWorkflow("Sequences\\GetDates.xaml");
            DateTime startDate = new DateTime(2024,7,19,17,0,0);
            DateTime endDate = new DateTime(2024,7,19,23,0,0);

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
        
        public async Task OpenBrowser()
        {
            Log("Open Browser");
            uiAutomation.Open("WebPage",_targetAppOptions);
        }
    }
}