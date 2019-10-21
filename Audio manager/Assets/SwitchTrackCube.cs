using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchTrackCube : MonoBehaviour
{
    public AudioClip mainMusicClip;
    public AudioClip auxMusicClip;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AudioManager.Manager.mainMusic.clip = mainMusicClip;
            AudioManager.Manager.auxMusic.clip = auxMusicClip;
            AudioManager.Manager.mainMusic.Play();
            AudioManager.Manager.auxMusic.Play();
        }
    }
}
