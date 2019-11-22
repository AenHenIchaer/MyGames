using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Vector3 rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}
