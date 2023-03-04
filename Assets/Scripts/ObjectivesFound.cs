using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectivesFound : MonoBehaviour
{

    public GameObject objective1;
    public GameObject objective2;
    public GameObject objective3;
    public GameObject objective4;


    public GameObject auftauchWand1;
    public GameObject auftauchWand2;
    public GameObject auftauchWand3;
    public GameObject verschwindeWand1;
    public GameObject verschwindeWand0;
    public GameObject verschwindeWoodWand1;


    public GameObject playerObject;

    public AudioClip firstObjectiveClip;
    public AudioClip secondObjectiveClip;
    public AudioClip thirdObjectiveClip;
    public AudioClip finishedClip;
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
            verschwindeWand0.SetActive(false);
            AudioSource playerAudio = playerObject.GetComponent<AudioSource>();

            playerAudio.PlayOneShot(firstObjectiveClip);

            //GameObject auftauchWand = GameObject.FindByName("AuftauchWall_1");
            auftauchWand1.SetActive(true);
            var ping = collider.gameObject.GetComponentInChildren<playDistancePing>();
            if(ping != null)
            {
                ping.enabled = true;
            }
            //collider.gameObject.GetComponentInChildren<playDistancePing>().enabled = true;


        }
        else if (objective2.activeSelf == true)
        {
            var ping = collider.gameObject.GetComponentInChildren<playDistancePing>();
            if (ping != null)
            {
                ping.enabled = false;
            }



            var objectPing = collider.gameObject.GetComponentInChildren<PlayObjectAudio>();
            if (objectPing != null)
            {
                objectPing.enabled = true;
            }

            objective2.SetActive(false);
            objective3.SetActive(true);
            AudioSource playerAudio = playerObject.GetComponent<AudioSource>();

            playerAudio.PlayOneShot(secondObjectiveClip);

            verschwindeWand1.SetActive(false);
            auftauchWand2.SetActive(true);

        }
        else if (objective3.activeSelf == true)
        {
            var ping = collider.gameObject.GetComponentInChildren<playDistancePing>();
            if (ping != null)
            {
                ping.enabled = true;
            }

            objective3.SetActive(false);
            objective4.SetActive(true);
            AudioSource playerAudio = playerObject.GetComponent<AudioSource>();

            playerAudio.PlayOneShot(thirdObjectiveClip);

            verschwindeWoodWand1.SetActive(false);
            auftauchWand3.SetActive(true);


        }
        else if (objective4.activeSelf == true)
        {

            objective4.SetActive(false);

            AudioSource playerAudio = playerObject.GetComponent<AudioSource>();

            playerAudio.PlayOneShot(finishedClip);

            // Hier wincondition einfuegen, wie sieht die aus? Gesprochener Text? 


        }




        
        

    }

      private void OnTriggerExit(Collider collision)
    {
        Debug.Log("Findet nicht mehr statt");
    }
}
