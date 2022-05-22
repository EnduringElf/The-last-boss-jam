using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rangeSetter : MonoBehaviour
{

    public bool InRange;

    public GameObject target;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "boss")
        {
            Debug.Log(this.GetComponentInParent<NPCAnimationController>().gameObject.name + " is in range of boss");
            InRange = true;
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
            Debug.Log(this.GetComponentInParent<NPCAnimationController>().gameObject.name + " is out of range of boss");
            InRange = false;
            target = null;
        }
        
    }
}
