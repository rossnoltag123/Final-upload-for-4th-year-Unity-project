using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This class will bring all of the other classes to the front for monobehavious
/// </summary>
public class GameManagerScript : MonoBehaviour
{
    public BoardManager boardManager;
    public ProgramCommands programCommands;
    public ProgramManager programManager;
    public Text boardDisplay;
    public Text levelWinCondition;
    public Text programModeInstructions;
    public bool programModeActivated = false;
    public Toggle programModeToggle;
    public BoardController boardController;
    public ProgramController programController;

    void Start(){

        //Instatiate Board manager and the Board MVC as a component
        boardManager = new BoardManager();
        boardController = new BoardController();
        boardManager.SetBoardController(boardController);
        boardManager.InstantiateBoardMVC();
        BoardLayout();

        //Instatiate Program manager and the Program MVC as a component
        programManager = new ProgramManager();
        programController = new ProgramController();
        programManager.SetProgramController(programController);
        programManager.SetBoardController(boardManager.boardController);
        programManager.InstantiateProgramModeMVC();

        //Display initial board setup
        boardDisplay.color = new Color(1,1,1,1);
        programModeInstructions.color = new Color(1,1,1,1);
        boardDisplay.text = boardManager.boardView.UpdateBoardDisplay();
      
        //Win condition UI and instructions
        levelWinCondition.text = WinConditionStatus();
    }

    public void BoardLayout(){
        boardManager.boardModel.mapSize = BoardLayoutManager.boardLayoutManager.mapSizeLib;
        boardManager.boardModel.map = BoardLayoutManager.boardLayoutManager.mapLib;
        boardManager.boardModel.playerX = BoardLayoutManager.boardLayoutManager.playerXLib;
        boardManager.boardModel.playerY = BoardLayoutManager.boardLayoutManager.playerYLib;
    }

    /// <summary>
    /// Loops through the board and checks for any unlit squares. Win condition is all Unlit equal Lit. 
    /// </summary>
    /// <returns></returns>
    public string WinConditionStatus(){
        foreach(BoardModel.SquareType tile in boardManager.boardModel.map){ 
            if(boardManager.boardModel.CheckIfUnlitSquareType(tile)){
                return boardManager.boardView.UIMoreSquresToLight();
            }
        }
        return boardManager.boardView.UILevelComplete();
    }

    /// <summary>
    /// This will be called to toggle on/off program mode
    /// </summary>
    public void ProgramModeActivated(){//false
        bool programModeOn = programModeToggle.isOn;
        if (programModeOn){
            programModeActivated = true;
        }
        if (!programModeOn){
            programModeActivated = false;
        }
    }

    /// <summary>
    /// Direct mode... 
    /// </summary>
    public void DirectLigthSquare(){
        boardManager.boardController.LightUpSquare();
        boardDisplay.text = boardManager.boardView.UpdateBoardDisplay();     
    }

    /// <summary>
    /// Program mode... will add instruction to list
    /// </summary>
    public void ProgramLigthSquare(ProgramModel.ProgramInstructionType instruction){
        programManager.programController.AddInstructionToList(instruction);
    }

    public void DirectWalk(BoardModel.CompassDirection direction){
        boardManager.boardController.Walk(direction); 
        boardDisplay.text = boardManager.boardView.UpdateBoardDisplay();
    }

    public void ProgramWalk(ProgramModel.ProgramInstructionType instruction){
        programManager.programController.AddInstructionToList(instruction);
    }

    public void DirectJump(BoardModel.CompassDirection direction){  
        boardManager.boardController.Jump(direction);
        boardDisplay.text = boardManager.boardView.UpdateBoardDisplay();     
    }

    public void ProgramJump(ProgramModel.ProgramInstructionType instruction){
        programManager.programController.AddInstructionToList(instruction);
    }

    /// <summary>
    /// call methods from list
    /// </summary>
    public void PlayProgram(){
        programManager.programController.PlayCommands();
        programManager.programController.ClearCommandsList();
        levelWinCondition.text = WinConditionStatus() + "X"+ boardManager.boardModel.playerX.ToString()  +"Y"+ boardManager.boardModel.playerY.ToString();
        programManager.programController.ShowCommandsListInConsole();
        boardDisplay.text = boardManager.boardView.UpdateBoardDisplay();
    }

    /// <summary>
    /// 
    /// </summary>
    public void ShowCommands(){
        programManager.programController.ShowCommandsListInConsole();
    }

    /// <summary>
    /// Clear list
    /// </summary>
    public void ClearCommandsButton(){
        programManager.programController.ClearCommandsList();
        programManager.programView.ClearStrings();
        programModeInstructions.text = "";
    }

