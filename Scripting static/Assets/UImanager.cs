using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    public Text activeEnemiesText;
    public  void UpdateEnemyCount()
    {
        activeEnemiesText.text = "Active enemies:" + SpawnManager.enemyCount;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
