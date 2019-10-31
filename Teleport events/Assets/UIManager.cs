using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public int deathCount;
    public Text deathcountText;
    public void OnEnable()
    {
        Player.onDeath += UpdateDeathConunt;
    }
    // Start is called before the first frame update
   public void UpdateDeathConunt()
    {
        deathCount++;
        deathcountText.text = "Death Count:" + deathCount;
    }
}