    /// <summary>
    /// OnClick button methods to call each move
    /// </summary>
    public void LightSquareButton(){
        if (!programModeActivated){
            DirectLigthSquare();
        }
        if (programModeActivated){
            ProgramLigthSquare(ProgramModel.ProgramInstructionType.LIGHTUP);
        }
        programModeInstructions.text = programManager.programView.GetProgramInstruction(ProgramModel.ProgramInstructionType.LIGHTUP);
    }

    /// <summary>
    /// UI buttions, will update text display of their moves
    /// </summary>
    public void WalkNorthButton(){
        if (!programModeActivated){
            DirectWalk(BoardModel.CompassDirection.NORTH);
        }
        if (programModeActivated){
            ProgramWalk(ProgramModel.ProgramInstructionType.WALK_NORTH);
        }
        programModeInstructions.text = programManager.programView.GetProgramInstruction(ProgramModel.ProgramInstructionType.WALK_NORTH);
    }

    public void WalkSouthButton(){
        if (!programModeActivated){
            DirectWalk(BoardModel.CompassDirection.SOUTH);
        }
        if (programModeActivated){
            ProgramWalk(ProgramModel.ProgramInstructionType.WALK_SOUTH);
        }
        programModeInstructions.text = programManager.programView.GetProgramInstruction(ProgramModel.ProgramInstructionType.WALK_SOUTH);
    }

    public void WalkEastButton(){
        if (!programModeActivated){
            DirectWalk(BoardModel.CompassDirection.EAST);
        }
        if (programModeActivated){
            ProgramWalk(ProgramModel.ProgramInstructionType.WALK_EAST);
        }
        programModeInstructions.text = programManager.programView.GetProgramInstruction(ProgramModel.ProgramInstructionType.WALK_EAST);
    }

    public void WalkWestButton(){
        if (!programModeActivated){
            DirectWalk(BoardModel.CompassDirection.WEST);
        }
        if (programModeActivated){
            ProgramWalk(ProgramModel.ProgramInstructionType.WALK_WEST);
        }
        programModeInstructions.text = programManager.programView.GetProgramInstruction(ProgramModel.ProgramInstructionType.WALK_WEST);
    }

    public void JumpNorthButton(){
        if (!programModeActivated){
            DirectJump(BoardModel.CompassDirection.NORTH);
        }
        if (programModeActivated){
            ProgramJump(ProgramModel.ProgramInstructionType.JUMP_NORTH);
        }
        programModeInstructions.text = programManager.programView.GetProgramInstruction(ProgramModel.ProgramInstructionType.JUMP_NORTH);
    }

    public void JumpSouthButton(){
        if (!programModeActivated){
            DirectJump(BoardModel.CompassDirection.SOUTH);
        }
        if (programModeActivated){
            ProgramJump(ProgramModel.ProgramInstructionType.JUMP_SOUTH);
        }
        programModeInstructions.text = programManager.programView.GetProgramInstruction(ProgramModel.ProgramInstructionType.JUMP_SOUTH);
    }

    public void JumpEastButton(){
        if (!programModeActivated){
            DirectJump(BoardModel.CompassDirection.EAST);
        }
        if (programModeActivated){
            ProgramJump(ProgramModel.ProgramInstructionType.JUMP_EAST);
        }
        programModeInstructions.text = programManager.programView.GetProgramInstruction(ProgramModel.ProgramInstructionType.JUMP_EAST);
    }

    public void JumpWestButton(){
        if (!programModeActivated){
            DirectJump(BoardModel.CompassDirection.WEST);
        }
        if (programModeActivated){
            ProgramJump(ProgramModel.ProgramInstructionType.JUMP_WEST);
        }
        programModeInstructions.text = programManager.programView.GetProgramInstruction(ProgramModel.ProgramInstructionType.JUMP_WEST);
    }
}








































