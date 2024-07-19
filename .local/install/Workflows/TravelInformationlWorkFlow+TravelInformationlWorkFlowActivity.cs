using System;
using System.Activities;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Utils;
using System.Threading;
using System.Threading.Tasks;

namespace Tourist_Assistant.WorkFlows
{
    [System.ComponentModel.Browsable(false)]
    public class TravelInformationlWorkflowActivity : System.Activities.Activity
    {
        public InArgument<Tourist_Assistant.Application.Models.Client> clientContext { get; set; }

        public OutArgument<System.String> Output { get; set; }

        public TravelInformationlWorkflowActivity()
        {
            this.Implementation = () =>
            {
                return new TravelInformationlWorkflowActivityChild()
                {clientContext = (this.clientContext == null ? (InArgument<Tourist_Assistant.Application.Models.Client>)Argument.CreateReference((Argument)new InArgument<Tourist_Assistant.Application.Models.Client>(), "clientContext") : (InArgument<Tourist_Assistant.Application.Models.Client>)Argument.CreateReference((Argument)this.clientContext, "clientContext")), Output = (this.Output == null ? (OutArgument<System.String>)Argument.CreateReference((Argument)new OutArgument<System.String>(), "Output") : (OutArgument<System.String>)Argument.CreateReference((Argument)this.Output, "Output")), };
            };
        }
    }

    [System.ComponentModel.Browsable(false)]
    internal class TravelInformationlWorkflowActivityChild : UiPath.CodedWorkflows.AsyncTaskCodedWorkflowActivity
    {
        public InArgument<Tourist_Assistant.Application.Models.Client> clientContext { get; set; }

        public OutArgument<System.String> Output { get; set; }

        public System.Collections.Generic.IDictionary<string, object> newResult { get; set; }

        public TravelInformationlWorkflowActivityChild()
        {
            DisplayName = "TravelInformationlWorkflow";
        }

        protected override async Task<Action<AsyncCodeActivityContext>> ExecuteAsync(AsyncCodeActivityContext context, System.Threading.CancellationToken cancellationToken)
        {
            var codedWorkflow = new global::Tourist_Assistant.Workflows.TravelInformationlWorkflow();
            CodedWorkflowHelper.Initialize(codedWorkflow, context);
            var result = await codedWorkflow.Execute(clientContext.Get(context));
            newResult = new System.Collections.Generic.Dictionary<string, object>{{"Output", result}};
            return endContext =>
            {
                Output.Set(endContext, (System.String)newResult["Output"]);
            };
        }
    }
}