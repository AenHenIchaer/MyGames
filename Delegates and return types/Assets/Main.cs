using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Main : MonoBehaviour
{
    public Action onGetName;
    private void Start()
    {
        onGetName = () =>
        {
            Debug.Log("Name" + gameObject.name);
            
        };
        onGetName();
        // create a delegate of type void that has no parameters and returns the gameObjects name
        // void GetName()
        // {
        //    Debug.Log("Name+" + gameObject.name);
        //}
    }
}
