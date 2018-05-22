using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardLibrary {

    public BoardModel.SquareType[,] Level1()
    {
        return new BoardModel.SquareType[,]
            {
            { BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD},
            { BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0,  BoardModel.SquareType.EDGE_OF_BOARD},
            { BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.TARGET_H0_UNLIT, BoardModel.SquareType.EMPTY_H0,  BoardModel.SquareType.EDGE_OF_BOARD},
            { BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD }
         };
    }

    public BoardModel.SquareType[,] Level2()
    {
        return new BoardModel.SquareType[,]
            {
            { BoardModel.SquareType.TARGET_H0_UNLIT,BoardModel.SquareType.TARGET_H0_UNLIT,BoardModel.SquareType.TARGET_H0_UNLIT,BoardModel.SquareType.TARGET_H0_UNLIT,BoardModel.SquareType.TARGET_H0_UNLIT,BoardModel.SquareType.TARGET_H0_UNLIT },
            { BoardModel.SquareType.TARGET_H0_UNLIT,BoardModel.SquareType.TARGET_H0_UNLIT,BoardModel.SquareType.TARGET_H0_UNLIT,BoardModel.SquareType.TARGET_H0_UNLIT,BoardModel.SquareType.TARGET_H0_UNLIT,BoardModel.SquareType.TARGET_H0_UNLIT },
            { BoardModel.SquareType.TARGET_H0_UNLIT,BoardModel.SquareType.TARGET_H0_UNLIT,BoardModel.SquareType.TARGET_H0_UNLIT,BoardModel.SquareType.TARGET_H0_UNLIT,BoardModel.SquareType.TARGET_H0_UNLIT,BoardModel.SquareType.TARGET_H0_UNLIT },
            { BoardModel.SquareType.TARGET_H0_UNLIT,BoardModel.SquareType.TARGET_H0_UNLIT,BoardModel.SquareType.TARGET_H0_UNLIT,BoardModel.SquareType.TARGET_H0_UNLIT,BoardModel.SquareType.TARGET_H0_UNLIT,BoardModel.SquareType.TARGET_H0_UNLIT },
            { BoardModel.SquareType.TARGET_H0_UNLIT,BoardModel.SquareType.TARGET_H0_UNLIT,BoardModel.SquareType.TARGET_H0_UNLIT,BoardModel.SquareType.TARGET_H0_UNLIT,BoardModel.SquareType.TARGET_H0_UNLIT,BoardModel.SquareType.TARGET_H0_UNLIT },
            { BoardModel.SquareType.TARGET_H0_UNLIT,BoardModel.SquareType.TARGET_H0_UNLIT,BoardModel.SquareType.TARGET_H0_UNLIT,BoardModel.SquareType.TARGET_H0_UNLIT,BoardModel.SquareType.TARGET_H0_UNLIT,BoardModel.SquareType.TARGET_H0_UNLIT }
        };
    }


    public BoardModel.SquareType[,] Level3(){
        return new BoardModel.SquareType[,]
            {
            { BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD,BoardModel.SquareType.EDGE_OF_BOARD},
            { BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0,BoardModel.SquareType.EDGE_OF_BOARD},
            { BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.TARGET_H2_UNLIT, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0,BoardModel.SquareType.TARGET_H0_UNLIT, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0,BoardModel.SquareType.EMPTY_H0,BoardModel.SquareType.EDGE_OF_BOARD},
            { BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EMPTY_H2, BoardModel.SquareType.IMPASSABLE_PIT, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0,BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EDGE_OF_BOARD},
            { BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EMPTY_H1, BoardModel.SquareType.EMPTY_H1, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EDGE_OF_BOARD},
            { BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.IMPASSABLE_VOLCANO, BoardModel.SquareType.EMPTY_H1, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EDGE_OF_BOARD},
            { BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EMPTY_H1, BoardModel.SquareType.EMPTY_H1, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EDGE_OF_BOARD},
            { BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EDGE_OF_BOARD},
            { BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EDGE_OF_BOARD},
            { BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD,BoardModel.SquareType.EDGE_OF_BOARD}
        };
    }

    public BoardModel.SquareType[,] Level4()
    {
        return new BoardModel.SquareType[,]
            {
            { BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD,BoardModel.SquareType.EDGE_OF_BOARD},
            { BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0,BoardModel.SquareType.EDGE_OF_BOARD},
            { BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.TARGET_H2_UNLIT, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0,BoardModel.SquareType.TARGET_H0_UNLIT, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.TARGET_H0_UNLIT, BoardModel.SquareType.EMPTY_H0,BoardModel.SquareType.EMPTY_H0,BoardModel.SquareType.EDGE_OF_BOARD},
            { BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EMPTY_H2, BoardModel.SquareType.IMPASSABLE_PIT, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0,BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EDGE_OF_BOARD},
            { BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EMPTY_H1, BoardModel.SquareType.EMPTY_H1, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EDGE_OF_BOARD},
            { BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.IMPASSABLE_VOLCANO, BoardModel.SquareType.EMPTY_H1, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EDGE_OF_BOARD},
            { BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EMPTY_H1, BoardModel.SquareType.EMPTY_H1, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EDGE_OF_BOARD},
            { BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.TARGET_H0_UNLIT, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EDGE_OF_BOARD},
            { BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.TARGET_H0_UNLIT, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EDGE_OF_BOARD},
            { BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD,BoardModel.SquareType.EDGE_OF_BOARD}
        };
    }

    public BoardModel.SquareType[,] Level5()
    {
        return new BoardModel.SquareType[,]
            {
            { BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD,BoardModel.SquareType.EDGE_OF_BOARD},
            { BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0,BoardModel.SquareType.EDGE_OF_BOARD},
            { BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.TARGET_H2_UNLIT, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0,BoardModel.SquareType.TARGET_H0_UNLIT, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.TARGET_H0_UNLIT,BoardModel.SquareType.EMPTY_H0,BoardModel.SquareType.EDGE_OF_BOARD},
            { BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EMPTY_H2, BoardModel.SquareType.IMPASSABLE_PIT, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0,BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EDGE_OF_BOARD},
            { BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EMPTY_H1, BoardModel.SquareType.EMPTY_H1, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EDGE_OF_BOARD},
            { BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.IMPASSABLE_VOLCANO, BoardModel.SquareType.EMPTY_H1, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EDGE_OF_BOARD},
            { BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EMPTY_H1, BoardModel.SquareType.EMPTY_H1, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.TARGET_H0_UNLIT, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EDGE_OF_BOARD},
            { BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EDGE_OF_BOARD},
            { BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EMPTY_H0, BoardModel.SquareType.EDGE_OF_BOARD},
            { BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD, BoardModel.SquareType.EDGE_OF_BOARD,BoardModel.SquareType.EDGE_OF_BOARD}
        };
    }
}
