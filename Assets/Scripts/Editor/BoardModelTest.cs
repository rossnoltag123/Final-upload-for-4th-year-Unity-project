using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using System;
using UnityEngine;

public class BoardModelTest
{ 
    [Test]
    public void Test01_Square_Type_Enum_MapSize_Get_Set()
    {
        //Arrange
        BoardModel m = new BoardModel(1);
        int expectedResult = 1;

        //Act
        int result = m.map.Length;

        //Assert
        Assert.AreEqual(expectedResult, result);
    }

    [Test]
    public void Test02_Square_Type_Enum_Array_Setting_Values()
    {
        //Arrange
        BoardModel m = new BoardModel(4);

        m.map[0,0] = BoardModel.SquareType.EDGE_OF_BOARD;

        BoardModel.SquareType expectedResult = BoardModel.SquareType.EDGE_OF_BOARD;

        //Act
        BoardModel.SquareType result = m.map[0,0];

        //Assert
        Assert.AreEqual(expectedResult, result);
    }

    [Test]
    public void Test03_Player_X_Get_Set()
    {
        //Arrange
        BoardModel m = new BoardModel(1);

        //Set
        m.playerX = 1;
        int expectedResult = 1;

        //Act - Get
        int result = m.playerX;

        //Assert
        Assert.AreEqual(expectedResult, result);
    }

    [Test]
    public void Test04_Player_Y_Get_Set()
    {
        //Arrange
        BoardModel m = new BoardModel(1);

        //Set
        m.playerY = 1;
        int expectedResult = 1;

        //Act - Get
        int result = m.playerY;

        //Assert
        Assert.AreEqual(expectedResult, result);
    }

    [Test]
    public void test05_Constructor_MapSize()
    {
        //Arrange
        BoardModel m = new BoardModel(1);
        int expectedResult = 1;

        //Act
        int result = m.mapSize;

        //Assert    
        Assert.AreEqual(expectedResult, result);
    }

    [Test]
    public void test06_Square_Type_Map_ArraySize_In_Constructor()
    {
        //Arrange
        BoardModel m = new BoardModel(2);
        int expectedResult = 2;

        //Act
        int result1 = m.map.GetLength(0);
        int result2 = m.map.GetLength(1);

        //Assert
        Assert.AreEqual(expectedResult, result1);
        Assert.AreEqual(expectedResult, result2);
    }
 
    //Testing CompassDirections Enum Using Data provider
    [Test, TestCaseSource("ProviderCompassDirections")]
    public void test07_Player_Can_Walk_NORTH_SOUTH_EAST_WEST_From_Provider
    ( int playPositionX, int playPositionY, int mapSize, bool expectedResult, BoardModel.CompassDirection direction, BoardModel.SquareType mockLevelSquareType)
    {
        //Arrange
        BoardModel m = new BoardModel(mapSize);

        m.map[4, 5] = mockLevelSquareType;//North
        m.map[5, 6] = mockLevelSquareType;//East
        m.map[5, 5] = mockLevelSquareType;//Start Position
        m.map[6, 5] = mockLevelSquareType;//South
        m.map[5, 4] = mockLevelSquareType;//West

        m.playerX = playPositionX;
        m.playerY = playPositionY;

        m.PlayerWalk(direction);

        //Act
        bool result = m.GetLastActionSuccess();

        //Assert
        Assert.AreEqual(expectedResult, result);
    }

    //Data provider for Compass Directions Test
    static object[] ProviderCompassDirections =
    {
        new object[]{5,5,10,true,BoardModel.CompassDirection.NORTH,BoardModel.SquareType.EMPTY_H0},
        new object[]{5,5,10,true,BoardModel.CompassDirection.SOUTH,BoardModel.SquareType.EMPTY_H0},
        new object[]{5,5,10,true,BoardModel.CompassDirection.EAST,BoardModel.SquareType.EMPTY_H0},
        new object[]{5,5,10,true,BoardModel.CompassDirection.WEST,BoardModel.SquareType.EMPTY_H0}
    };

