using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeAttackState : State
{

    public ChaseState ChaseState;
    public DangerZoneCheck DangerZoneCheck;
    public bool Indanger;
    public bool inRange;


    public override State RunCurrentState()
    {
        if (inRange)
        {
            return this;

        }
        else if (Indanger)
        {
            return DangerZoneCheck;
        }
        else
        {
            return ChaseState;
        }
        
    }
}
