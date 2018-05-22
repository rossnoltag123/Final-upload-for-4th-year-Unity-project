using UnityEngine;
using UnityEditor;
using System.IO;

public class DisplayWindow : EditorWindow {

    //This is an idea i was playing around with to try display the game in
    // and editior window. The original idea i had was to try display the whole
    // game in the debug window. Check the menu bar at the top for DislpayWindow.

    public string  ReadTextFile()
    {
        string path = "Assets/Resources/LevelDesign.txt";
        StreamReader reader = new StreamReader(path);
        string levelLayOutString = reader.ReadToEnd().ToString();
        reader.Close();
        return levelLayOutString;   
    }
   
    [MenuItem("DisplayWindow/Window")]
    public static void ShowWindow()
    {
        GetWindow<DisplayWindow>("Game");
    }

    void OnGUI()
    {
        GUILayout.Label("Level 1", EditorStyles.boldLabel);
        GUILayout.Label(ReadTextFile(), EditorStyles.label);
    }  
}
