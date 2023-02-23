using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayObjectAudio : MonoBehaviour
{

    //public AudioClip clip;
    

    Ray ray;

    public InputActionProperty selectInteraction;

    AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playAudioOnRayHit();
    }


    void playAudioOnRayHit()
    {

        float triggerDown = selectInteraction.action.ReadValue<float>();
        ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if(triggerDown == 1)
        {
            if (Physics.Raycast(ray, out hit)) //wenn ein objekt getroffen wird
            {
                source = hit.collider.gameObject.GetComponent<AudioSource>();

                if (source.isPlaying == false)
                {
                    Debug.Log("Getroffenes Objekt " + hit.collider.gameObject.name);                                 
                                 
                    source.PlayOneShot(source.clip);                                                        
                    
                }
            }

        }
        
    }


}
