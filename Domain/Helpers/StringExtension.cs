using System.Data;
using System.Linq;

namespace Tourist_Assistant.Domain.Helpers;

public static class StringExtensions
{
    public static string KeepNumbersOnly(this string input)
    {
        return new string(input.Where(char.IsDigit).ToArray());
    }
    public static string ToProperCase(this string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            return str;
        }

        string lowerCaseStr = str.ToLower();
        return char.ToUpper(lowerCaseStr[0]) + lowerCaseStr.Substring(1);
    }
}
