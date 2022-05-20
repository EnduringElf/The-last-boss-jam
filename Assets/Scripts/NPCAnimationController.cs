using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCAnimationController : MonoBehaviour
{
    [Header("Transforms ")]

    public GameObject Target;
    public GameObject Model;

    private Transform targetTransform;

    private Transform ModelTransform;




    // Start is called before the first frame update
    void Start()
    {

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
        if(ModelTransform == null)
        {
            Debug.Log("model transform is null");
        }
        else
        {
            ModelTransform = ModelTransform.transform;
        }
        
        

        //if (targetTransform.position.x > ModelTransform.position.x)
        //{
        //    //do animation to right

        //    Debug.Log("is walking to boss");
        //}



    }
}
