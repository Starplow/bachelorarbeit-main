using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectivesFound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    private void OnCollisionEnter(Collision collision)
    {

        Debug.Log("Eine Kollision hat stattgefunden");


    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log(" Findet immernoch statt");

    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("FIndet nimmer statt");
    }
}
