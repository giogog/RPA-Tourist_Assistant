using System;
using System.Activities;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Utils;
using System.Threading;
using System.Threading.Tasks;

namespace Tourist_Assistant.WorkFlows
{
    [System.ComponentModel.Browsable(false)]
    public class FinilizingWorkflowActivity : System.Activities.Activity
    {
        public InArgument<Tourist_Assistant.Application.Models.Client> clientContext { get; set; }

        public InArgument<System.String> airportCity { get; set; }

        public FinilizingWorkflowActivity()
        {
            this.Implementation = () =>
            {
                return new FinilizingWorkflowActivityChild()
                {clientContext = (this.clientContext == null ? (InArgument<Tourist_Assistant.Application.Models.Client>)Argument.CreateReference((Argument)new InArgument<Tourist_Assistant.Application.Models.Client>(), "clientContext") : (InArgument<Tourist_Assistant.Application.Models.Client>)Argument.CreateReference((Argument)this.clientContext, "clientContext")), airportCity = (this.airportCity == null ? (InArgument<System.String>)Argument.CreateReference((Argument)new InArgument<System.String>(), "airportCity") : (InArgument<System.String>)Argument.CreateReference((Argument)this.airportCity, "airportCity")), };
            };
        }
    }

    [System.ComponentModel.Browsable(false)]
    internal class FinilizingWorkflowActivityChild : UiPath.CodedWorkflows.AsyncTaskCodedWorkflowActivity
    {
        public InArgument<Tourist_Assistant.Application.Models.Client> clientContext { get; set; }

        public InArgument<System.String> airportCity { get; set; }

        public System.Collections.Generic.IDictionary<string, object> newResult { get; set; }

        public FinilizingWorkflowActivityChild()
        {
            DisplayName = "FinilizingWorkflow";
        }

        protected override async Task<Action<AsyncCodeActivityContext>> ExecuteAsync(AsyncCodeActivityContext context, System.Threading.CancellationToken cancellationToken)
        {
            var codedWorkflow = new global::Tourist_Assistant.WorkFlows.FinilizingWorkflow();
            CodedWorkflowHelper.Initialize(codedWorkflow, context);
            await codedWorkflow.Execute(clientContext.Get(context), airportCity.Get(context));
            ;
            return endContext =>
            {
            };
        }
    }
}