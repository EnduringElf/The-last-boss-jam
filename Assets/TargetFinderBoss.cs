using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetFinderBoss : MonoBehaviour
{
    public GameObject target;

    public bool isFireBall;

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
        if (isFireBall)
        {
            if(collision.gameObject.tag == "boss")
            {
                target = collision.gameObject;
                //target.transform.position = collision.gameObject.transform.position;
            }
        }else if(collision.gameObject.tag == "Enenmy")
        {
            target = collision.gameObject;
        }
        
    }

    

}
