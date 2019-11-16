using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="New Health Potion", menuName = "Inventory/Potion")]
public class HealthPotion : Item
{
    public int healthModifier;
    CharacterStats charStats;

    private void Start()
    {
        charStats = CharacterStats.instance;
    }
    public override void Use()
    {
        base.Use();
        ApplyEffect();
    }
    public void ApplyEffect()
    {
        CharacterStats.instance.ModifyHealth(healthModifier);
    }
}
