using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Manager;
    private void Awake()
    {
        Manager = this;
    }
    public AudioSource mainMusic;
    public AudioSource auxMusic;
    public AudioSource ambientSound;
    public AudioSource eventMusic;
    public AudioMixerSnapshot eventSnap;
    public AudioMixerSnapshot idelSnapshot;
    public bool eventRunning;
    public bool auxIn;
    public AudioMixerSnapshot currentAudioMixerSnapshot;
    public IEnumerator PlayEventMusic()
    {
        eventRunning = true;
        eventSnap.TransitionTo(0.25f);
        currentAudioMixerSnapshot = eventSnap;
        yield return new WaitForSeconds(0.3f);
        eventMusic.Play();
        while (eventMusic.isPlaying)
        {
            yield return null;
        }
        eventRunning = false;
        idelSnapshot.TransitionTo(0.5f);
        yield break;
    }
    
}
