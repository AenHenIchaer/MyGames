using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement: MonoBehaviour
{
    
    public int health = 100;

    private void Start()
    {
       
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&& IsDead() == false)
        {
            Damage(Random.Range(5, 20));
        }
       
    }
    public void Damage(int damageAmount)
    {
        health -= damageAmount;
        if (IsDead()== true)
        {
            health = 0;
            Debug.Log("The Player has died");
        }
      
    }
    public bool IsDead()
    {
        return health < 1;
    }
}