using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputJump : MonoBehaviour {

    private InputControllerDelegate inputController;
    public BoardController controller;

    public void SetLevelController(BoardController controller)
    {
        this.controller = controller;
    }

    public void SetInputController(InputControllerDelegate inputController)
    {
        this.inputController = inputController;
    }

    void OnEnable()
    {
        inputController.WalkDirection += JumpInTheDirectionOf;
    }

    void OnDisable()
    {
        inputController.WalkDirection -= JumpInTheDirectionOf;
    }
    //change name
    public void JumpInTheDirectionOf()//Pssoble parameter m.Walk(LevelModel.CompassDirection.NORTH);LIST
    {

    }
}
