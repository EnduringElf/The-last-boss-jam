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
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool DamageThis(int value)
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
        Debug.Log( this.gameObject.name +" has died");
    }

    public bool HealThis(int value)
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
