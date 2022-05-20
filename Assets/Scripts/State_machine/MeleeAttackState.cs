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
            //attack logic or call attack script 
            return this;

        }
        else if (Indanger)
        {
            return DangerZoneCheck;
        }
        else if(!inRange)
        {
            return ChaseState;
        }
        else
        {
            Debug.Log("no sTATE TO CAHNGE TO");
            return null;
        }
        
    }
}
