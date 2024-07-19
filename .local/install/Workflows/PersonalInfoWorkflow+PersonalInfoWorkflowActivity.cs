using System;
using System.Activities;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Utils;
using System.Threading;
using System.Threading.Tasks;

namespace Tourist_Assistant.WorkFlows
{
    [System.ComponentModel.Browsable(false)]
    public class PersonalInfoWorkflowActivity : System.Activities.Activity
    {
        public InArgument<Tourist_Assistant.Application.Models.Client> clientContext { get; set; }

        public PersonalInfoWorkflowActivity()
        {
            this.Implementation = () =>
            {
                return new PersonalInfoWorkflowActivityChild()
                {clientContext = (this.clientContext == null ? (InArgument<Tourist_Assistant.Application.Models.Client>)Argument.CreateReference((Argument)new InArgument<Tourist_Assistant.Application.Models.Client>(), "clientContext") : (InArgument<Tourist_Assistant.Application.Models.Client>)Argument.CreateReference((Argument)this.clientContext, "clientContext")), };
            };
        }
    }

    [System.ComponentModel.Browsable(false)]
    internal class PersonalInfoWorkflowActivityChild : UiPath.CodedWorkflows.AsyncTaskCodedWorkflowActivity
    {
        public InArgument<Tourist_Assistant.Application.Models.Client> clientContext { get; set; }

        public System.Collections.Generic.IDictionary<string, object> newResult { get; set; }

        public PersonalInfoWorkflowActivityChild()
        {
            DisplayName = "PersonalInfoWorkflow";
        }

        protected override async Task<Action<AsyncCodeActivityContext>> ExecuteAsync(AsyncCodeActivityContext context, System.Threading.CancellationToken cancellationToken)
        {
            var codedWorkflow = new global::Tourist_Assistant.WorkFlows.PersonalInfoWorkflow();
            CodedWorkflowHelper.Initialize(codedWorkflow, context);
            await codedWorkflow.Execute(clientContext.Get(context));
            ;
            return endContext =>
            {
            };
        }
    }
}