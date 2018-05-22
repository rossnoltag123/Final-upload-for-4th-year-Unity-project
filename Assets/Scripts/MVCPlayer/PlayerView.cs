using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerView : MonoBehaviour
{
    /// <summary>
    /// Instantiating Player Controller
    /// </summary>
    public PlayerController playerController;

    /// <summary>
    /// Instantiating GUIStyle to produce view
    /// </summary>
    private GUIStyle guiStyle = new GUIStyle();

    /// <summary>
    /// Instantiating Player Controller
    /// </summary>
    void Awake()
    {
        playerController = new PlayerController();
    }

    /// <summary>
    /// This method will create a GUI features on the UI
    /// </summary>
    void OnGUI()
    {
        guiStyle.fontSize = 20;
      //  GUI.contentColor = Color.blue;
      //  GUI.Label(new Rect(50, 15, 300, 100), "Score: " + playerController.player.GetScore(), guiStyle);
       // GUI.Label(new Rect(350, 15, 200, 40), "Move Left: "+ playerController.player.GetMoves(), guiStyle);
      //  GUI.Label(new Rect(650, 15, 200, 40), "Name: "+ playerController.player.GetName(), guiStyle);     
    }
}
