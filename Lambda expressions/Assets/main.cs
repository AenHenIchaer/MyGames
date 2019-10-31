using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class main : MonoBehaviour
{
    public Func<string, int> CharacterLength;
    private void Start()
    {
        CharacterLength = (name) => name.Length;
        int count = CharacterLength("Johnny");
        Debug.Log("Count" + count);
    }
   // int GetCharacters(string name)
   // {
   //     return name.Length;
  //  }
}
