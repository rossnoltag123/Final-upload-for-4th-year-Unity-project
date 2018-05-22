using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputControllerDelegate{

    public delegate void GeneralEventHandler();
    public event GeneralEventHandler WalkDirection;
    public event GeneralEventHandler JumpDirection;
    public event GeneralEventHandler DoAction;


    public void InputWalk()
    {
        if(WalkDirection != null)
        {
            WalkDirection();
        }
    }

    public void InputJump()
    {
        if (JumpDirection != null)
        {
            JumpDirection();
        }
    }

    public void InputAction()
    {
        if (DoAction != null)
        {
            DoAction();
        }
    }
}
