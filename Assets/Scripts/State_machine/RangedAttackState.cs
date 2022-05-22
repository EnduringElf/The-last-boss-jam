using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedAttackState : State
{
    [Header("States")]
    public ChaseState ChaseState;
    public DangerZoneCheck DangerZoneCheck;
    [Header("Booleans")]
    public bool Indanger;
    public bool inRange;
    [Header("Objects")]
    public NPCAnimationController NPCAnimationController;
    public MoveMentNPC MoveMentNPC;
    public rangeSetter rangeSetter;


    public override State RunCurrentState()
    {
        inRange = rangeSetter.InRange;

        if (inRange)
        {
            //do projectile spawn
            MoveMentNPC.Canwalk = false;
            return this;

        }else if (Indanger)
        {
            return DangerZoneCheck;

        }else if (!inRange)
        {
            MoveMentNPC.Canwalk = true;
            return ChaseState;
        }
        else
        {
            Debug.Log("no state to change to");
            return null;
        }
        

    }
}
