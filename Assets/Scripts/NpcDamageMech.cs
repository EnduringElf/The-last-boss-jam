using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcDamageMech : DamageMechanismMaster
{
    [Header("Unit stats")]

    public bool HitRange;

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

        Debug.Log("in range of boss");
        //change state into attack state

    }
}
