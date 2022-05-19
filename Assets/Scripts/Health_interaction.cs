using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health_interaction : MonoBehaviour
{
    [Header("Boss object with Hp value")]
    public BossDamageMech Boss;

    [Header("healthBar UI")]
    public GameObject healthBar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.GetComponent<Slider>().value = Boss.HP;
    }
}
