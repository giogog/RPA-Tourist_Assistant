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
        /// Invokes the WorkFlows/EmailWorkflow.cs
        /// </summary>
        public System.Collections.Generic.List<System.Net.Mail.MailMessage> EmailWorkflow()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"WorkFlows\EmailWorkflow.cs", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
            return (System.Collections.Generic.List<System.Net.Mail.MailMessage>)result["Output"];
        }

        /// <summary>
        /// Invokes the WorkFlows/TypeOfJourneyWorkflow.cs
        /// </summary>
        public void TypeOfJourneyWorkflow(System.String journeyType)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"WorkFlows\TypeOfJourneyWorkflow.cs", new Dictionary<string, object>{{"journeyType", journeyType}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Main.cs
        /// </summary>
        public void Main()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Main.cs", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the WorkFlows/TravelInformationlWorkFlow.cs
        /// </summary>
        public void TravelInformationlWorkFlow(Tourist_Assistant.Domain.Models.Email emailContext)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"WorkFlows\TravelInformationlWorkFlow.cs", new Dictionary<string, object>{{"emailContext", emailContext}}, default, default, default, GetAssemblyName());
        }

        private string GetAssemblyName()
        {
            var assemblyProvider = _services.Container.Resolve<ILibraryAssemblyProvider>();
            return assemblyProvider.GetLibraryAssemblyName(GetType().Assembly);
        }
    }
}