using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    
}
