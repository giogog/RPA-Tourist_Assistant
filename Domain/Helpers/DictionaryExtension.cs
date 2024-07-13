using System;
using System.Collections.Generic;
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

namespace Tourist_Assistant.Domain.Helpers;
public static class DictionaryExtension
{
    public static string? ReturnDictionaryStringValue(this KeyValuePair<string, List<string>> context)
    {
        if(context.Key == null && context.Value == null){
            return null;
        }
        return context.Value[0];
    }
    
        public static List<string>? ReturnDictionaryListValue(this KeyValuePair<string, List<string>> context)
    {
        if(context.Key == null && context.Value == null){
            return null;
        }
        return context.Value;
    }
}