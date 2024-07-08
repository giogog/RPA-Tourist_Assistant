using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Interfaces;
using UiPath.Activities.Contracts;
using Tourist_Assistant;

[assembly: WorkflowRunnerServiceAttribute(typeof(Tourist_Assistant.WorkflowRunnerService))]
namespace Tourist_Assistant
{
    public class WorkflowRunnerService
    {
        private readonly ICodedWorkflowServices _services;
        public WorkflowRunnerService(ICodedWorkflowServices services)
        {
            _services = services;
        }

        /// <summary>
        /// Invokes the Infrastructure/GetDates.xaml
        /// </summary>
        public (System.DateTime EndDate_dt, System.DateTime StartDate_dt) GetDates()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Infrastructure\GetDates.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
            return ((System.DateTime)result["EndDate_dt"], (System.DateTime)result["StartDate_dt"]);
        }

        /// <summary>
        /// Invokes the Main.cs
        /// </summary>
        public void Main()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Main.cs", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Infrastructure/OpenBrowser.xaml
        /// </summary>
        public void OpenBrowser()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Infrastructure\OpenBrowser.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        private string GetAssemblyName()
        {
            var assemblyProvider = _services.Container.Resolve<ILibraryAssemblyProvider>();
            return assemblyProvider.GetLibraryAssemblyName(GetType().Assembly);
        }
    }
}