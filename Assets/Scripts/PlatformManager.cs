using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlatformManager : MonoBehaviour
{
    GameObject fps, over;
    bool fpsonbridge;
    bool a = true;
    bool direction;
    float speed = 0.1f;
    // Use this for initialization
    void Start()
    {
        fps = GameObject.Find("FPSController");
        over = GameObject.Find("Over");
        over.GetComponent<Canvas>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < 80 || transform.position.z > 114)
        {
            direction = !direction;
        }

        if (direction)
        {
            transform.Translate(0, 0, speed, Space.World);
            if (fpsonbridge)
            { fps.transform.Translate(0, 0, speed, Space.World); }
        }
        else if (!direction)
        {
            transform.Translate(0, 0, -speed, Space.World);
            if (fpsonbridge)
            {
                { fps.transform.Translate(0, 0, -speed, Space.World); }
            }
        }
        if (fps.transform.position.y < 50)
        {
            over.GetComponent<Canvas>().enabled = true;
            StartCoroutine(MakeTimeout());
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
        if (other.gameObject.name == "FPSController")
        {
            Debug.Log("true");
            fpsonbridge = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("OnTriggerExit");
        if (other.gameObject.name == "FPSController")
        {
            Debug.Log("false");
            fpsonbridge = false;
        }
    }
    public IEnumerator MakeTimeout()
    {
        yield return new WaitForSeconds(2); // to o ma się wykonać po 2 sekundach
        SceneManager.LoadScene("2", LoadSceneMode.Single);
        over.GetComponent<Canvas>().enabled = false;
    }
}
