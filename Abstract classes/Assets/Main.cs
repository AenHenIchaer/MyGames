using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
 void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if (Physics.Raycast(rayOrigin, out hitInfo))
            {
                if (hitInfo.collider.name=="Player")
  
                    hitInfo.collider.GetComponent<Player>().Damage(100);
                    else if (hitInfo.collider.name == "Enemy1")
                  
                        hitInfo.collider.GetComponent<Enemy1>().Damage(100);
                    
                    

                    
            }
               
            }
        }
    }

