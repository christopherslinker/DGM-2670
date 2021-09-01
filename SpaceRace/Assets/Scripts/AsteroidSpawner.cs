using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class AsteroidSpawner : MonoBehaviour
{

    public GameObject[] asteroidPrefab;
    public int timeTilNextSpawn = 2;
    float timer = 0;
    public float spawnRangeX = 20;
    public float spawnPosZ = 20;
 
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
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        
        if (timer >= timeTilNextSpawn)
        {
            int asteroidIndex = Random.Range(0, this.asteroidPrefab.Length);
            Instantiate(asteroidPrefab[asteroidIndex], new Vector3(0, 0, 20),
            asteroidPrefab[asteroidIndex].transform.rotation);
            timer = 0;
        }
    }
}
