using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public void OnEnable()
    {
        Player.onDeath += ResetPlayer;
    }
    public void ResetPlayer()
    {
        Debug.Log("Resetting Player");
    }
}
