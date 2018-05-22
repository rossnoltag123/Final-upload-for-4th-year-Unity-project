using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgramManager //MonoBehaviour
{
    public BoardController boardController;
    public ProgramController programController;
    public ProgramModel programModel;
    public ProgramView programView;

    public void SetProgramController(ProgramController programController){
        this.programController = programController;
    }

    public void SetBoardController(BoardController boardController){
        this.boardController = boardController;
    }

    public void InstantiateProgramModeMVC()
    {
        //Model
        programModel = new ProgramModel();
        programModel.SetProgramInstructions();

        //Controller
        programController.SetBoardController(boardController);
        programController.SetProgramModel(programModel);

        //View
        programView = new ProgramView();
    }
}




















