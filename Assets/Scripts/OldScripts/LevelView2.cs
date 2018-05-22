
//This has been abandoned for the moment, it was to display the 3d tiles etc

/*

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelView2 : MonoBehaviour {

    private LevelModel model;
    private LevelView view;
    private LevelController controller;

    private GameObject _newTile;
    private GameObject _manuvourable_tile;
    private GameObject _non_man_tile;

    public GameObject tilePrefab;
    public GameObject man_tile;
    public GameObject non_man_tile;


    public void SetView(){ 
        for (int x = 0; x < model.map.GetLength(0); x++){
            for (int y = 0; y < model.map.GetLength(1); y++)
            {    
                // if (model.mapSize[x, y] == 0){CreateTile(x, y);}

            }
        }
    }

    public void CreateTile(int x, int y)
    {
        _newTile = (GameObject)Instantiate(tilePrefab) as GameObject;
        _manuvourable_tile = (GameObject)Instantiate(man_tile) as GameObject;
        _non_man_tile = (GameObject)Instantiate(non_man_tile) as GameObject;
        Vector3 tilePosition = new Vector3(x + 0.5f, 0.0f, y + 0.5f);


    }
}
*/