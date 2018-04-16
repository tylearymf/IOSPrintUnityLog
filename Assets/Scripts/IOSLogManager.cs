using UnityEngine;

public static class IOSLogManager
{
    static public void Setup()
    {
        Application.logMessageReceived -= Log;
        Application.logMessageReceived += Log;
    }

    static void Log(string pMessage, string pStackTrace, LogType pLogType)
    {
        var tMessage = new System.Text.StringBuilder();
        tMessage.Append(System.Environment.NewLine);
        tMessage.Append(pLogType);
        tMessage.Append("\t");
        tMessage.Append(pMessage);
        tMessage.Append(System.Environment.NewLine);
        tMessage.Append(pStackTrace);

        IOSLogger.Log(tMessage.ToString());
    }
}