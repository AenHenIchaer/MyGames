using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Events.onClick += TurnRed;
    }
    public void TurnRed()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
   
}
