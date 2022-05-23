using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class life : MonoBehaviour
{
    public float LifeDuration;

    // Update is called once per frame
    void Update()
    {
        if (LifeDuration < 0)
        {
            
            Debug.Log("destroyed this fireball ran out of life");
            Destroy(this.gameObject);
        }
        else
        {
            LifeDuration -=Time.deltaTime;
        }
    }


}
