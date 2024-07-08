using System.IO;

namespace Tourist_Assistant;

public static class AppSettings
{
    public static readonly string BasePath = "C:\\Users\\Geekster PC\\Documents\\UiPath\\Tourist_Assistant\\";
    public static string GetWorkflowPath(string[] Folders,string WorkFlowName)
    {
        string path = BasePath;
        foreach(var folder in Folders){
            path = Path.Combine(path,folder);
        }
        return Path.Combine(path,WorkFlowName);
        
        
    }
}