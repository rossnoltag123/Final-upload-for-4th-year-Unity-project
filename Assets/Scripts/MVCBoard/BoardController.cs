using UnityEngine;
using System.Collections;
using System;

public class BoardController{

    public BoardModel model;

    public void SetModel(BoardModel model){
        this.model = model;
    }

    //UI button connections to model
    public void LightUpSquare(){
          model.LightSquare();
    }
    
    public void Walk(BoardModel.CompassDirection direction){
         model.PlayerWalk(direction);
    }
  
    public void Jump(BoardModel.CompassDirection direction){
        model.PlayerJump(direction);
    }
}
