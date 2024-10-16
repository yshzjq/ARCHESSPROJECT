using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScripts : MonoBehaviour
{
    public static SoundManagerScripts instance;

    public AudioSource sound;
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        sound = GetComponent<AudioSource>();
    }

    void PlayBtnSound()
    {
        sound.Play();
    }
}
