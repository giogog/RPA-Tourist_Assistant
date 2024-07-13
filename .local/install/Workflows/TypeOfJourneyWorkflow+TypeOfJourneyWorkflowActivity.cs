using System;
using System.Activities;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Utils;
using System.Threading;
using System.Threading.Tasks;

namespace Tourist_Assistant.WorkFlows
{
    [System.ComponentModel.Browsable(false)]
    public class TypeOfJourneyWorkflowActivity : System.Activities.Activity
    {
        public InArgument<System.String> journeyType { get; set; }

        public TypeOfJourneyWorkflowActivity()
        {
            this.Implementation = () =>
            {
                return new TypeOfJourneyWorkflowActivityChild()
                {journeyType = (this.journeyType == null ? (InArgument<System.String>)Argument.CreateReference((Argument)new InArgument<System.String>(), "journeyType") : (InArgument<System.String>)Argument.CreateReference((Argument)this.journeyType, "journeyType")), };
            };
        }
    }

    [System.ComponentModel.Browsable(false)]
    internal class TypeOfJourneyWorkflowActivityChild : UiPath.CodedWorkflows.AsyncTaskCodedWorkflowActivity
    {
        public InArgument<System.String> journeyType { get; set; }

        public System.Collections.Generic.IDictionary<string, object> newResult { get; set; }

        public TypeOfJourneyWorkflowActivityChild()
        {
            DisplayName = "TypeOfJourneyWorkflow";
        }

        protected override async Task<Action<AsyncCodeActivityContext>> ExecuteAsync(AsyncCodeActivityContext context, System.Threading.CancellationToken cancellationToken)
        {
            var codedWorkflow = new global::Tourist_Assistant.WorkFlows.TypeOfJourneyWorkflow();
            CodedWorkflowHelper.Initialize(codedWorkflow, context);
            await codedWorkflow.Execute(journeyType.Get(context));
            ;
            return endContext =>
            {
            };
        }
    }
}