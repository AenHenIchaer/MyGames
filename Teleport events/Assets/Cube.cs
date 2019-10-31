using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private void Start()
    {
        Teleport.onTeleport += Spawn;
    }
    public void Spawn(Vector3 pos)
    {
        transform.position = pos;
    }
    private void OnDisable()
    {
        Teleport.onTeleport -=Spawn;
    }
}
