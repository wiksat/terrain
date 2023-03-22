using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPicker : MonoBehaviour
{
    SoungManager sounds;
    void Start()
    {
        sounds = GameObject.Find("Sounds").GetComponent<SoungManager>();
    }
    private void Update()
    {
        transform.Rotate(2, 0, 2);
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject);
        if (other.name == "FPSController")
        {
            sounds.PlayRandomSound(Random.Range(0, 50));
            Destroy(this.gameObject);
            GameObject.Find("Score").GetComponent<ScoreManager>().AddScore();
        }
    }
}
