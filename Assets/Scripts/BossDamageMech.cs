using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossDamageMech : DamageMechanismMaster
{
    [Header("OL stats")]

    public float AOE;
    public float Speed;
    public float Cooldown;
    public float Size;

    public GameObject ParentObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (HP <= 0)
        {
            //play death anim

        }
    }

    private void destroy()
    {
        Destroy(ParentObject);
    }
}
