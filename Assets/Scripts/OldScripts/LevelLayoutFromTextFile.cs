using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class LevelLayoutFromTextFile
{

    public string levelLayOutString;            //After ReadTextFile() has been called, this string will equal the text file text in a string,
    public string[] levelLayOutArrayRead;       //this array will hold the string broken into single characters for editing.
    public string[] levelLayOutArrayWrite;      //In the case of updating the text-file for the display.

    public void ReadTextFile()
    {        
        string path = "Assets/Resources/LevelDesign.txt";                   //Assign Path to text file
        StreamReader reader = new StreamReader(path);                       //(path) is passed to StreamReaded to read in 
        levelLayOutString = reader.ReadToEnd();                             //Convert the text file to a string
        levelLayOutArrayRead = levelLayOutString.Split(' ');                //Split the string into an array for changing position.                                                                 
        levelLayOutArrayWrite = levelLayOutString.Split(' ');
       
      //  Debug.Log(levelLayOutArrayWrite[0]);
        reader.Close();
    }

    public void WriteString(string [] s)
    { 

        string path = "Assets/Resources/LevelDesign.txt";
        StreamWriter writer = new StreamWriter(path, true);
        levelLayOutString = s.ToString();
        Debug.Log("After Test"+levelLayOutString);
        //writer.WriteLine("Test");
        writer.Close();
    }
    
}


