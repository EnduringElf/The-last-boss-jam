using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : State
{
    public ChaseState ChaseState;
    public bool BossFound;
    public override State RunCurrentState()
    {
        if (BossFound)
        {
            return ChaseState;
        }
        else
        {
            //find boss target set "target" transfrom to boss transform
            //change animation to walking 
            //
            return this;
        }

    }
}
