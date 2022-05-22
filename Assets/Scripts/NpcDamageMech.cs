using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcDamageMech : DamageMechanismMaster
{
    [Header("Unit stats")]

    public bool HitRange;
    public ChaseState chaseState;
    public MeleeAttackState MeleeAttackState;
    public bool canAttack;

    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canAttack)
        {
            if (target != null)
            {
                Debug.Log("has attacked");
                target.GetComponent<BossDamageMech>().DamageThis(Damage * Time.deltaTime);
            }

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "boss")
        {
            Debug.Log("in range of boss");
            chaseState.InRange = true;
            MeleeAttackState.inRange = true;
            
            //change state into attack state
        }

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        target = collision.gameObject;
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "boss")
        {
            Debug.Log("out of range of boss");
            chaseState.InRange = false;
            MeleeAttackState.inRange = false;
            target = null;
            //change state into attack state
        }
    }

    private void CanAttacktrue()
    {
        canAttack = true;
    }

    private void CanAttackFalse()
    {
        canAttack = false;
    }

}
