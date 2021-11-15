using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlanetSpawner : MonoBehaviour
{
    public GameObject[] planetPrefab;

    private float spawnRangeX = 4;

    private float SpawnPosZ = 12.5f;

    private float startDelay = 10;

    public float startInterval = 40.0f;


    void Start()
    {
        InvokeRepeating(nameof(SpawnRandomAsteroid), startDelay, startInterval);
    }
    
    private void SpawnRandomAsteroid ()
    {
        var spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, SpawnPosZ);
                
        int planetIndex = Random.Range(0, planetPrefab.Length);
                
        Instantiate(planetPrefab [planetIndex], spawnPos,
            planetPrefab [planetIndex].transform.rotation);
        
    }

}
