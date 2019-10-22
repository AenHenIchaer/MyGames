using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventMusicCube : MonoBehaviour
{
    public AudioClip eventClip;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

        }
        AudioManager.Manager.eventMusic.clip = eventClip;
        AudioManager.Manager.StartCoroutine("PlayEvenMusic");
    }
}
