using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement: MonoBehaviour
{
    
  

    private void Start()
    {
        transform.position = GetPosition(0, 0, 0);
    }
    private void Update()
    {
     
       
    }
    public void ChangePosition(Vector3 pos)
    {
        transform.position = pos;
    }
 
    public Vector3 GetPosition(float x, float y, float z)
    {
        Vector3 pos = new Vector3(x, y, z);
        return pos;
    }
}