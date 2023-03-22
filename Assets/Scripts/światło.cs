using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class światło : MonoBehaviour
{
    GameObject lamp;
    void Start()
    {
        
        
        lamp = GameObject.Find("Spotlight");
        lamp.GetComponent<Light>().enabled = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "FPSController")
        {
            lamp.GetComponent<Light>().enabled = true;
        }

    }
}
//GameObject c = GameObject.Find("Spotlight");
// c.GetComponent<Light>().enabled = false;