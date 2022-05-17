using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageMEchanism : MonoBehaviour
{
    [Header("Boss stats")]
    public float HP = 100;
    public float MaxHP = 100;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool DamageBoss(int value)
    {
        HP -= value;

        if(HP <= 0)
        {
            BossDeath();
        }
        return true;
    }

    private void BossDeath()
    {
        Debug.Log("boss has died");
    }

    public bool HealBoos(int value)
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
