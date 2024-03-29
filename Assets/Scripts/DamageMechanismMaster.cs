using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageMechanismMaster : MonoBehaviour
{
    [Header("Unit stats")]
    public float HP = 100;
    public float MaxHP = 100;

    public float Damage;

    public int Range;

    public Animator Animator;

    public MoveMentNPC MoveMentNPC;

    public bool npc;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool DamageThis(float value)
    {
        HP -= value;

        if(HP <= 0)
        {
            Death();
        }
        return true;
    }

    private void Death()
    {
        Animator.SetBool("isDead", true);
        Animator.SetBool("ISwalking", false);
        if (npc)
        {
            MoveMentNPC.Canwalk = false;
        }
        Debug.Log( this.gameObject.name +" has died");
        
    }

    public bool HealThis(float value)
    {
        if(HP != MaxHP && MaxHP - HP >= value)
        {
            HP += value;
            return true;
        }
        else
        {
            return false;
        }

        
    }
}
