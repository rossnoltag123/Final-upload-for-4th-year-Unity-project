using UnityEngine.UI;
using UnityEngine;
using System.IO;
using System;
using System.Collections;

public class BoardView{

    public string levelCondition;
    public BoardModel model;

    public void SetModel(BoardModel model){    
        this.model = model;
    }

    public string UILevelComplete(){
        return levelCondition = "No more unlit squares\n level complete!!!";  
    }

    public string UIMoreSquresToLight(){
        return levelCondition = "Light the squares!";
    }

    public string UpdateBoardDisplay()
    {
        string output = "";
        string charForCurrentType;
        for (int r = 0; r < model.mapSize; r++)
        {
            for (int c = 0; c < model.mapSize; c++)
            {
                BoardModel.SquareType currentSquareType = model.map[r, c];
                charForCurrentType = model.GetTypeToChar(currentSquareType);
                if (r == model.playerX)
                {
                    if (c == model.playerY)
                    {
                        charForCurrentType = model.GetTypeToCharPlayer(model.currentPlayerSquareType);
                    }
                }
                output += charForCurrentType + " ";
            }
            output += "\n";
        }
        output += "\n";
        output += "     Player at (" + model.playerX + ", " + model.playerY + ")";
        output += "\n last acction success = " + model.GetLastActionSuccess();
        return output;
    }
}

