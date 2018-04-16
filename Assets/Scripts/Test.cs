using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEditor;

public class Test : MonoBehaviour
{
    private void Start()
    {
        IOSLogManager.Setup();
    }

    string mText = "Log-------------测试Log";
    void OnGUI()
    {
        mText = GUILayout.TextField(mText, GUILayout.Width(Screen.width), GUILayout.Height(100));
        if (GUILayout.Button("Log", GUILayout.Width(Screen.width), GUILayout.Height(100)))
        {
            Debug.Log(mText);
        }
    }
}