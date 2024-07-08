using System.Linq;
using System.Threading.Tasks;
using Tourist_Assistant.Controllers;
using UiPath.CodedWorkflows;
using UiPath.Mail;

namespace Tourist_Assistant;
public class Main:EmailController
{
        [Workflow]
        public async Task Execute()
        {     
            var emails = await ExecuteMailRetrievalWorkFlow();
            Log(emails.Count().ToString());
            foreach (var message in emails)
            {
                Log(message.DateAsDateTime().ToString());
            }
        }
            
}