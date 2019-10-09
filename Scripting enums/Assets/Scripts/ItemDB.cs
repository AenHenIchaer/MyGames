using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDB : MonoBehaviour
{
    public List<Item> itemDB = new List<Item>();
    // Start is called before the first frame update
    void Start()
    {
        itemDB[1].Action();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
