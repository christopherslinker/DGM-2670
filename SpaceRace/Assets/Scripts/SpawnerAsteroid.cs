using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerAsteroid : MonoBehaviour
{
    public GameObject[] asteroidPrefab;

    private float spawnRangeX = 4;

    private float SpawnPosZ = 12.5f;

    private float startDelay = 2;

    public float startInterval = 3.0f;

    public float increaseSpeed = .5f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnRandomAsteroid), startDelay, startInterval);
    }
    
    private void SpawnRandomAsteroid ()
    {
        var spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, SpawnPosZ);
                
        int asteroidIndex = Random.Range(0, asteroidPrefab.Length);
                
        Instantiate(asteroidPrefab [asteroidIndex], spawnPos,
            asteroidPrefab [asteroidIndex].transform.rotation);

        if (Time.deltaTime == 5)
        {
            startInterval = startInterval - increaseSpeed;
        }
    }
}
