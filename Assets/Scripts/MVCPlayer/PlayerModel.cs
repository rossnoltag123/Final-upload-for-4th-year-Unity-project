using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerModel
{
    /// <summary>
    /// instantiating variables
    /// </summary>
    private string name;

    /// <summary>
    ///instantiating variables
    /// </summary>
    private int score;
    /// <summary>
    /// instantiating variables
    /// </summary>
    private int moves;

    /// <summary>
    ///Default Constructor for class
    /// </summary>
    public PlayerModel()
        {
        name = "";
        score = 0;
        moves = 0; 
        }

    /// <summary>
    /// Constructor for class
    /// </summary>
    public PlayerModel(string name, int score, int moves)
        {
            this.name = name;
            this.score = score;
            this.moves = moves;   
        }
    /// <summary>
    /// Get method
    /// </summary>
    public string GetName()
        { return name; }

    /// <summary>
    ///Set method
    /// </summary>
    public void SetName(string name)
        { this.name = name; }

    /// <summary>
    /// Get method
    /// </summary>
    public int GetScore()
        { return score; }

    /// <summary>
    ///Set method
    /// </summary>
    public void SetScore(int score)
        { this.score = score; }

    /// <summary>
    /// Get method
    /// </summary>
    public int GetMoves()
        { return moves; }

    /// <summary>
    ///Set method
    /// </summary>
    public void SetMoves(int moves)
        { this.moves = moves; }


}

