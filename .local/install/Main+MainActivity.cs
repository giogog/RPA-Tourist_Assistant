using System;
using System.Activities;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Utils;
using System.Threading;
using System.Threading.Tasks;

namespace Tourist_Assistant
{
    [System.ComponentModel.Browsable(false)]
    public class MainActivity : System.Activities.Activity
    {
        public MainActivity()
        {
            this.Implementation = () =>
            {
                return new MainActivityChild()
                {};
            };
        }
    }

    [System.ComponentModel.Browsable(false)]
    internal class MainActivityChild : UiPath.CodedWorkflows.AsyncTaskCodedWorkflowActivity
    {
        public System.Collections.Generic.IDictionary<string, object> newResult { get; set; }

        public MainActivityChild()
        {
            DisplayName = "Main";
        }

        protected override async Task<Action<AsyncCodeActivityContext>> ExecuteAsync(AsyncCodeActivityContext context, System.Threading.CancellationToken cancellationToken)
        {
            var codedWorkflow = new global::Tourist_Assistant.Main();
            CodedWorkflowHelper.Initialize(codedWorkflow, context);
            await codedWorkflow.Execute();
            ;
            return endContext =>
            {
            };
        }
    }
}