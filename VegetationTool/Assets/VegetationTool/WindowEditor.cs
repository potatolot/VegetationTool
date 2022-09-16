#if UNITY_EDITOR

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class WindowEditor : EditorWindow
{

    [MenuItem("Window/Vegetation Tool")]
    public static void ShowWindow()
    {
        GetWindow<WindowEditor>("Vegetation Tool");
    }

    void OnGUI()
    {
        GUILayout.Label("This is a label", EditorStyles.boldLabel);
    }
}

#endif