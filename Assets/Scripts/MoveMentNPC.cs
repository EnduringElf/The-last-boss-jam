using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMentNPC : MonoBehaviour
{
    [SerializeField]
    [Header(" Player Speed")]
    public float Speed;
    
    [Header("targat position")]
    public GameObject TargetObject;
    private Vector2 Target;

    private Vector2 Postition;

    public float targetD;

    [Header("Moveable directions")]
    public bool newMove;

    public bool moveLeft;
    public bool moveRight;
    public bool moveUp;
    public bool moveDown;
    
    private enum move
    {
        left,
        right,
        up,
        down,
    }

    // Start is called before the first frame update
    void Start()
    {
        Postition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Target = TargetObject.transform.position;
        transform.position = 
            Vector2.MoveTowards
            (transform.position, Target, Time.deltaTime * Speed);

        if (newMove == true)
        {
            if (moveUp == true)
            {
                Move(move.up);

            }
            else if (moveDown == true)
            {
                Move(move.down);
            }
            else if (moveLeft == true)
            {
                Move(move.left);
            }
            else if (moveRight == true)
            {
                Move(move.right);
            }
        }
        
    }

    private void FixedUpdate()
    {
        
    }

    private void Move(move direction)
    {
        switch (direction)
        {
            case move.left:
                TargetObject.transform.position
                    -= new Vector3(targetD, 0);
                break;
            case move.right:
                TargetObject.transform.position
                    += new Vector3(targetD, 0);
                break;
            case move.down:
                TargetObject.transform.position
                   -= new Vector3(0, targetD);
                break;
            case move.up:
                TargetObject.transform.position
                    += new Vector3(0, targetD);
                break;

        }

        newMove = false;
    }
}
