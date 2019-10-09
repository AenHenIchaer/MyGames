using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponChoose : MonoBehaviour
{
    public int WeaponID;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        switch (WeaponID)
        {
            case 1:
                Debug.Log("Gun");
                break;
            case 2:
                Debug.Log("Knife");
                break;
            case 3:
                Debug.Log("Mashine Gun");
                break;
            default:
                Debug.Log("Invalid weapon");
                break;
        }
    }
}