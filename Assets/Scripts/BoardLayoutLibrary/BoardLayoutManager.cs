using UnityEngine;
using UnityEngine.SceneManagement;

public class BoardLayoutManager: MonoBehaviour{

    public int mapSizeLib { get; set; }
    public int playerXLib { get; set; }
    public int playerYLib { get; set; }

    public BoardModel.SquareType[,] mapLib;
    public BoardLibrary boardLibrary;
    public static BoardLayoutManager boardLayoutManager;

    void Start(){
        boardLibrary = new BoardLibrary();
        DontDestroyOnLoad(gameObject);
    }

    void Awake(){
        this.InstantiateBoardLayoutManager();
    }

    private void InstantiateBoardLayoutManager(){
        if (boardLayoutManager == null){
            boardLayoutManager = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (this != boardLayoutManager)
        { Destroy(this.gameObject); }
    }

    //Buttons on a screen to select which layout
    public void Level1Layout(){
        mapSizeLib = 4;
        playerXLib = 2;
        playerYLib = 2;
        mapLib = boardLibrary.Level1();
    }

    public void Level2Layout(){
        mapSizeLib = 6;
        playerXLib = 2;
        playerYLib = 2;
        mapLib = boardLibrary.Level2();
    }

    public void Level3Layout(){
        mapSizeLib = 10;
        playerXLib = 5;
        playerYLib = 5;
        mapLib = boardLibrary.Level3();
    }

    public void Level4Layout(){
        mapSizeLib = 10;
        playerXLib = 5;
        playerYLib = 5;
        mapLib = boardLibrary.Level4();
    }

    public void Level5Layout(){
        mapSizeLib = 10;
        playerXLib = 5;
        playerYLib = 5;
        mapLib = boardLibrary.Level5();
    }
    
}
