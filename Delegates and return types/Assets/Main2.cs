using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Main2 : MonoBehaviour
{
    public Func<int> onGetName;
    //create a delegate of type int that returns the length of the gameobjects name
    private void Start()
    {
        onGetName = () => this.gameObject.name.Length;
        int characterCount= onGetName();
        Debug.Log("character count" + characterCount);
    }

}
