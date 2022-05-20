using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerZoneCheck : State
{
    public ChaseState ChaseState;
    public DodgeState DodgeState;
    public bool inDanger;

    public override State RunCurrentState()
    {

        if (inDanger)
        {
            return DodgeState;
        }
        else if (!inDanger)
        {
            return ChaseState;
        }
        else
        {
            return this;
        }


    }
}
