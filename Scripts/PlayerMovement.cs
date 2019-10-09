using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement: MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private float horizontalInput;
    private void Start()
    {
        
    }
    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(horizontalInput,0,0) *speed* Time.deltaTime);
    }
}