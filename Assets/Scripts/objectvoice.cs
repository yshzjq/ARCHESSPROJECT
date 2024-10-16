using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectvoice : MonoBehaviour
{
    AudioSource audio;


    IEnumerator speakvoice()
    {
        yield return new WaitForSeconds(1f);
        audio.Play();
    }
    void Awake()
    {
        audio = GetComponent<AudioSource>();
    }

    void OnEnable()
    {
        StartCoroutine(speakvoice());
    }
}
