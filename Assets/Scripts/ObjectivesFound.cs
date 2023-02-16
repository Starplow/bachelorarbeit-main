using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectivesFound : MonoBehaviour
{

    public GameObject objective1;
    public GameObject objective2;
    public GameObject objective3;
    public GameObject objective4;




    // Update is called once per frame

    private void Update()
    {
        
        

    }


    private void OnTriggerEnter(Collider collision)
    {


        objective1.SetActive(false); //wenn der spieler ins erste Objective laeuft, deaktiviert es sich



        if(objective2.activeSelf == false)
        {


            objective2.SetActive(true);


        }



        if(objective3.activeSelf == false)
        {
            objective2.SetActive(false);
            objective3.SetActive(true);


        }




        if(objective4.activeSelf == false)
        {

            objective3.SetActive(false);
            objective4.SetActive(true);

        }

        if(objective4.activeSelf == true)
        {

            objective4.SetActive(false);

        }




        Debug.Log("kollision weewoo");
        

    }

      private void OnTriggerExit(Collider collision)
    {
        Debug.Log("FIndet nimmer statt");
    }
}
