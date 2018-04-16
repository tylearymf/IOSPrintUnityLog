using UnityEngine;

public class IOSLogger 
{
#if UNITY_IOS && !UNITY_EDITOR
	[DllImport ("__Internal")]
	static extern void DebugUnityLog(string pMessage);

	public static void Log(string pMessage)
	{
		DebugUnityLog(pMessage);
	}
#else
    public static void Log(string pMessage)
	{
	}
#endif
}
