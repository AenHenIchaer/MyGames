using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth { get; private set; }//any script can get, but only this can set
    #region Singleton
    public static CharacterStats instance;
    private void Awake()
    {
        instance = this;
    }
    #endregion
    private void Start()
    {
        currentHealth = maxHealth;//setting maxhp
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth<=0)
        {
            Death();
        }
    }
    public void Death()
    {
        print("You are dead");
    }
    public void ModifyHealth(int healthModifier)
    {
        currentHealth += healthModifier;
        print(currentHealth);

    }
}
