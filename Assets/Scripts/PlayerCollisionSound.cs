using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionSound : MonoBehaviour
{

    public AudioClip clip;
    public AudioClip clipWood;



    public AudioClip firstObjectiveClip;
    public AudioClip secondObjectiveClip;
    public AudioClip thirdObjectiveClip;
    public AudioClip gameFinished;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnControllerColliderHit(UnityEngine.ControllerColliderHit hit)
    {
        AudioSource source = gameObject.GetComponent<AudioSource>();

        //Debug.Log("Collision sollte mit spieler passieren " + hit.gameObject.name);
        Debug.Log("Collision sollte mit spieler passieren " + hit.gameObject.tag);
        if (hit.gameObject.tag == "Wall") 
        {
            //Debug.Log("Erkennt spieler");
            if (!source.isPlaying)
            {
                Debug.Log("hat stein beruehrt");
                source.PlayOneShot(clip);
            }
            

        }
        if (hit.gameObject.tag == "WoodWall")
        {
            if (!source.isPlaying)
            {
                Debug.Log("hat holz beruehrt");
                source.PlayOneShot(clipWood);

            }

        }
        if(hit.gameObject.tag == "FirstObjective")
        {
            Debug.Log("Erstes Voiceover wird abgespielt");
            if (!source.isPlaying)
            {
                source.PlayOneShot(firstObjectiveClip);
                Debug.Log("Erstes Voiceover wird abgespielt in der if !sourceplaying");
            }
        }
        if (hit.gameObject.tag == "SecondObjective")
        {
            if (!source.isPlaying)
            {
                source.PlayOneShot(secondObjectiveClip);
            }
        }
        if (hit.gameObject.tag == "ThirdObjective")
        {
            if (!source.isPlaying)
            {
                source.PlayOneShot(thirdObjectiveClip);
            }
        }


        if (hit.gameObject.tag == "LastObjective")
        {

            if(!source.isPlaying)
            {
                source.PlayOneShot(gameFinished);
            }

        }


    }


}
