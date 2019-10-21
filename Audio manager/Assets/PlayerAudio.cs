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
    
    public LayerMask enemyMask;
    bool enemyNear;

    private void Update()
    {
        RaycastHit[] hits = Physics.SphereCastAll(transform.position, 5f, transform.forward, 0f, enemyMask);
        if (hits.Length > 0)
        {
            if (!enemyNear)
            {
                Debug.Log(hits[0].transform.name);
                Debug.Log("Set enemy near");
                auxInSnapshot.TransitionTo(0.5f);
                enemyNear = true;
            }
        }
        else
            if (enemyNear)
        {
            enemyNear = false;
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
}
   

