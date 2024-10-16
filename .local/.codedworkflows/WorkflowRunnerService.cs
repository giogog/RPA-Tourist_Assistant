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
        /// Invokes the Sequences/CheckReport.xaml
        /// </summary>
        public bool CheckReport(string in_Email, string in_Status)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Sequences\CheckReport.xaml", new Dictionary<string, object>{{"in_Email", in_Email}, {"in_Status", in_Status}}, default, default, default, GetAssemblyName());
            return (bool)result["out_Status"];
        }

        /// <summary>
        /// Invokes the Sequences/CheckReport.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public bool CheckReport(string in_Email, string in_Status, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Sequences\CheckReport.xaml", new Dictionary<string, object>{{"in_Email", in_Email}, {"in_Status", in_Status}}, default, isolated, default, GetAssemblyName());
            return (bool)result["out_Status"];
        }

        /// <summary>
        /// Invokes the Sequences/GetDates.xaml
        /// </summary>
        public (System.DateTime EndDate_dt, System.DateTime StartDate_dt) GetDates()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Sequences\GetDates.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
            return ((System.DateTime)result["EndDate_dt"], (System.DateTime)result["StartDate_dt"]);
        }

        /// <summary>
        /// Invokes the Sequences/GetDates.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public (System.DateTime EndDate_dt, System.DateTime StartDate_dt) GetDates(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Sequences\GetDates.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
            return ((System.DateTime)result["EndDate_dt"], (System.DateTime)result["StartDate_dt"]);
        }

        /// <summary>
        /// Invokes the Sequences/GoogleSearch.xaml
        /// </summary>
        public string GoogleSearch(string in_AirportName)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Sequences\GoogleSearch.xaml", new Dictionary<string, object>{{"in_AirportName", in_AirportName}}, default, default, default, GetAssemblyName());
            return (string)result["out_Code"];
        }

        /// <summary>
        /// Invokes the Sequences/GoogleSearch.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public string GoogleSearch(string in_AirportName, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Sequences\GoogleSearch.xaml", new Dictionary<string, object>{{"in_AirportName", in_AirportName}}, default, isolated, default, GetAssemblyName());
            return (string)result["out_Code"];
        }

        /// <summary>
        /// Invokes the Sequences/GetCountry.xaml
        /// </summary>
        public string GetCountry(string in_Country)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Sequences\GetCountry.xaml", new Dictionary<string, object>{{"in_Country", in_Country}}, default, default, default, GetAssemblyName());
            return (string)result["out_Country"];
        }

        /// <summary>
        /// Invokes the Sequences/GetCountry.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public string GetCountry(string in_Country, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Sequences\GetCountry.xaml", new Dictionary<string, object>{{"in_Country", in_Country}}, default, isolated, default, GetAssemblyName());
            return (string)result["out_Country"];
        }

        /// <summary>
        /// Invokes the Sequences/CreateReport.xaml
        /// </summary>
        public void CreateReport()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Sequences\CreateReport.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Sequences/CreateReport.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void CreateReport(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Sequences\CreateReport.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Sequences/NotRobot.xaml
        /// </summary>
        public void NotRobot()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Sequences\NotRobot.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Sequences/NotRobot.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void NotRobot(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Sequences\NotRobot.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the WorkFlows/PersonalInfoWorkflow.cs
        /// </summary>
        public void PersonalInfoWorkflow(Tourist_Assistant.Application.Models.Client clientContext)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"WorkFlows\PersonalInfoWorkflow.cs", new Dictionary<string, object>{{"clientContext", clientContext}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the WorkFlows/PersonalInfoWorkflow.cs
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void PersonalInfoWorkflow(Tourist_Assistant.Application.Models.Client clientContext, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"WorkFlows\PersonalInfoWorkflow.cs", new Dictionary<string, object>{{"clientContext", clientContext}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the WorkFlows/TravelInformationlWorkFlow.cs
        /// </summary>
        public System.String TravelInformationlWorkFlow(Tourist_Assistant.Application.Models.Client clientContext)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"WorkFlows\TravelInformationlWorkFlow.cs", new Dictionary<string, object>{{"clientContext", clientContext}}, default, default, default, GetAssemblyName());
            return (System.String)result["Output"];
        }

        /// <summary>
        /// Invokes the WorkFlows/TravelInformationlWorkFlow.cs
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public System.String TravelInformationlWorkFlow(Tourist_Assistant.Application.Models.Client clientContext, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"WorkFlows\TravelInformationlWorkFlow.cs", new Dictionary<string, object>{{"clientContext", clientContext}}, default, isolated, default, GetAssemblyName());
            return (System.String)result["Output"];
        }

        /// <summary>
        /// Invokes the WorkFlows/FinilizingWorkflow.cs
        /// </summary>
        public void FinilizingWorkflow(Tourist_Assistant.Application.Models.Client clientContext, System.String airportCity)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"WorkFlows\FinilizingWorkflow.cs", new Dictionary<string, object>{{"clientContext", clientContext}, {"airportCity", airportCity}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the WorkFlows/FinilizingWorkflow.cs
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void FinilizingWorkflow(Tourist_Assistant.Application.Models.Client clientContext, System.String airportCity, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"WorkFlows\FinilizingWorkflow.cs", new Dictionary<string, object>{{"clientContext", clientContext}, {"airportCity", airportCity}}, default, isolated, default, GetAssemblyName());
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
        /// Invokes the WorkFlows/EmailWorkflow.cs
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public System.Collections.Generic.List<System.Net.Mail.MailMessage> EmailWorkflow(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"WorkFlows\EmailWorkflow.cs", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
            return (System.Collections.Generic.List<System.Net.Mail.MailMessage>)result["Output"];
        }

        /// <summary>
        /// Invokes the Sequences/SendMail.xaml
        /// </summary>
        public void SendMail(string in_subjectEmail, string[] in_persoanlIds, string in_subjectName)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Sequences\SendMail.xaml", new Dictionary<string, object>{{"in_subjectEmail", in_subjectEmail}, {"in_persoanlIds", in_persoanlIds}, {"in_subjectName", in_subjectName}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Sequences/SendMail.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void SendMail(string in_subjectEmail, string[] in_persoanlIds, string in_subjectName, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Sequences\SendMail.xaml", new Dictionary<string, object>{{"in_subjectEmail", in_subjectEmail}, {"in_persoanlIds", in_persoanlIds}, {"in_subjectName", in_subjectName}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Main.cs
        /// </summary>
        public void Main()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Main.cs", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Main.cs
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Main(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Main.cs", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Sequences/QuiteChrome.xaml
        /// </summary>
        public void QuiteChrome()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Sequences\QuiteChrome.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Sequences/QuiteChrome.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void QuiteChrome(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Sequences\QuiteChrome.xaml", new Dictionary<string, object>{}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the WorkFlows/TypeOfJourneyWorkflow.cs
        /// </summary>
        public void TypeOfJourneyWorkflow(System.String journeyType)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"WorkFlows\TypeOfJourneyWorkflow.cs", new Dictionary<string, object>{{"journeyType", journeyType}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the WorkFlows/TypeOfJourneyWorkflow.cs
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void TypeOfJourneyWorkflow(System.String journeyType, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"WorkFlows\TypeOfJourneyWorkflow.cs", new Dictionary<string, object>{{"journeyType", journeyType}}, default, isolated, default, GetAssemblyName());
        }

        private string GetAssemblyName()
        {
            var assemblyProvider = _services.Container.Resolve<ILibraryAssemblyProvider>();
            return assemblyProvider.GetLibraryAssemblyName(GetType().Assembly);
        }
    }
}