using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour, IDamageable<int>
{
    public int Health
    {
        get;
        set;
    }

    public void Damage(int damageAmount)
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }

    // Start is called before the first frame update
   
}
