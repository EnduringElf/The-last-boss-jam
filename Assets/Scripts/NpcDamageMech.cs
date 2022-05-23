using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcDamageMech : DamageMechanismMaster
{
    [Header("Unit stats")]

    
    
    public bool canAttack;

    public GameObject target;

    public rangeSetter rangeSetter;

    public GameObject ParentObject;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(HP <= 0)
        {
            Animator.SetBool("isDead", true);
            //play death anim
            Debug.Log("kill unit");
            
        }

        if (canAttack)
        {
            target = rangeSetter.target;
            if (target != null)
            {
                //Debug.Log("has attacked");
                target.GetComponent<BossDamageMech>().DamageThis(Damage * Time.deltaTime);
            }

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

    private void destroy()
    {
        Destroy(ParentObject);
    }

    private void Killunit()
    {
        Animator.SetBool("isDead", true);
    }

}
