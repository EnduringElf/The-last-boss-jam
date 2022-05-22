using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]


public class Wave
{
    public string waveName;
    public int noOfEnemies;

}
public class WaveSpawner : MonoBehaviour
{
    [SerializeField] Wave[] waves = new Wave[100];
    [SerializeField]    public GameObject normalKnight;
    [SerializeField]    public GameObject choomba;
    [SerializeField]    public GameObject wizardo;
    
        void Start()
        {
            
        Wave[] waves = new Wave[100];
        setWave();

        }

    void Update()
    {
        
    }

    public void setWave()
    {
        for (int i = 1; i < 100; i++)
        {
            waves[i-1].waveName = "Wave " + i;
            waves[i-1].noOfEnemies = 3*i;
            //waves[i-1].typeOfEnemies = 
        }
    }



}

