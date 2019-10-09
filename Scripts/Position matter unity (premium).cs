using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement: MonoBehaviour
{
    public Vector3[] positions;
    private int randomIndex;

    private void Start()
    {
        randomIndex = GetRandom();
        Debug.Log("Random Index:" + randomIndex);
        transform.position = GetPosition(randomIndex);
    }
    private void Update()
    {
        
       
    }
    int GetRandom()
    {
        return Random.Range(0, positions.Length);
    }
    Vector3 GetPosition(int index)
    {
        return positions[index];
    }
}