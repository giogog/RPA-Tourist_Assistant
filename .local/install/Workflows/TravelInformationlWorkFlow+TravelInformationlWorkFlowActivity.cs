using System;
using System.Activities;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Utils;
using System.Threading;
using System.Threading.Tasks;

namespace Tourist_Assistant.WorkFlows
{
    [System.ComponentModel.Browsable(false)]
    public class TravelInformationlWorkFlowActivity : System.Activities.Activity
    {
        public InArgument<Tourist_Assistant.Domain.Models.Client> clientContext { get; set; }

        public TravelInformationlWorkFlowActivity()
        {
            this.Implementation = () =>
            {
                return new TravelInformationlWorkFlowActivityChild()
                {clientContext = (this.clientContext == null ? (InArgument<Tourist_Assistant.Domain.Models.Client>)Argument.CreateReference((Argument)new InArgument<Tourist_Assistant.Domain.Models.Client>(), "clientContext") : (InArgument<Tourist_Assistant.Domain.Models.Client>)Argument.CreateReference((Argument)this.clientContext, "clientContext")), };
            };
        }
    }

    [System.ComponentModel.Browsable(false)]
    internal class TravelInformationlWorkFlowActivityChild : UiPath.CodedWorkflows.AsyncTaskCodedWorkflowActivity
    {
        public InArgument<Tourist_Assistant.Domain.Models.Client> clientContext { get; set; }

        public System.Collections.Generic.IDictionary<string, object> newResult { get; set; }

        public TravelInformationlWorkFlowActivityChild()
        {
            DisplayName = "TravelInformationlWorkFlow";
        }

        protected override async Task<Action<AsyncCodeActivityContext>> ExecuteAsync(AsyncCodeActivityContext context, System.Threading.CancellationToken cancellationToken)
        {
            var codedWorkflow = new global::Tourist_Assistant.Workflows.TravelInformationlWorkFlow();
            CodedWorkflowHelper.Initialize(codedWorkflow, context);
            await codedWorkflow.Execute(clientContext.Get(context));
            ;
            return endContext =>
            {
            };
        }
    }
}