using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttackscontrols : MonoBehaviour
{
    public int comboCounter;
    public float ComboTimeMax;
    public float ComboTimeCurrent;

    public bool defualt;

    public bool inAttack;

    public bool CanAttack;

    public bool comboFailed;

    public GameObject target;

    private Animator Animator;

    private MovementTest MovementTest;

    public TargetFinderBoss TargetFinderBoss;

    public NpcDamageMech debugtarget;

    public float fallbacktimer;
    public float FallbackMax;



    

    // Start is called before the first frame update
    void Start()
    {
        Animator = this.gameObject.GetComponent<Animator>();
        MovementTest = this.gameObject.GetComponent<MovementTest>();
        

    }

    // Update is called once per frame
    void Update()
    {
        target = TargetFinderBoss.target;

        if (defualt)
        {
            comboCounter = 0;
            ComboTimeCurrent = ComboTimeMax;
            inAttack = false;
            CanAttack = true;
            comboFailed = false;
            EndCombo1();
            EndCombo2();
            MovementTest.canwalk = true;
            fallbacktimer = FallbackMax;
            defualt = false;
        }
        
        if (!inAttack)
        {
            if (CanAttack)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    Debug.Log("mousePressed");
                    CanAttack = false;
                    inAttack = true;
                    if (comboCounter == 0)
                    {
                        Animator.SetBool("bonk 1", true);
                        //first aniamtion
                        
                    }
                    if(comboCounter == 1 && comboFailed == false)
                    {
                        Animator.SetBool("bonk 2", true);

                    }
                    if(comboCounter == 2 && comboFailed == false)
                    {
                        Animator.SetBool("bonk 3", true);
                        defualt = true;
                    }

                
                    ComboTimeCurrent = ComboTimeMax;

                }
                fallbacktimer = FallbackMax;
            }

            if (ComboTimeCurrent >= 0)
            {
                ComboTimeCurrent -= Time.deltaTime;
                Animator.SetBool("combofailed", false);
            }
            else
            {
                //Debug.Log("failed combo");
                comboFailed = true;
                comboCounter = 0;
                Animator.SetBool("combofailed", true);
                CanAttack = true;
                inAttack = false;
                MovementTest.canwalk = true;
            }

        }
        else
        {
            if(fallbacktimer >= 0)
            {
                fallbacktimer -= Time.deltaTime;
            }
            else
            {
                defualt = true;
                fallbacktimer = FallbackMax;
                
            }
            
        }

    }

    

    public void AttackEnded()
    {
        CanAttack = true;
        inAttack = false;
        MovementTest.canwalk = true;
        Debug.Log("AttackEnded");
        Animator.SetBool("IsIdle", true);
        comboCounter++;
    }


    public void EndCombo1()
    {
        Animator.SetBool("bonk 1", false);
    }

    public void EndCombo2()
    {
        Animator.SetBool("bonk 2", false);
    }

    public void EndCombo3()
    {
        Animator.SetBool("bonk 3", false);
    }
    public void AttackTarget()
    {
        //Debug.Log("overlord attacked");
        if (target != null)
        {
            //Debug.Log("attack landed on target");
            debugtarget = target.GetComponentInChildren<NpcDamageMech>();
            target.GetComponentInChildren<NpcDamageMech>()
                .DamageThis(this.gameObject.GetComponent<BossDamageMech>().Damage);
            target.GetComponent<IdleState>().Hunt = false;
        }
        else
        {
            Debug.Log("attack failed check boss attacks controls for issues");
        }

    }


}
