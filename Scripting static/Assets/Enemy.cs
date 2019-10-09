using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private UImanager _ui;
    public void OnEnable()
    {
        SpawnManager.enemyCount++;
        _ui = GameObject.Find("UI_Manager").GetComponent<UImanager>();
        _ui.UpdateEnemyCount();
        Die();
    }
    public void OnDisable()
    {
        SpawnManager.enemyCount--;
        _ui.UpdateEnemyCount();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Die()
    {
        Destroy(this.gameObject, Random.Range(2,6));
    }
}
