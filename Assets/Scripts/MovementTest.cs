using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTest : MonoBehaviour
{

    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    Vector2 movement;

    
    private Animator Animator;

    public bool canwalk;


    private void Start()
    {
        Animator = this.gameObject.GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        


        //movement stuff
        {
            if(canwalk)
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");

            if (Input.GetAxisRaw("Horizontal") == -1)
            {
                Animator.SetBool("Iswalking", true);
                this.transform.rotation = new Quaternion(0, 180, 0, 0);

            }
            if (Input.GetAxisRaw("Horizontal") == 1)
            {
                Animator.SetBool("Iswalking", true);
                this.transform.rotation = new Quaternion(0, 0, 0, 0);
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
