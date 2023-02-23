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

    
    private void OnTriggerEnter(Collider collider)
    {
        //objective1.SetActive(false); //wenn der spieler ins erste Objective laeuft, deaktiviert es sich

        //Debug.Log(" Collided mit" + collision.gameObject.name); 

        //Collision mit dem Spieler loest diese Funktion aus, welche nachschaut, welches Objective aktiv ist, dieses deaktiviert und das jeweils naechste aktiviert.

        if (objective1.activeSelf == true) 
        {

            Debug.Log("Objective 2 ist nicht aktiv, und wir aktiv gesetzt");
            objective1.SetActive(false);
            objective2.SetActive(true);
            var ping = collider.gameObject.GetComponentInChildren<playDistancePing>();
            if(ping != null)
            {
                ping.enabled = true;
            }
            //collider.gameObject.GetComponentInChildren<playDistancePing>().enabled = true;


        }
        else if (objective2.activeSelf == true)
        {

            objective2.SetActive(false);
            objective3.SetActive(true);


        }
        else if (objective3.activeSelf == true)
        {

            objective3.SetActive(false);
            objective4.SetActive(true);

        }
        else if (objective4.activeSelf == true)
        {

            objective4.SetActive(false);

        }




        //Debug.Log("kollision weewoo");
        

    }

      private void OnTriggerExit(Collider collision)
    {
        Debug.Log("FIndet nimmer statt");
    }
}
