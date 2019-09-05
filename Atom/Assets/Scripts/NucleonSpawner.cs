using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NucleonSpawner : MonoBehaviour
{
    public float timeBetweenspawns;
    public float spawnDistance;
    float timeSinceLastSpawn;
    public Nucleon[] nucleonPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void SpawnNucleon()
    {
        Nucleon prefab = nucleonPrefabs[Random.Range(0, nucleonPrefabs.Length)];
        Nucleon spawn = Instantiate<Nucleon>(prefab);
        spawn.transform.localPosition = Random.onUnitSphere * spawnDistance;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        timeSinceLastSpawn += Time.deltaTime;
        if (timeSinceLastSpawn>=timeBetweenspawns)
        {
            timeSinceLastSpawn -= timeBetweenspawns;
            SpawnNucleon();
        }
    }
}
