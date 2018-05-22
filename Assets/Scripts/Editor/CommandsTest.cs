using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

using System;

public class CommandsTest
{
    //All Square Types are set to default TARGET_H0_UNLIT.
/*
    [Test]
    public void Test1_Adding_Action_Command_To_CommandsList()
    {
        //Arrange
        int mapSize = 1;
        BoardModel model = new BoardModel(mapSize);

        CommandsListAndMethods c = new CommandsListAndMethods();
        c.SetModel(model);  
        
        List<Func<bool>> expectedResult = c.CommandsList;
        c.AddActionToCommandsList();

        //Act
        List<Func<bool>> result = c.CommandsList;

        //Assert
        CollectionAssert.AreEqual(expectedResult, result);
    }

    [Test]
    public void Test2_Adding_Walk_Command_To_CommandsList()
    {
        //Arrange
        int mapSize = 1;
        BoardModel model = new BoardModel(mapSize);

        CommandsListAndMethods c = new CommandsListAndMethods();
        c.SetModel(model);

        List<Func<bool>> expectedResult = c.CommandsList;
        c.AddWalkToCommandList(BoardModel.CompassDirection.NORTH);

        //Act
        List<Func<bool>> result = c.CommandsList;

        //Assert
        CollectionAssert.AreEqual(expectedResult, result);
    }

    [Test]
    public void Test3_Adding_Jump_Command_To_CommandsList()
    {
        //Arrange
        int mapSize = 1;
        BoardModel model = new BoardModel(mapSize);

        CommandsListAndMethods c = new CommandsListAndMethods();
        c.SetModel(model);

        List<Func<bool>> expectedResult = c.CommandsList;
        c.AddJumpToCommandList(BoardModel.CompassDirection.EAST);

        //Act
        List<Func<bool>> result = c.CommandsList;

        //Assert
        CollectionAssert.AreEqual(expectedResult, result);
    }

    [Test]
    public void Test4_Invoke_Command()
    {
        //Arrange
        int mapSize = 5;     
        BoardModel model = new BoardModel(mapSize);
        model.playerX = 4;
        model.playerY = 4;
        model.map[2, 4] = BoardModel.SquareType.EMPTY_H0;

        Debug.Log(model.map[2, 4]);
        CommandsListAndMethods c = new CommandsListAndMethods();
        c.SetModel(model);
  
        BoardModel.SquareType expectedResult = BoardModel.SquareType.EMPTY_H0;
        Debug.Log(model.playerX);
        Debug.Log(model.playerY);

      
                Debug.Log(model.map[0, 4]);
                Debug.Log(model.map[1, 4]);
                Debug.Log(model.map[2, 4]);
                Debug.Log(model.map[3, 4]);
                Debug.Log(model.map[4, 4]);
        
    
        c.ClearCommandsList();
        c.AddWalkToCommandList(BoardModel.CompassDirection.NORTH);
        c.AddWalkToCommandList(BoardModel.CompassDirection.NORTH);
        //c.ShowCommandsListInConsole();
        c.InvokeCommands();
        c.ClearCommandsList();
        c.ShowCommandsListInConsole();
        //  c.ShowCommandsListInConsole();

        Debug.Log(model.map[2, 4]);
        Debug.Log(model.currentPlayerSquareType);

        Debug.Log(model.playerX);
        Debug.Log(model.playerY);
     


        //Act
        BoardModel.SquareType result = model.currentPlayerSquareType;
        //Assert
        Assert.AreEqual(expectedResult, result);
    }

    [Test]
    public void Test5_ClearList_Command()
    {
        //Arrange
        int mapSize = 5;
        BoardModel model = new BoardModel(mapSize);
        model.playerX = 5;
        model.playerY = 5;

        CommandsListAndMethods c = new CommandsListAndMethods();
        c.SetModel(model);

        List<Func<bool>> expectedResult = null;
        c.AddJumpToCommandList(BoardModel.CompassDirection.EAST);
        c.ClearCommandsList();

        //Act
        List<Func<bool>> result = c.CommandsList;

        //Assert
        CollectionAssert.AreEqual(expectedResult, result);
    }
*/
/*
    [Test]
    public void Test3_Invoke_Action_Command()
    {
        //Arrange
        int mapSize = 10;
        LevelModel m = new LevelModel(mapSize);

        int playPositionX = 5;
        int playPositionY = 5;

        m.playerX = playPositionX;
        m.playerY = playPositionY;

        LevelModel.SquareType expectedResult = LevelModel.SquareType.TARGET_H0_LIT;
/*
        m.AddActionToCommandsList();
        m.InvokeCommands();
        m.ClearCommandsList();
        
        //Act
        LevelModel.SquareType result = m.currentPlayerSquareType;
    
        //Assert
        Assert.AreEqual(expectedResult, result);
        */
}


    
