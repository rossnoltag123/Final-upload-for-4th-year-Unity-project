using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputWalk {

    private InputControllerDelegate inputController;
    public BoardController controller;

    public void SetLevelController(BoardController controller){
        this.controller = controller;
    }

    public void SetInputController(InputControllerDelegate inputController)
    {
        this.inputController = inputController;
    }

    void OnEnable(){
        inputController.WalkDirection += WalkInTheDirectionOf;     
    }

    void OnDisable(){
        inputController.WalkDirection -= WalkInTheDirectionOf;
    }

    //change name
    public void WalkInTheDirectionOf()//Pssoble parameter m.Walk(LevelModel.CompassDirection.NORTH);LIST
    {
        
    }

}
