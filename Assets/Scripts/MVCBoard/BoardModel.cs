using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

/// <summary>
/// This calss represents the board/level displayed.
/// </summary>
public class BoardModel{

    public enum SquareType{
        TARGET_H0_UNLIT, //Target_H0_UNLIT is the default square type for all squares in new map
        TARGET_H1_UNLIT,
        TARGET_H2_UNLIT,
        EMPTY_H0,
        EMPTY_H1,
        EMPTY_H2,
        TARGET_H0_LIT,
        TARGET_H1_LIT,
        TARGET_H2_LIT,
        EDGE_OF_BOARD,
        IMPASSABLE_PIT,
        IMPASSABLE_VOLCANO
    };

    /// <summary>
    /// Each direction is the possible directions the user can travel
    /// </summary>
    public enum CompassDirection{
        NORTH,
        SOUTH,
        EAST,
        WEST
    };

    public static readonly string[] Player = new string[12];
    public static readonly string[] SquareTypeToChar = new string[12];
    public static readonly int[] TileTypeHeight = new int[12];
    public static readonly int[] LightableSquareTypes = new int[12];
    public static readonly int[] ImpassableSquareTypes = new int[12];
    public static readonly int[] WalkableSquareTypes = new int[12];
    public static readonly SquareType[] UnlitToLit = new SquareType[12];
    public SquareType moveToSquareType {get;set;}
    public SquareType currentPlayerSquareType;
    public SquareType[,] map { get; set; }
    public int mapSize { get; set; }
    public int playerX { get; set; }
    public int playerY { get; set; }
    public int moveToSquareX { get; set; }
    public int moveToSquareY { get; set; }
    public static readonly int[] xMoves = new int[4];
    public static readonly int[] yMoves = new int[4];
    private bool lastActionSuccess = false;

    public BoardModel(int mapSize){
        this.mapSize = mapSize;
        map = new SquareType[this.mapSize, this.mapSize];
        FillStaticArrays();
    }

    /// <summary>
    /// Fills all the statics arrays
    /// </summary>
    private void FillStaticArrays(){
        SetXMoveForDirection();
        SetYMoveForDirection();
        SetTileTypeHeight();
        SetLightableTileValue();
        SetUnlitToLit();
        SetImpassableSquareTypes();
        SetSameLevelSquareTypes();
        TypeToChar();
        PlayerTypeToChar();
    }

    /// <summary>
    /// Returns a bool to confirm wether the move was completed
    /// </summary>
    /// <returns></returns>
    public bool GetLastActionSuccess(){
        return lastActionSuccess;
    }

    public SquareType CurrentPlayerSquareType(){
        currentPlayerSquareType = map[playerX, playerY];
        return currentPlayerSquareType;
    }

    public SquareType MovetoSquare(CompassDirection direction){
        moveToSquareX = GetMoveToSquareX(direction);
        moveToSquareY = GetMoveToSquareY(direction);
        moveToSquareType = map[moveToSquareX, moveToSquareY];
        return moveToSquareType;
    }

    public bool PlayerWalk(CompassDirection direction){
        currentPlayerSquareType = CurrentPlayerSquareType();
        SquareType moveToSquareType = MovetoSquare(direction);

        bool squareIsImpassable = CheckIfImpassableSquareType(moveToSquareType);
        if (squareIsImpassable){
            lastActionSuccess = false;
            return lastActionSuccess;
        }
        // test for empty H0/H1/H2
        return TryWalk(moveToSquareType, currentPlayerSquareType, moveToSquareX, moveToSquareY);
    }

    private bool TryWalk(SquareType moveToSquareType, SquareType currentPlayerSquareType, int moveToSquareX, int moveToSquareY){
        lastActionSuccess = CheckIfSameLevel(currentPlayerSquareType, moveToSquareType);
        if (lastActionSuccess){
            playerX = moveToSquareX;
            playerY = moveToSquareY;
        }
        return lastActionSuccess;
    }

    public bool PlayerJump(CompassDirection direction){
        currentPlayerSquareType = CurrentPlayerSquareType();
        SquareType moveToSquareType = MovetoSquare(direction);
        lastActionSuccess = DestinationOneAboveCurrent(currentPlayerSquareType, moveToSquareType);
        if (lastActionSuccess){
            playerX = moveToSquareX;
            playerY = moveToSquareY;
        }
        return lastActionSuccess;
    }

