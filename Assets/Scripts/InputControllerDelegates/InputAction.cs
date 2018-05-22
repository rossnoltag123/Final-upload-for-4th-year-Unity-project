using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputAction
{
    private InputControllerDelegate inputController;
    public BoardController controller;

    public void SetLevelController(BoardController controller)
    {//for use later when connecting up to list array
        this.controller = controller;
    }

    public void SetInputController(InputControllerDelegate inputController){
        this.inputController = inputController;
    }

    void OnEnable(){
        inputController.WalkDirection += ActionLightTile;
    }

    void OnDisable(){
        inputController.WalkDirection -= ActionLightTile;
    }

    public void ActionLightTile()//Pssoble parameter m.Walk(LevelModel.CompassDirection.NORTH);LIST
    {

    }

}