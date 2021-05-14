using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    private AudioSource audio_source;
    public AudioClip exit_sound;

    void Start()
    {
        audio_source = GetComponent<AudioSource>();
        audio_source.clip = exit_sound;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            audio_source.Play();
        }
    }
}
