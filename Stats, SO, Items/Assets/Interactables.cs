using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactables : MonoBehaviour
{
    public bool interactable = false;
    public Material[] material;
    Renderer rend;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }
    public virtual void Interact()
    {
        Destroy(gameObject);
    }
    private void Update()
    {
        if (interactable && Input.GetKeyDown(KeyCode.JoystickButton0))
        {
            Interact();
        }
        if (interactable)
        {
            rend.sharedMaterial = material[1];
        }
        else
        {
            rend.sharedMaterial = material[0];
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Player")
        {
            interactable = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            interactable = false;
        }
    }
}
