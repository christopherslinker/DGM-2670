using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CollectableSpawner : MonoBehaviour
{
    public GameObject collectable;
    
    private float ySpawn = 0.75f;
    
    private float xSpawnRange = 5.0f;

    private float zSpawnRangeDown = 15.0f;

    private float zSpawnRangeUp = 3.0f;

    private float startDelay = 3.0f;

    private float collectableSpawnTime = 3.0f;

    void Start()
    {        
        InvokeRepeating("SpawnCollectable", startDelay, collectableSpawnTime);
    }

    void SpawnCollectable()
    {
    float randomX = Random.Range(-xSpawnRange, xSpawnRange);
    float randomZ = Random.Range(-zSpawnRangeDown, zSpawnRangeUp);
    
    var spawnPos = new Vector3(randomX, ySpawn, randomZ);
    Instantiate(collectable, spawnPos, collectable.gameObject.transform.rotation);
    }
}
