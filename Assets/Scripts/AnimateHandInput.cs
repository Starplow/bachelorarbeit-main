using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class AnimateHandInput : MonoBehaviour
{


    /*
    
    public Mesh grippingHand;
    public Mesh normalHand;
    public MeshFilter handForm;
    */
    public Animator handAnimator;
    public InputActionProperty pinchAnimationAction;
    public InputActionProperty gripAnimationAction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



        
        float triggerValue = pinchAnimationAction.action.ReadValue<float>();

        handAnimator.SetFloat("Trigger", triggerValue);

        float gripValue = gripAnimationAction.action.ReadValue<float>();
        handAnimator.SetFloat("Grip", gripValue);
        

        //Debug.Log(gripValue);

        /*
         *
        

        if(triggerValue >= 0.5)
        {

            handForm.mesh = grippingHand;

        }
        else
        {

            handForm.mesh = normalHand;

        }
        */



    }
}
