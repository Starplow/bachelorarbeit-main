using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioLoopScript : MonoBehaviour
{


    public AudioClip clip;
    AudioSource myAudioSource;
    bool shouldPlay;
    // Start is called before the first frame update
    void Start()
    {
        myAudioSource = GetComponent<AudioSource>();

        shouldPlay = true;
         


    }

    // Update is called once per frame
    void Update()
    {
        if (!myAudioSource.isPlaying)
        {
            if (shouldPlay)
            {
                
                myAudioSource.volume = 1.0f;
                myAudioSource.Play();
                shouldPlay = false;

                Debug.Log("Audiosource wird grad abgespielt");
            }

        }
        else
        {
            
            
            Debug.Log("Audiosource sollte wieder abgespielt werden");
            shouldPlay = true;

        }
    }
}
