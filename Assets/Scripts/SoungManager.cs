using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoungManager : MonoBehaviour
{
    private GameObject backMusic;
    private AudioClip[] shortSounds;
    void Start()
    {
        backMusic = GameObject.Find("Musiktlo");
        shortSounds = Resources.LoadAll<AudioClip>("Sounds");
       // Debug.Log(shortSounds.Length);
    }
    public void PlayBgMusic(bool audioOn)
    {
        if (audioOn)
        {
            backMusic.GetComponent<AudioSource>().Play();
        }
        else
        {
            backMusic.GetComponent<AudioSource>().Stop();
        }
    }
    public void PlayRandomSound(int rand)
    {
        Debug.Log(shortSounds.Length);
        GetComponent<AudioSource>().PlayOneShot(shortSounds[rand]);
    }
    public void OnBgVolumeChanged(float value)
    {
        AudioListener.volume = value;
    }
}