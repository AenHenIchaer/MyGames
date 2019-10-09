using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement: MonoBehaviour
{
    public GameObject[] players;

    private void Start()
    {
       
    }
    private void Update()
    {
        
       
    }
   GameObject[] GetAllPlayers()
    {
        GameObject[] allPlayers = GameObject.FindGameObjectsWithTag("Player");
        foreach(var p in allPlayers)
        {
            p.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
        }
        return allPlayers;
    }
}