using System.Collections.Generic;
using System.Net.Mail;
using System.Threading.Tasks;
using Application.Service;

namespace Tourist_Assistant.WorkFlows
{

    public class WorkflowBase : CodedWorkflow
    {
        public async Task<Dictionary<string, List<string>>> ExecuteMailParse(MailMessage message)
        {
            Log("Parse Email");
            return EmailService.ParseEmailMessage(message);
        } 
    }
}