using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distionary : MonoBehaviour
{
    public Dictionary<string, int> people = new Dictionary<string, int>();
    // Start is called before the first frame update
    void Start()
    {
        people.Add("joh", 26);
        people.Add("James", 29);
        people.Add("Rachel", 53);
        people.Add("Yin", 41);
        int rachelAge = people["Rachel"];

        Debug.Log("Rachels age:" + rachelAge);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
