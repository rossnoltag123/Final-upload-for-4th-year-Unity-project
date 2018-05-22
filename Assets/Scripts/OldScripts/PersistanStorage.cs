using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

//This is the load a save file, and for general persistant storage, carrying points to the next scene etc.
public class PersistanStorage : MonoBehaviour
{
    /// <summary>
    /// Static reference to itself...Call this for reference to Persistant storage
    /// </summary>
    public static PersistanStorage persistantStorage;

    /// <summary>
    /// Example's permanent data
    /// </summary>
    public float test100;
    public float test200;

    /// <summary>
    /// Dont destroy on load Persistant Storage gameObject
    /// </summary>
    void Start() { DontDestroyOnLoad(gameObject); }

    void Update()
    {   
    
    }

    /// <summary>
    /// dont destroy on awake, the static reference on awake
    /// </summary>
    void Awake()
    {
        this.InstantiatePersistantStorage();
    }

    /// <summary>
    /// This creates the single pattern - only one instance of itself
    /// </summary>
    private void InstantiatePersistantStorage()
    {
           if (persistantStorage == null)
           {
            persistantStorage = this;
            DontDestroyOnLoad(gameObject); 
          }

          else if (this != persistantStorage )
             { Destroy(this.gameObject); }
    }

    /// <summary>
    /// GUI example of persistant storage 
    /// </summary>
    void OnGUI()
    {
       // GUI.Label(new Rect(700, 15, 100, 30), " test100" + test100);
      //  GUI.Label(new Rect(700, 30, 100, 30), "test200" + test200);
    }


    /// <summary>
    /// Save data to file
    /// </summary>
    public void Save()
    {   
    
         /// formats serializable data to binary
        BinaryFormatter formatter = new BinaryFormatter();


        /// Unitys persistant data path---Place to save data 
        FileStream file = File.Open(Application.persistentDataPath + "/LogicPersistantData.dat", FileMode.Open );


        /// Add variables of data to be saved here-Instance of class
        LogicData logicData = new LogicData();


        /// test data
        logicData.test100 = test100;


        ///test data
        logicData.test200 = test200;


        /// Serializing logicData to file
        formatter.Serialize(file, logicData);


        /// Close file
        file.Close();
    }

    /// <summary>
    /// Load previous saved data
    /// </summary>
    public void Load()
    {    
        
         /// If file exists at this path....
        if (File.Exists(Application.persistentDataPath + "/LogicPersistantData.dat"))
        {    
             /// Instantiate binary formatter
            BinaryFormatter formatter = new BinaryFormatter();
      
            /// Open file at destination
            FileStream file = File.Open(Application.persistentDataPath + "/LogicPersistantData.dat", FileMode.Open);


            /// Desrialize logic data
            LogicData logicData = (LogicData)formatter.Deserialize(file);
   
            /// Close file
            file.Close();

            ///Add variables of data to be loaded here
            test100 = logicData.test100;
            test200 = logicData.test200;
        }
    }
}

/// <summary>
/// Serializable class for storing data centrally
/// </summary>
[Serializable]
class LogicData
{ 
    /// <summary>
    /// Test Data
    /// </summary>
    public float test100 = 100f;

    /// <summary>
    /// Test data
    /// </summary>
    public float test200 = 100f;

}

