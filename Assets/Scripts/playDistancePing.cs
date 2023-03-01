using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class playDistancePing : MonoBehaviour
{


    Ray ray;
    public AudioClip clip;
    private AudioSource source;
    public InputActionProperty selectInteraction;
    // Start is called before the first frame update
    void Start()
    {
        
        source = GetComponent<AudioSource>();

        //CheckForColliders();

    }

    // Update is called once per frame
    void Update()
    {
        
        CheckForColliders();

    }

    void CheckForColliders()
    {

        ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        // Debug.Log("wird ausgefuehrt");
        float triggerDown = selectInteraction.action.ReadValue<float>();
        // Debug.Log(transform.position + "  POSITIONSDATEN  " + transform.forward);
        // Debug.Log(triggerDown);
        if (triggerDown == 1){ // Wenn trigger down

            if (Physics.Raycast(ray, out hit)) //wenn objekt getroffen wird
            {
                //Debug.Log(hit.collider.gameObject.name + " was hit!");
                //Debug.Log("Distanz " + hit.distance);
                if (!source.isPlaying) // wenn grad kein clip gespielt wird, damit nicht gespammt wird
                {
                    float newPitch = 1 - ((hit.distance / 15) - 1); //Formel zum aendern des Pitches
                    //source.pitch =   / hit.distance;


                    if (newPitch < 0.3f) // clamp damit es nicht allzu langgezogen wird
                    {
                        source.pitch = 0.3f;
                    }
                    /*
                    else if (newPitch > 1.3f)
                    {
                        source.pitch = 1.3f;
                    }
                    else
                    {
                        source.pitch = newPitch;
                    }
                    */
                    source.pitch = newPitch;
                    Debug.Log("Pitch " + source.pitch);
                    source.PlayOneShot(clip);
                }
            }
        }
        
    }
    
}
