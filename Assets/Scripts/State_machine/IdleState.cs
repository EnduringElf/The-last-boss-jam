using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : State
{
    public ChaseState ChaseState;
    bool BossFound;
    public override State RunCurrentState()
    {
        if (BossFound)
        {
            return ChaseState;
        }
        else
        {
            return this;
        }

    }
}
