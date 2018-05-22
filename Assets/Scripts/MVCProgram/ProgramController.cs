using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ProgramController{

    private BoardController boardController;
    private ProgramModel model;

    public void SetBoardController(BoardController boardController){
        this.boardController = boardController;
    }

    public void SetProgramModel(ProgramModel model){
        this.model = model;
    }

    public void AddInstructionToList(ProgramModel.ProgramInstructionType instruction){
       model.programInstructionList.Add(instruction);
    }

    public void PlayCommands(){
        foreach (ProgramModel.ProgramInstructionType instruction in model.programInstructionList){
            InstructionPointer(instruction);
        }      
    }

    public void ShowCommandsListInConsole(){
        foreach (ProgramModel.ProgramInstructionType instruction in model.programInstructionList)
            Debug.Log(instruction);
    }

    public void ClearCommandsList(){
        model.programInstructionList.Clear();
    }

    public void InstructionPointer(ProgramModel.ProgramInstructionType instruction){
        switch (instruction)
        {     
            case ProgramModel.ProgramInstructionType.LIGHTUP:
                boardController.LightUpSquare();
                break;
            case ProgramModel.ProgramInstructionType.WALK_NORTH:
                boardController.Walk(BoardModel.CompassDirection.NORTH);
                break;       
            case ProgramModel.ProgramInstructionType.WALK_SOUTH:
                boardController.Walk(BoardModel.CompassDirection.SOUTH);
                break;  
            case ProgramModel.ProgramInstructionType.WALK_EAST:
                boardController.Walk(BoardModel.CompassDirection.EAST);
                break;
            case ProgramModel.ProgramInstructionType.WALK_WEST:
                boardController.Walk(BoardModel.CompassDirection.WEST);
                break;
            case ProgramModel.ProgramInstructionType.JUMP_NORTH:
                boardController.Jump(BoardModel.CompassDirection.NORTH);
                break;
            case ProgramModel.ProgramInstructionType.JUMP_SOUTH:
                boardController.Jump(BoardModel.CompassDirection.SOUTH);
                break;
            case ProgramModel.ProgramInstructionType.JUMP_EAST:
                boardController.Jump(BoardModel.CompassDirection.EAST);
                break;            
            case ProgramModel.ProgramInstructionType.JUMP_WEST:
                boardController.Jump(BoardModel.CompassDirection.WEST);
                break; 
        }
    } 
}
