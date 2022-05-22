using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeAttackState : State
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

    public override State RunCurrentState()
    {
        if (inRange)
        {
            MoveMentNPC.Canwalk = false;
            NPCAnimationController.ISattacking = true;
            //attack logic and animation script
            return this;
        }
        else if (Indanger)
        {
            return DangerZoneCheck;
        }
        else if(!inRange)
        {
            NPCAnimationController.ISattacking = false;
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
