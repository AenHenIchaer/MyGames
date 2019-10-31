using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour
{
   // public delegate void OnDamageReceived(int currentHealth);
 //   public static event OnDamageReceived onDamage;
    public static Action<int> onDamageReceived;
   public int Health { get; set; }
    private void Start()
    {
        Health = 10;
    }
    void Damage()
    {
        Health--;
        if (onDamageReceived!=null)
        {
            onDamageReceived(Health);
        }
    }
}
