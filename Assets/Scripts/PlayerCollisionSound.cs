using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionSound : MonoBehaviour
{

    public AudioClip clip;
    public AudioClip clipWood;
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

        Debug.Log("Collision sollte mit spieler passieren " + hit.gameObject.name);

        if (hit.gameObject.tag == "Wall") 
        {
            Debug.Log("Erkennt spieler");
            if (!source.isPlaying)
            {

                source.PlayOneShot(clip);
            }
            

        }
        if (hit.gameObject.tag == "WoodWall")
        {
            if (!source.isPlaying)
            {

                source.PlayOneShot(clipWood);

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
