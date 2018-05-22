using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This is one of the very first scripts, generates the map per level. It has been abandoned.

public class MapGenerator : MonoBehaviour
{
    public Transform tilePrefab;
    public Vector2 mapSize;

    [Range(0, 1)]
    public float tileOutline;

    public float[] tilePointX;
    public Vector3[,] positionArray;
    public Vector3 tilePosition;

    void Start()
    {
        MapGeneratorMethod();
    }

    public void MapGeneratorMethod()
    {
  
        for (int x = 0; x < mapSize.x; x++)
        {
            for (int y = 0; y < mapSize.y; y++)
            {
    
                tilePosition = new Vector3(-mapSize.x / 2 + 0.5f + x, 0, -mapSize.y / 2 + 0.5f + y);   
                Transform newTile = (Transform)Instantiate(tilePrefab);
                newTile.transform.position = tilePosition;

                newTile.localScale = Vector3.one * (1 - tileOutline);
              
            }
        }    
    }
/*
    public void findTilePoint()
    {
        for (int x = 0; x < mapSize.x; x++)
        {
            for (int y = 0; y < mapSize.y; y++)
            {
                tilePosition = new Vector3(-mapSize.x / 2 + 0.5f + x, 0, -mapSize.y / 2 + 0.5f + y);
                positionArray[x,y] = tilePosition;           
            }
        }
       // Debug.Log(x);
    }
    */
}
