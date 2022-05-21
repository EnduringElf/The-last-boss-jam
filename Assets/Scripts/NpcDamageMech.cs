using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcDamageMech : DamageMechanismMaster
{
    [Header("Unit stats")]

    public bool HitRange;

    public ChaseState chaseState;
    public MeleeAttackState MeleeAttackState;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "boss")
        {
            Debug.Log("out of range of boss");
            chaseState.InRange = false;
            MeleeAttackState.inRange = false;
            //change state into attack state
        }
    }
}
