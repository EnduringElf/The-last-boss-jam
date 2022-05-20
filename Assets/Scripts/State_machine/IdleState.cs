using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : State
{
    public ChaseState ChaseState;
    public bool BossFound;
    public bool Hunt;

    private GameObject BossTransform;

    public override State RunCurrentState()
    {
        findBoss();

        if (BossFound)
        {
            if (Hunt) {
                ChaseState.Boss = BossTransform;
                return ChaseState;
            }
            else
            {
                return this;
            }
            
            
        }
        else
        {
            //find boss target set "target" transfrom to boss transform
            //change animation to walking 
            //
            return this;
        }

    }

    private void findBoss()
    {
        
        if(GameObject.Find("OverLord") != null)
        {
            BossTransform = GameObject.Find("OverLord");
        }
        

        BossFound = true;
    }
}
