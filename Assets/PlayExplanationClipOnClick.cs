using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayExplanationClipOnClick : MonoBehaviour
{

    public AudioClip clipFront;
    public AudioClip clipRight;
    public AudioClip clipLeft;

    Ray ray;

    public InputActionProperty selectInteraction;

    AudioSource source;

    public TutorialWasPlayed tutorialObject;
    public GameObject rightWall;
    public GameObject leftWall;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        playAudioOnRayHit();
    }

    public IEnumerator WaitForSound(AudioClip sound)
    {


        yield return new WaitUntil(() => source.isPlaying == false);
        tutorialObject.gameObject.SetActive(false);


        if (!rightWall.activeSelf)
        {
            rightWall.SetActive(true);
        }
        else if(!leftWall.activeSelf)
        {
            leftWall.SetActive(true);
        }
        /*else if (leftWall.activeSelf)
        {

            leftWall.SetActive(false);

        }*/
        StopCoroutine(WaitForSound(sound));

    }
    void playAudioOnRayHit()
    {

        float triggerDown = selectInteraction.action.ReadValue<float>();
        ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if (triggerDown == 1)
        {
            if (Physics.Raycast(ray, out hit)) //wenn ein objekt getroffen wird
            {
                source = hit.collider.gameObject.GetComponent<AudioSource>();

                if (source.isPlaying == false)
                {
                    Debug.Log("Getroffenes Objekt " + hit.collider.gameObject.name);

                    if (hit.collider.gameObject.name == "FrontWall")
                    {
                        tutorialObject = hit.collider.gameObject.GetComponent<TutorialWasPlayed>();

                        source.PlayOneShot(clipFront);

                        tutorialObject.wasPlayed = true;

                        StartCoroutine(WaitForSound(clipFront));

                        /*if (!source.isPlaying)
                        {
                            tutorialObject.gameObject.SetActive(false);
                            rightWall.SetActive(true);
                        }*/
                    }
                    if (hit.collider.gameObject.name == "RightWall")
                    {

                        tutorialObject = hit.collider.gameObject.GetComponent<TutorialWasPlayed>();

                        source.PlayOneShot(clipRight);

                        tutorialObject.wasPlayed = true;

                        /*if (!source.isPlaying) 
                        { 
                            tutorialObject.gameObject.SetActive(false);
                            leftWall.SetActive(true);
                        }*/

                        StartCoroutine(WaitForSound(clipRight));

                    }
                    if (hit.collider.gameObject.name == "LeftWall")
                    {

                        tutorialObject = hit.collider.gameObject.GetComponent<TutorialWasPlayed>();

                        source.PlayOneShot(clipLeft);

                        /*if (!source.isPlaying)
                        {
                            tutorialObject.wasPlayed = true;
                            tutorialObject.gameObject.SetActive(false);
                        }*/

                        StartCoroutine(WaitForSound(clipLeft));

                    }






                }
            }

        }

    }


}
