using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeValueChange : MonoBehaviour
{
    //Reference to Audio Source component
    private AudioSource audioSrc;

    // Music volume variable that will be modified by dragging slider knob
    private float musicVolume = 1f;

    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    void Update()
    {
        audioSrc.volume = musicVolume;
    }

    // Method that is called by slider game object
    public void SetVolume(float vol)
    {
        musicVolume = vol;
    }
}