/*

/// <summary>
/// The program mode bool will will be checked to see if true or false. True being activated. If activated the 
/// move will be stored in a list for the program mode to run later.
/// After each attemp to light a square there will be a check to see if there are any
/// more squares left to light up,if there are not, a text will be displayed to show the player has 
/// completed the level.
/// </summary>
public bool LightSquare()
{
    if (programMode)
    {
        programModeManager.programModel.AddInstructionToProgram(ProgramModeModel.ProgramInstructions.LIGHTUP);
        listDisplay = programModeManager.programModel.GetProgramInstructions(ProgramModeModel.ProgramInstructions.LIGHTUP);

        programModeInstructions.text += listDisplay + "\n";

        return programMode;
    }
    boardManager.boardModel.LightSquare();
    boardDisplay.text = boardManager.boardView.UpdateDisplay();

    if (!CheckUnlitTilesOnBoard())
        LevelPassed.text = boardManager.boardView.LevelWonText();
    return programMode;
}

//Button options
// 2 states
// one command, put into list, played straight from list, reset list? dont reset,

//or program mode, wait until list is complete


//(for methods)
//Option 1 lambdas




/*
public bool WalkNorth()
{
    /*
    if (programMode){
        programModeManager.programModel.AddInstructionToProgram(ProgramModeModel.ProgramInstructions.WALK_NORTH);
        return programMode;
    }
   
    boardManager.boardModel.PlayerWalk(BoardModel.CompassDirection.NORTH);
    boardDisplay.text = boardManager.boardView.UpdateDisplay();
    return programMode;
}






/*

public bool WalkSouth()
{
    if (programMode)
    {
        programModeManager.programModel.AddInstructionToProgram(ProgramModeModel.ProgramInstructions.WALK_SOUTH);
        return programMode;
    }
    boardManager.boardModel.PlayerWalk(BoardModel.CompassDirection.SOUTH);
    boardDisplay.text = boardManager.boardView.UpdateDisplay();
    return programMode;
}

public bool WalkEast()
{
    if (programMode)
    {
        programModeManager.programModel.AddInstructionToProgram(ProgramModeModel.ProgramInstructions.WALK_EAST);
        return programMode;
    }
    boardManager.boardModel.PlayerWalk(BoardModel.CompassDirection.EAST);
    boardDisplay.text = boardManager.boardView.UpdateDisplay();
    return programMode;
}

public bool WalkWest()
{
    if (programMode)
    {
        programModeManager.programModel.AddInstructionToProgram(ProgramModeModel.ProgramInstructions.WALK_WEST);
        return programMode;
    }
    boardManager.boardModel.PlayerWalk(BoardModel.CompassDirection.WEST);
    boardDisplay.text = boardManager.boardView.UpdateDisplay();
    return programMode;
}

public bool JumpNorth()
{
    if (programMode)
    {
        programModeManager.programModel.AddInstructionToProgram(ProgramModeModel.ProgramInstructions.JUMP_NORTH);
        return programMode;
    }
    boardManager.boardModel.PlayerJump(BoardModel.CompassDirection.NORTH);
    boardDisplay.text = boardManager.boardView.UpdateDisplay();
    return programMode;
}

public bool JumpSouth()
{
    if (programMode)
    {
        programModeManager.programModel.AddInstructionToProgram(ProgramModeModel.ProgramInstructions.JUMP_SOUTH);
        return programMode;
    }
    boardManager.boardModel.PlayerJump(BoardModel.CompassDirection.SOUTH);
    boardDisplay.text = boardManager.boardView.UpdateDisplay();
    return programMode;
}

public bool JumpEast()
{
    if (programMode)
    {
        programModeManager.programModel.AddInstructionToProgram(ProgramModeModel.ProgramInstructions.JUMP_EAST);
        return programMode;
    }
    boardManager.boardModel.PlayerJump(BoardModel.CompassDirection.EAST);
    boardDisplay.text = boardManager.boardView.UpdateDisplay();
    return programMode;
}

public bool JumpWest()
{
    if (programMode)
    {
        programModeManager.programModel.AddInstructionToProgram(ProgramModeModel.ProgramInstructions.JUMP_WEST);
        return programMode;
    }
    boardManager.boardModel.PlayerJump(BoardModel.CompassDirection.WEST);
    boardDisplay.text = boardManager.boardView.UpdateDisplay();
    return programMode;
}

public void ShowInstructionsList()
{
    programModeManager.programModel.ShowInstructionList();
    GetProgramInstructions(ProgramModeModel.ProgramInstructions.WALK_NORTH);
}

public void CheckProgramInstructions()
{
    InstructionsCheck[(int)ProgramModeModel.ProgramInstructions.WALK_NORTH] = boardManager.boardModel.PlayerWalk(BoardModel.CompassDirection.NORTH);
    /*
    InstructionsCheck[(int)ProgramModeModel.ProgramInstructions.WALK_SOUTH] = 1;
    InstructionsCheck[(int)ProgramModeModel.ProgramInstructions.WALK_EAST] = 2;
    InstructionsCheck[(int)ProgramModeModel.ProgramInstructions.WALK_WEST] = 3;
    InstructionsCheck[(int)ProgramModeModel.ProgramInstructions.JUMP_NORTH] = 4;
    InstructionsCheck[(int)ProgramModeModel.ProgramInstructions.JUMP_SOUTH] = 5;
    InstructionsCheck[(int)ProgramModeModel.ProgramInstructions.JUMP_EAST] = 6;
    InstructionsCheck[(int)ProgramModeModel.ProgramInstructions.JUMP_WEST] = 7;
    InstructionsCheck[(int)ProgramModeModel.ProgramInstructions.LIGHTUP] = 8;
   
}

public bool GetProgramInstructions(ProgramModeModel.ProgramInstructions instruction)
{
    return InstructionsCheck[(int)instruction];
}

*/