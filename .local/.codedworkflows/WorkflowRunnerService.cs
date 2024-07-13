using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Interfaces;
using UiPath.Activities.Contracts;
using Tourist_Assistant;
using System.Data;
using Tourist_Assistant.ObjectRepository;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Excel;
using UiPath.Excel.Activities;
using UiPath.Excel.Activities.API;
using UiPath.Excel.Activities.API.Models;
using UiPath.Mail.Activities.Api;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;

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
        /// Invokes the Infrastructure/GoogleSearch.xaml
        /// </summary>
        public string GoogleSearch(string in_AirportName)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Infrastructure\GoogleSearch.xaml", new Dictionary<string, object>{{"in_AirportName", in_AirportName}}, default, default, default, GetAssemblyName());
            return (string)result["out_Code"];
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
        /// Invokes the Infrastructure/test.cs
        /// </summary>
        public void test(System.String rame)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Infrastructure\test.cs", new Dictionary<string, object>{{"rame", rame}}, default, default, default, GetAssemblyName());
        }

        private string GetAssemblyName()
        {
            var assemblyProvider = _services.Container.Resolve<ILibraryAssemblyProvider>();
            return assemblyProvider.GetLibraryAssemblyName(GetType().Assembly);
        }
    }
}