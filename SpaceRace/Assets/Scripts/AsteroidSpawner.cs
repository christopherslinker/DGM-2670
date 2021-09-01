using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{

    public GameObject asteroidPrefab;
    public Vector3 spawnPoint;
    public int timeTilNextSpawn = 3;
    float timer = 0;
 
    void Start()
    {
        timer = 0;
    }
 
    private void Update()
    {
        timer += Time.deltaTime;
        Spawn();
    }
 
    void Spawn()
    {
        if (timer >= timeTilNextSpawn)
        {
            Instantiate(asteroidPrefab, spawnPoint, Quaternion.identity);
            timer = 0;
        }
    }
}
