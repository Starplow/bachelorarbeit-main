using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playDistanceAudio : MonoBehaviour
{


    Ray ray;
    public AudioClip clip;
    private AudioSource source;
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


        Debug.Log("wird ausgefuehrt");

        Debug.Log(transform.position + "  POSITIONSDATEN  " + transform.forward);


        if (Physics.Raycast(ray, out hit ))
        {
            Debug.Log(hit.collider.gameObject.name + " was hit!");
            Debug.Log(hit.distance);
            source.PlayOneShot(clip);
            

        }
    }
    
       
        


}
