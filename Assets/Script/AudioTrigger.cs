using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    public AudioClip Sound;
    public float volume;
    AudioSource audio;
    public bool alreadyPlayer = false;

    void Start()
    {
        audio = GetComponent<AudioSource>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!alreadyPlayer)
        {
            audio.PlayOneShot(Sound, volume);
            alreadyPlayer = true;
        }
    }
}