    public bool LightSquare(){
        currentPlayerSquareType = CurrentPlayerSquareType();
        lastActionSuccess = CheckIfUnlitSquareType(currentPlayerSquareType);
        if (lastActionSuccess){
            map[playerX,playerY]= GetUnlitToLit(currentPlayerSquareType);
        }
        return lastActionSuccess;
    }

    public int GetMoveToSquareX(CompassDirection direction)
    {
        int xMove = GetXMoveForDirection(direction);
        if (playerX + xMove >= 0){
            return playerX + xMove;
        }
        return 0;
    }

    public void SetXMoveForDirection(){
        xMoves[(int)CompassDirection.NORTH] = -1;
        xMoves[(int)CompassDirection.SOUTH] = 1;
        xMoves[(int)CompassDirection.EAST] = 0;
        xMoves[(int)CompassDirection.WEST] = 0;
    }

    private int GetXMoveForDirection(CompassDirection direction){
        return xMoves[(int)direction];
    }

    public int GetMoveToSquareY(CompassDirection direction){
        int yMove = GetYMoveForDirection(direction);
        if (playerY + yMove >= 0){
            return playerY + yMove;
        }
        return 0;
    }

    public void SetYMoveForDirection(){
        yMoves[(int)CompassDirection.NORTH] = 0;
        yMoves[(int)CompassDirection.SOUTH] = 0;
        yMoves[(int)CompassDirection.EAST] = 1;
        yMoves[(int)CompassDirection.WEST] = -1;
    }

    private int GetYMoveForDirection(CompassDirection direction){
        return yMoves[(int)direction];
    }

    public void SetSameLevelSquareTypes(){
        WalkableSquareTypes[(int)SquareType.EMPTY_H0] = 0;
        WalkableSquareTypes[(int)SquareType.EMPTY_H1] = 1;
        WalkableSquareTypes[(int)SquareType.EMPTY_H2] = 2;
        WalkableSquareTypes[(int)SquareType.TARGET_H0_UNLIT] = 0;
        WalkableSquareTypes[(int)SquareType.TARGET_H1_UNLIT] = 1;
        WalkableSquareTypes[(int)SquareType.TARGET_H2_UNLIT] = 2;
        WalkableSquareTypes[(int)SquareType.TARGET_H0_LIT] = 0;
        WalkableSquareTypes[(int)SquareType.TARGET_H1_LIT] = 1;
        WalkableSquareTypes[(int)SquareType.TARGET_H2_LIT] = 2;
    }

    public bool CheckIfSameLevel(SquareType currentPlayerSquareType, SquareType moveToSquareType){
        int currentTile = WalkableSquareTypes[(int)currentPlayerSquareType];
        int moveToTile = WalkableSquareTypes[(int)moveToSquareType];
        return (currentTile == moveToTile);
    }

    public void SetImpassableSquareTypes(){
        ImpassableSquareTypes[(int)SquareType.EDGE_OF_BOARD] = 0;
        ImpassableSquareTypes[(int)SquareType.IMPASSABLE_PIT] = 0;
        ImpassableSquareTypes[(int)SquareType.IMPASSABLE_VOLCANO] = 0;
        ImpassableSquareTypes[(int)SquareType.EMPTY_H0] = 1;
        ImpassableSquareTypes[(int)SquareType.EMPTY_H1] = 1;
        ImpassableSquareTypes[(int)SquareType.EMPTY_H2] = 1;
        ImpassableSquareTypes[(int)SquareType.TARGET_H0_UNLIT] = 1;
        ImpassableSquareTypes[(int)SquareType.TARGET_H1_UNLIT] = 1;
        ImpassableSquareTypes[(int)SquareType.TARGET_H2_UNLIT] = 1;
        ImpassableSquareTypes[(int)SquareType.TARGET_H0_LIT] = 1;
        ImpassableSquareTypes[(int)SquareType.TARGET_H1_LIT] = 1;
        ImpassableSquareTypes[(int)SquareType.TARGET_H2_LIT] = 1;
    }

    public bool CheckIfImpassableSquareType(SquareType moveToSquareType){
        int moveToSquare = ImpassableSquareTypes[(int)moveToSquareType];
        return (moveToSquare == 0);
    }

