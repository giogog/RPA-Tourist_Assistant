using System;
using System.Activities;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Utils;
using System.Threading;
using System.Threading.Tasks;

namespace Tourist_Assistant.Controllers
{
    [System.ComponentModel.Browsable(false)]
    public class EmailWorkflowActivity : System.Activities.Activity
    {
        public OutArgument<System.Collections.Generic.List<System.Net.Mail.MailMessage>> Output { get; set; }

        public EmailWorkflowActivity()
        {
            this.Implementation = () =>
            {
                return new EmailWorkflowActivityChild()
                {Output = (this.Output == null ? (OutArgument<System.Collections.Generic.List<System.Net.Mail.MailMessage>>)Argument.CreateReference((Argument)new OutArgument<System.Collections.Generic.List<System.Net.Mail.MailMessage>>(), "Output") : (OutArgument<System.Collections.Generic.List<System.Net.Mail.MailMessage>>)Argument.CreateReference((Argument)this.Output, "Output")), };
            };
        }
    }

    [System.ComponentModel.Browsable(false)]
    internal class EmailWorkflowActivityChild : UiPath.CodedWorkflows.AsyncTaskCodedWorkflowActivity
    {
        public OutArgument<System.Collections.Generic.List<System.Net.Mail.MailMessage>> Output { get; set; }

        public System.Collections.Generic.IDictionary<string, object> newResult { get; set; }

        public EmailWorkflowActivityChild()
        {
            DisplayName = "EmailWorkflow";
        }

        protected override async Task<Action<AsyncCodeActivityContext>> ExecuteAsync(AsyncCodeActivityContext context, System.Threading.CancellationToken cancellationToken)
        {
            var codedWorkflow = new global::Tourist_Assistant.Controllers.EmailWorkflow();
            CodedWorkflowHelper.Initialize(codedWorkflow, context);
            var result = await codedWorkflow.Execute();
            newResult = new System.Collections.Generic.Dictionary<string, object>{{"Output", result}};
            return endContext =>
            {
                Output.Set(endContext, (System.Collections.Generic.List<System.Net.Mail.MailMessage>)newResult["Output"]);
            };
        }
    }
}