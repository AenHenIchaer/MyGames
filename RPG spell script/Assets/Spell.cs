using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Spell
{
    public string name;
    public int levelRequired;
    public int itemIDRequired;
    public int expGained;

    public Spell(string name, int levRequired, int itemIDRequired, int exp)
    {
        this.name = name;
        this.levelRequired = levRequired;
        this.itemIDRequired = itemIDRequired;
        this.expGained = exp;
    }

    public void Cast()
    {
        Debug.Log("Casting:"+this.name);
    }
}
