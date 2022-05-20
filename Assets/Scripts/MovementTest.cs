using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTest : MonoBehaviour
{

    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    Vector2 movement;

    public GameObject Model;
    public Animator Animator;


    private void Start()
    {
        Animator = GetComponentInChildren<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("mousePressed");
            //do attack animation
        }


        //movement stuff
        {
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");

            if (Input.GetAxisRaw("Horizontal") == -1)
            {
                Animator.SetBool("Iswalking", true);
                Model.transform.rotation = new Quaternion(0, 180, 0, 0);

            }
            if (Input.GetAxisRaw("Horizontal") == 1)
            {
                Animator.SetBool("Iswalking", true);
                Model.transform.rotation = new Quaternion(0, 0, 0, 0);
            }
            if (Input.GetAxisRaw("Horizontal") == 0)
            {
                Animator.SetBool("Iswalking", false);
            }
            if(Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1)
            {
                Animator.SetBool("Iswalking", true);
            }
            
        }
        
    }

    void FixedUpdate()
    {

        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);


    }
}
