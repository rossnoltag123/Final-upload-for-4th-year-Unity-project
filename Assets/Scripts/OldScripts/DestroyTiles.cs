using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTiles : MonoBehaviour {

    private GameObject findTileClones;
  
    void Start ()
    {

    }
 
   public void DestTiles()
    {
        findTileClones = GameObject.Find("TileClones");
        Destroy(findTileClones);
    }

    void Update ()
    {
	
	}
}
