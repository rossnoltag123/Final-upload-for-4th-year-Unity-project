using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
/*! \mainpage My Personal Index Page
 *
 * \section intro_sec Introduction
 *
 * This Doxygen file contains document pages generated from in-code comments 
 * from a 4th year project. The project is a 3d puzzle game.
 *
 */


    /// <summary>
    /// loadGamePanel - instatiates the object in place on the inspector 
    /// </summary>
   // public GameObject loadGamePanel;

    /// <summary>
    /// Menu - instatiates the object in place on the inspector 
    /// </summary>
    public GameObject Menu;
   
    
    void Start ()
    {
  
    }

    /// <summary>
    /// Method- onclick loads the first level
    /// </summary>
    public void StartGame()
    {/// Method- onclick loads the first level
        //AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Scene2_Level1");/*!< Detailed description after the member */
    }

    /// <summary>
    /// Method- onClick loads the Main menu
    /// </summary>
    public void MainMenu()
    {
        /// Method- onClick loads the Main menu
       // AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Scene1_MainMenu");
    }

    /// <summary>
    /// Method - toggles on load game panel
    /// </summary>
    public void LoadGamePanel()
    {
      //  loadGamePanel.SetActive(true);
    }

    /// <summary>
    /// Method - toggles off game panel
    /// </summary>
    public void toggleOffGamePanel()
    {
     //   loadGamePanel.SetActive(false);
    }

    /// <summary>
    /// Method - toggles on menu
    /// </summary>
    public void ToggleOnMenu()
    {
        Menu.SetActive(true);
    }

    /// <summary>
    /// Method - toggle off menu
    /// </summary>
    public void ToggleOffMenu()
    {
        Menu.SetActive(false);
    }

    /// <summary>
    /// Method - toggles on Instructions panel
    /// </summary>  //Method - toggles on Instructions panel
    public void Instructions()
    {
       
    }

    /// <summary>
    /// Method - Quits Application
    /// </summary>
    public void QuitGame()
    {
        Application.Quit();
    }

    /// <summary>
    /// Method -Calls method that saves game to specified path
    /// </summary>
    public void SaveGame()
    {

    }

    /// <summary>
    /// Method - Calls method that loads game from specified path
    /// </summary>  
    public void LoadGame()
    {

    }
  
}