    public void SetTileTypeHeight(){
        TileTypeHeight[(int)SquareType.TARGET_H0_UNLIT] = 0;
        TileTypeHeight[(int)SquareType.TARGET_H1_UNLIT] = 1;
        TileTypeHeight[(int)SquareType.TARGET_H2_UNLIT] = 2;
        TileTypeHeight[(int)SquareType.TARGET_H0_LIT] = 0;
        TileTypeHeight[(int)SquareType.TARGET_H1_LIT] = 1;
        TileTypeHeight[(int)SquareType.TARGET_H2_LIT] = 2;
        TileTypeHeight[(int)SquareType.EMPTY_H0] = 0;
        TileTypeHeight[(int)SquareType.EMPTY_H1] = 1;
        TileTypeHeight[(int)SquareType.EMPTY_H2] = 2;
    }

    public bool DestinationOneAboveCurrent(SquareType currentPlayerSquareType, SquareType jumpToSquareType){
        int heightCurrentSquare = TileTypeHeight[(int)currentPlayerSquareType];
        int heightDestinationSquare = TileTypeHeight[(int)jumpToSquareType];
        return (heightDestinationSquare == heightCurrentSquare + 1 || heightDestinationSquare == heightCurrentSquare - 1);
    }

    public void SetUnlitToLit(){
        UnlitToLit[(int)SquareType.TARGET_H0_UNLIT] = SquareType.TARGET_H0_LIT;
        UnlitToLit[(int)SquareType.TARGET_H1_UNLIT] = SquareType.TARGET_H1_LIT;
        UnlitToLit[(int)SquareType.TARGET_H2_UNLIT] = SquareType.TARGET_H2_LIT;
    }

    public SquareType GetUnlitToLit(SquareType currentPlayerSquareType){
        return UnlitToLit[(int)currentPlayerSquareType];
    }

    public void SetLightableTileValue(){
        LightableSquareTypes[(int)SquareType.TARGET_H0_UNLIT] = 1;
        LightableSquareTypes[(int)SquareType.TARGET_H1_UNLIT] = 1;
        LightableSquareTypes[(int)SquareType.TARGET_H2_UNLIT] = 1;
    }

    public bool CheckIfUnlitSquareType(SquareType currentPlayerSquareType){
        int currentSquare = LightableSquareTypes[(int)currentPlayerSquareType];
        return (currentSquare == 1);
    }

    public void TypeToChar(){
        SquareTypeToChar[(int)SquareType.EDGE_OF_BOARD] = "-";
        SquareTypeToChar[(int)SquareType.IMPASSABLE_PIT] = "+";
        SquareTypeToChar[(int)SquareType.IMPASSABLE_VOLCANO] = "x";
        SquareTypeToChar[(int)SquareType.EMPTY_H0] = ".";
        SquareTypeToChar[(int)SquareType.EMPTY_H1] = ":";
        SquareTypeToChar[(int)SquareType.EMPTY_H2] = ";";
        SquareTypeToChar[(int)SquareType.TARGET_H0_UNLIT] = "!";
        SquareTypeToChar[(int)SquareType.TARGET_H1_UNLIT] = "!";
        SquareTypeToChar[(int)SquareType.TARGET_H2_UNLIT] = "!";
        SquareTypeToChar[(int)SquareType.TARGET_H0_LIT] = "*";
        SquareTypeToChar[(int)SquareType.TARGET_H1_LIT] = "*";
        SquareTypeToChar[(int)SquareType.TARGET_H2_LIT] = "*";
    }

    public void PlayerTypeToChar(){
        Player[(int)SquareType.EDGE_OF_BOARD] = "P";
        Player[(int)SquareType.IMPASSABLE_PIT] = "P";
        Player[(int)SquareType.IMPASSABLE_VOLCANO] = "P";
        Player[(int)SquareType.EMPTY_H0] = "P";
        Player[(int)SquareType.EMPTY_H1] = "P";
        Player[(int)SquareType.EMPTY_H2] = "P";
        Player[(int)SquareType.TARGET_H0_UNLIT] = "P";
        Player[(int)SquareType.TARGET_H1_UNLIT] = "P";
        Player[(int)SquareType.TARGET_H2_UNLIT] = "P";
        Player[(int)SquareType.TARGET_H0_LIT] = "P";
        Player[(int)SquareType.TARGET_H1_LIT] = "P";
        Player[(int)SquareType.TARGET_H2_LIT] = "P";
    }

    public string GetTypeToCharPlayer(BoardModel.SquareType currentPlayerSquareType){
        string P = Player[(int)currentPlayerSquareType];
        return P;
    }

    public string GetTypeToChar(BoardModel.SquareType currentSquareType){
       string t = SquareTypeToChar[(int)currentSquareType];
       return t;
    }
 
}




