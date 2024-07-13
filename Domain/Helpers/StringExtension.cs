using System.Data;
using System.Linq;

namespace Tourist_Assistant.Domain.Helpers;

public static class StringExtensions
{
    public static string KeepNumbersOnly(this string input)
    {
        return new string(input.Where(char.IsDigit).ToArray());
    }
}
