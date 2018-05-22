using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgramCommands{

    /// <summary>
    /// <Func<bool>> allows to store a method with a return type bool
    /// </summary>
    /// 
    public List<Func<bool>> programCommands = new List<Func<bool>>();

   // public List<ProgramModel.ProgramInstructions> programInstructionList = new List<ProgramModel.ProgramInstructions>();
    public ProgramModel model;

    public void SetModel(ProgramModel model){
        this.model = model;
    }

    public void AddLightSquareToCommandsList(){
     //  programCommands.Add(model.LightSquare);
    }

    public void AddWalkToCommandList(ProgramModel.ProgramInstructionType instruction){
      //programInstructionList.Add( instruction);
      //  programCommands.Add(() => model.PlayerWalk(direction));
    }

    public void AddJumpToCommandList(BoardModel.CompassDirection direction){
      //  programCommands.Add(() => model.PlayerJump(direction));
    }

    public void PlayCommands(){
       // foreach (ProgramModel.ProgramInstructions instruction in programInstructionList)
      //  {
          //  instruction;
     //   }      
    }

    public void ShowCommandsListInConsole(){
        foreach (Func<bool> command in programCommands)
            Debug.Log(command());
    }

    public void ClearCommandsList(){
        programCommands.Clear();
    }
}
