using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCAnimationController : MonoBehaviour
{
    [Header("Transforms ")]

    public GameObject Target;
    public GameObject Model;
    public GameObject ModelAnim;

    private Transform targetTransform;

    private Transform ModelTransform;

    [Header("animation")]
    public Animator Animator;




    // Start is called before the first frame update
    void Start()
    {
        Animator = ModelAnim.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Target.transform == null)
        {
            Debug.Log("traget transform is null");
        }
        else
        {
            targetTransform = Target.transform;
        }
        if(Model.transform == null)
        {
            Debug.Log("model transform is null");
        }
        else
        {
            ModelTransform = Model.transform;
        }

        

        if(targetTransform.position.x == ModelTransform.position.x)
        {
            Animator.SetBool("ISwalking", false);
        }
        //other animation controlls
        else
        {
            if (targetTransform.position.x > ModelTransform.position.x)
            {
                Animator.SetBool("ISwalking", true);
                //do animation to right
                Model.transform.rotation = new Quaternion(0, 0, 0, 0);
                //Debug.Log("walking right");
            }

            if (targetTransform.position.x < ModelTransform.position.x)
            {
                Animator.SetBool("ISwalking", true);
                Model.transform.rotation = new Quaternion(0, 180, 0, 0);
            }

            if (targetTransform.position.y < ModelTransform.position.y)
            {
                Animator.SetBool("ISwalking", true);
            }

            if (targetTransform.position.y > ModelTransform.position.y)
            {
                Animator.SetBool("ISwalking", true);
            }
        }

        
        




    }
}
