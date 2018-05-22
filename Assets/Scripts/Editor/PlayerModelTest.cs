using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

public class PlayerModelTest
{
    [Test]
    public void NewPlayerNameTest()
    {
        //Arrange
        PlayerModel p = new PlayerModel();
        string expectedResult = "";

        //Act
        string result = p.GetName();
        
        //Assert    
        Assert.AreEqual(expectedResult, result);
    }

    [Test]
    public void NewPlayerScoreTest()
    {  
        //Arrange
        PlayerModel p = new PlayerModel();
        int expectedResult = 0;

        //Act
        int result = p.GetScore();

        //Assert    
        Assert.AreEqual(expectedResult, result);
    }

    [Test]
    public void NewPlayerMovesTest()
    {
        //Arrange
        PlayerModel p = new PlayerModel();
        int expectedResult = 0;

        //Act
        int result = p.GetMoves();

        //Assert    
        Assert.AreEqual(expectedResult, result);

    }
}

