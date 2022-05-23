using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    public AudioSource death;
    public bool playSound;
    void DeathSound()
    {
        death.Play();    
    }

    private void Update()
    {
        if (playSound)
        {
            death.Play();
            playSound = false;
        }
    }
}
