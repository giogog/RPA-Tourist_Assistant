using System.Collections.Generic;

namespace Tourist_Assistant.Application.Helpers;
public static class DictionaryExtension
{
    public static string? ReturnDictionaryStringValue(this KeyValuePair<string, List<string>> context,int index)
    {
        if(context.Key == null && context.Value == null){
            return null;
        }
        return context.Value[index];
    }
    
    
//    public static List<string>? ReturnDictionaryListValue(this KeyValuePair<string, List<string>> context)
//    {
//        if(context.Key == null && context.Value == null){
//            return null;
//        }
//        return context.Value;
//    }
}