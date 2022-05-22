using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseState : State
{
    [Header("State Machine")]
    public DangerZoneCheck DangerZoneMoveState;
    public MeleeAttackState MeleeAttackState;
    public RangedAttackState RangedAttackState;

    [Space(10)]
    public bool InDanger;
    public bool IsMelee;
    public bool isRanged;

    [Space(10)] // 10 pixels of spacing here.
    public bool InRange;
    public rangeSetter RangeSetter;
    
    [Header("Logic variables")]
    public GameObject Boss;
    public GameObject Target;
    public NPCAnimationController NPCAnimationController;
    public int Range;

    public override State RunCurrentState()
    {

        InRange = RangeSetter.InRange;


        if (InDanger)
        {
            return DangerZoneMoveState;
        }
        else if( IsMelee && InRange)
        {
            NPCAnimationController.isWalking = false;
            return MeleeAttackState;

        }else if (isRanged && InRange)
        {
            NPCAnimationController.isWalking = false;
            return RangedAttackState;
        }
        else
        {
            NPCAnimationController.isWalking = true;
            if(Target.transform.position != Boss.transform.position) { Target.transform.position = new Vector3(Boss.transform.position.x-Range, Boss.transform.position.y-Range, 0); }
            return this;
        }


        

    }
}
