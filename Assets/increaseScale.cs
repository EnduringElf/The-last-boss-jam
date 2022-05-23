using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class increaseScale : MonoBehaviour
{
    public WaveSpawner WaveSpawner;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(WaveSpawner.waves[0].spawnInterval < 0.5)
        {

        }
        else
        {
            WaveSpawner.waves[0].spawnInterval -= 0.1f * Time.deltaTime;
        }
        
    }
}