    [Test, TestCaseSource("OutOfBounds")]
    public void test08_Out_Of_Bounds_ImpassableVolcano_ImpassablePit_Move
    (int playPositionX, int playPositionY, int mapSize, bool expectedResult, BoardModel.SquareType squareType, BoardModel.CompassDirection direction)
    {
        //Arrange
        BoardModel m = new BoardModel(mapSize);
        m.playerX = playPositionX;
        m.playerY = playPositionY;

        //Out of bounds...
        m.map[2, 3] = squareType;

        m.PlayerWalk(direction);

        //Act
        bool result = m.GetLastActionSuccess();

        //Assert
        Assert.AreEqual(expectedResult, result);
    }

    static object[] OutOfBounds =
    {
        new object[]{3,3,5,false,BoardModel.SquareType.EDGE_OF_BOARD,BoardModel.CompassDirection.NORTH},
        new object[]{3,3,5,false,BoardModel.SquareType.IMPASSABLE_PIT,BoardModel.CompassDirection.NORTH},
        new object[]{3,3,5,false,BoardModel.SquareType.IMPASSABLE_VOLCANO,BoardModel.CompassDirection.NORTH}
    };

    [Test, TestCaseSource("Jump")]
    public void test09_Player_Can_Jump_From_Provider
    (int playPositionX, int playPositionY, int mapSize, bool expectedResult, BoardModel.SquareType squareType1, BoardModel.SquareType squareType2,BoardModel.CompassDirection direction)
    {
        //Arrange
        BoardModel m = new BoardModel(mapSize);

        m.playerX = playPositionX;
        m.playerY = playPositionY;

        //Setup Map tiles(mock level)
        m.map[3, 3] = squareType1;
        m.map[2, 3] = squareType2;
   
        m.PlayerJump(direction);
  
        //Act
        bool result = m.GetLastActionSuccess();

        //Assert
        Assert.AreEqual(expectedResult, result);
    }

    static object[] Jump =
    {
        new object[]{3,3,5,true,BoardModel.SquareType.EMPTY_H0,BoardModel.SquareType.EMPTY_H1,BoardModel.CompassDirection.NORTH},
        new object[]{3,3,5,true,BoardModel.SquareType.EMPTY_H1,BoardModel.SquareType.EMPTY_H2,BoardModel.CompassDirection.NORTH}
    };

    [Test]
    public void test10_Player_Cant_Jump_H0_To_H2_()
    {
        //Arrange
        BoardModel m = new BoardModel(5);

        m.map[2, 2] = BoardModel.SquareType.EMPTY_H0;
        m.map[3, 2] = BoardModel.SquareType.EMPTY_H2;

        m.playerX = 2;
        m.playerY = 2;

        m.PlayerJump(BoardModel.CompassDirection.SOUTH);

        bool expectedResult = false;

        //Act
        bool result = m.GetLastActionSuccess();

        //Assert
        Assert.AreEqual(expectedResult, result);
    }
    

    [Test, TestCaseSource("Action")]
    public void test11_Player_Can_Light_Tile_From_Provider
    (int playPositionX, int playPositionY, int mapSize, bool expectedResult, BoardModel.SquareType squareType)
    {
        //Arrange
        BoardModel m = new BoardModel(mapSize);
      
        m.map[2, 2] = squareType;
     
        m.playerX = playPositionX;
        m.playerY = playPositionY;

        m.LightSquare();
      
        //Act
        bool result = m.GetLastActionSuccess();

        //Assert
        Assert.AreEqual(expectedResult, result);
    }

    static object[] Action=
    {
        new object[]{2,2,5,true,BoardModel.SquareType.TARGET_H0_UNLIT},
        new object[]{2,2,5,true,BoardModel.SquareType.TARGET_H1_UNLIT},
        new object[]{2,2,5,true,BoardModel.SquareType.TARGET_H2_UNLIT}
    };
}


