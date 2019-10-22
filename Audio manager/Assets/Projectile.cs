using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public AudioClip deathSound;
    public AudioSource audioS;
    private void OnCollisionEnter(Collision collision)
    {
        AudioSource.PlayClipAtPoint(deathSound, transform.position);
        
        Destroy(gameObject);

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
