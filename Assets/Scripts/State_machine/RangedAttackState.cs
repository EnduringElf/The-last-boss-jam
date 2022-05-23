using System;
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

    [Header("Projectile Var")]
    public GameObject projectileSpawn;
    public GameObject ProjectileObject;

    public NpcDamageMech NpcDamageMech;

    public bool CoolDown;
    public float cooldownTimer;
    public float cooldownMax;


    public override State RunCurrentState()
    {
        inRange = rangeSetter.InRange;
        if (CoolDown)
        {
            cooldownTimer -= Time.deltaTime;
        }
        else
        {
            CoolDown = false;
        }
        

        if (inRange)
        {
            CoolDown = true;
            NPCAnimationController.ISattacking = true;
            //do projectile spawn
            if (cooldownTimer < 0)
            {
                makeFireball();
                cooldownTimer = cooldownMax;
            }
            MoveMentNPC.Canwalk = false;
            return this;

        }else if (Indanger)
        {
            return DangerZoneCheck;

        }else if (!inRange)
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

    private void makeFireball()
    {
        Instantiate(ProjectileObject, projectileSpawn.transform.position, Quaternion.identity);
        Debug.Log("Made Fieball");
    }
}
