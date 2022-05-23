using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTarget : MonoBehaviour
{
    public float Damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "boss")
        {
            collision.gameObject.GetComponent<BossDamageMech>().DamageThis(Damage);
        }
    }
}
