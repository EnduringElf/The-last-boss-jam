using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowards : MonoBehaviour
{

    public GameObject Target;

    public Vector2 target_position;

    public float projectile_speed;

    public Vector2 Postition;

    private void Start()
    {
        Postition = this.transform.position;
    }

    private void Update()
    {
        target_position = Target.GetComponent<TargetFinderBoss>().target.transform.position;
        transform.position = Vector2.MoveTowards
                (transform.position, target_position, Time.deltaTime *projectile_speed );
    }

    
}
