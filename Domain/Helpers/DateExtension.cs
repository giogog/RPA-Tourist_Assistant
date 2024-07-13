using System;

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

