using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlaySpatialAudio : MonoBehaviour
{


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


        ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit)) //wenn ein objekt getroffen wird
        {
            if (source.isPlaying == false)
            {
                source = hit.collider.gameObject.GetComponent<AudioSource>();
                source.Play();

            }
        }
    }


}
