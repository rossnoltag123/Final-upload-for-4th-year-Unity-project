using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgramView{

    private string stringProgramCommand = "";
    public string instructionString = "";
    public string listToDisplay = "";

    public void DisplayProgramInstructions(ProgramModel.ProgramInstructionType programDisplay){
        stringProgramCommand= GetProgramInstruction(programDisplay);
    }

    public string GetProgramInstruction(ProgramModel.ProgramInstructionType instruction){
        string listToDisplay = ProgramModel.instructions[(int)instruction];
        instructionString += listToDisplay + "\n";
        return instructionString;
    }

    public void ClearStrings(){
        instructionString = "";
        listToDisplay = "";
    }
}
