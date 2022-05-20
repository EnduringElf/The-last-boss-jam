using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DodgeState : State
{

    public ChaseState chaseState;

    public bool isSafe;

    public override State RunCurrentState()
    {
        if (isSafe)
        {
            return chaseState;
        }
        else
        {
            return this;

        }

    }
}
