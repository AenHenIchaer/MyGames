using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    //private variable to declare the instance of this class --- has to be static
    private static UIManager _instance;
    public static UIManager Instance
    {
        get
        {
            if (_instance== null)
            {
                Debug.LogError("UImanager is null");
                return _instance;
            }
        }
    }
    public void Awake()
    {
        _instance = this;
    }
    public void UpdateScore(int score)
    {
        Debug.Log("Score" + score);
        Debug.Log("Notifying the game manager");
       
    }
}
