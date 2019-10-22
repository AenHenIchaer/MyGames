using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlayerAudio : MonoBehaviour
{
    public AudioClip splashSound;
    public AudioSource audioS;
    public AudioMixerSnapshot idleSnapshot;
    public AudioMixerSnapshot auxInSnapshot;
    public AudioClip[] grassSteps;
    public AudioClip[] woodsteps;
    public AudioClip[] hardsteps;
    
    public LayerMask enemyMask;
    bool enemyNear;

    private void Update()
    {
        RaycastHit[] hits = Physics.SphereCastAll(transform.position, 5f, transform.forward, 0f, enemyMask);
        if (hits.Length > 0)
        {
            enemyNear = true;
        }
        else
        {
            enemyNear = false;
        }
        if (!AudioManager.Manager.eventRunning)
        {


            if (enemyNear)
            {
                if (!AudioManager.Manager.auxIn)
                {
                    auxInSnapshot.TransitionTo(0.5f);
                    AudioManager.Manager.currentAudioMixerSnapshot = auxInSnapshot;
                    AudioManager.Manager.auxIn = true;
                }
                else
                {
                    if (AudioManager.Manager.currentAudioMixerSnapshot==AudioManager.Manager.eventSnap)
                    {
                        auxInSnapshot.TransitionTo(0.5f);
                        AudioManager.Manager.currentAudioMixerSnapshot = auxInSnapshot;
                        AudioManager.Manager.auxIn = true;
                    }
                }
            }
            else
            {
                if (AudioManager.Manager.auxIn)
                {
                    idleSnapshot.TransitionTo(0.5f);
                    AudioManager.Manager.currentAudioMixerSnapshot = idleSnapshot;
                    AudioManager.Manager.auxIn = false;
                }
                else
                {
                    if (AudioManager.Manager.currentAudioMixerSnapshot == AudioManager.Manager.eventSnap)
                    {
                        idleSnapshot.TransitionTo(0.5f);
                        AudioManager.Manager.currentAudioMixerSnapshot = idleSnapshot;
                        AudioManager.Manager.auxIn = false;
                    }
                }
            }
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Water"))
        {
            audioS.PlayOneShot(splashSound);
        }
        if (other.CompareTag("EnemyZone"))
        {
            auxInSnapshot.TransitionTo(0.5f);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Water"))
        {
            audioS.PlayOneShot(splashSound);
        }
        if (other.CompareTag("EnemyZone"))
        {
            idleSnapshot.TransitionTo(0.5f);
        }
    }
    public void Footsteps()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, -transform.up);
        int r = Random.Range(0, 3);
        if (Physics.Raycast(ray, out hit, 1f))
        {
            switch (hit.transform.tag)
            {
                case "WoodFloor":
                    audioS.PlayOneShot(woodsteps[r]);
                    break;
                case "HardFloor":
                    audioS.PlayOneShot(hardsteps[r]);
                    break;
                case "GrassFloor":
                    audioS.PlayOneShot(grassSteps[r]);
                    break;
                default:
                    audioS.PlayOneShot(grassSteps[r]);

                    break;
            }
        }
    }
}
   

