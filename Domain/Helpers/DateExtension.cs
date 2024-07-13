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

public static class DateExtensions
{
    public static string ToFormattedDateString(this string dateString)
    {
        DateTime parsedDate;
        if (DateTime.TryParseExact(dateString, "dd MMM yyyy", 
            System.Globalization.CultureInfo.InvariantCulture, 
            System.Globalization.DateTimeStyles.None, out parsedDate))
        {
            return parsedDate.ToString("MM/dd/yyyy");
        }
        else if(DateTime.TryParseExact(dateString, "dd MMMM yyyy", 
            System.Globalization.CultureInfo.InvariantCulture, 
            System.Globalization.DateTimeStyles.None, out parsedDate))
        {
            return parsedDate.ToString("MM/dd/yyyy");        
        }
        else
        {
            // Handle the case where the date string is not in the expected format
            throw new ArgumentException("Invalid date format.");
        }
    }
}

