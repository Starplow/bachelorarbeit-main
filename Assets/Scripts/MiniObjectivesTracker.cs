using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniObjectivesTracker : MonoBehaviour
{

    GameObject firstObjective;
    public GameObject secondObjective;
    public GameObject thirdObjective;
    public GameObject fourthObjective;



    public Material glowGreen;
    


    public Material firstObjectiveDone;
    public Material secondObjectiveDone;
    public Material thirdObjectiveDone;
    public Material fourthObjectiveDone;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        firstObjective = GameObject.Find("Objective 1");
        Debug.Log("ANDERE FARBE " + firstObjective.GetComponent<Renderer>().material.ToString());
        Debug.Log("HIER DER FARBENNAME " + glowGreen);
        
        if(firstObjective.GetComponent<Renderer>().material == glowGreen)
        {

            Debug.Log("EIGENE FARBE "+ this.gameObject.GetComponent<Renderer>().material.name);
            this.gameObject.GetComponent<Renderer>().material = firstObjectiveDone;

        }
    }
}
