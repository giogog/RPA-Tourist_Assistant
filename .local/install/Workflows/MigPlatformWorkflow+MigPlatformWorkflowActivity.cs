using System;
using System.Activities;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Utils;
using System.Threading;
using System.Threading.Tasks;

namespace Tourist_Assistant.WorkFlows
{
    [System.ComponentModel.Browsable(false)]
    public class MigPlatformWorkflowActivity : System.Activities.Activity
    {
        public InArgument<Tourist_Assistant.Domain.Models.Email> emailContext { get; set; }

        public MigPlatformWorkflowActivity()
        {
            this.Implementation = () =>
            {
                return new MigPlatformWorkflowActivityChild()
                {emailContext = (this.emailContext == null ? (InArgument<Tourist_Assistant.Domain.Models.Email>)Argument.CreateReference((Argument)new InArgument<Tourist_Assistant.Domain.Models.Email>(), "emailContext") : (InArgument<Tourist_Assistant.Domain.Models.Email>)Argument.CreateReference((Argument)this.emailContext, "emailContext")), };
            };
        }
    }

    [System.ComponentModel.Browsable(false)]
    internal class MigPlatformWorkflowActivityChild : UiPath.CodedWorkflows.AsyncTaskCodedWorkflowActivity
    {
        public InArgument<Tourist_Assistant.Domain.Models.Email> emailContext { get; set; }

        public System.Collections.Generic.IDictionary<string, object> newResult { get; set; }

        public MigPlatformWorkflowActivityChild()
        {
            DisplayName = "MigPlatformWorkflow";
        }

        protected override async Task<Action<AsyncCodeActivityContext>> ExecuteAsync(AsyncCodeActivityContext context, System.Threading.CancellationToken cancellationToken)
        {
            var codedWorkflow = new global::Tourist_Assistant.Workflows.MigPlatformWorkflow();
            CodedWorkflowHelper.Initialize(codedWorkflow, context);
            await codedWorkflow.Execute(emailContext.Get(context));
            ;
            return endContext =>
            {
            };
        }
    }
}