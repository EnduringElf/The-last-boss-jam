using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseState : State
{
    public DangerZoneCheck DangerZoneMoveState;
    public MeleeAttackState MeleeAttackState;
    public RangedAttackState RangedAttackState;

    bool InDanger;
    bool IsMelee;
    bool isRanged;

    public override State RunCurrentState()
    {
        if (InDanger)
        {
            return DangerZoneMoveState;
        }
        else if( IsMelee)
        {
            return MeleeAttackState;

        }else if (isRanged)
        {
            return RangedAttackState;
        }
        else
        {
            return this;
        }


        

    }
}
