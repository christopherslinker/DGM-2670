using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerAsteroid : MonoBehaviour
{
    public GameObject[] asteroidPrefab;

    private float spawnRangeX = 6;

    private float SpawnPosZ = 20;

    private float startDelay = 2;

    private float startInterval = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnRandomAsteroid), startDelay, startInterval);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void SpawnRandomAsteroid ()
    {
        Vector3 SpawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, SpawnPosZ);
                
        int asteroidIndex = Random.Range(0, asteroidPrefab.Length);
                
        Instantiate(asteroidPrefab [asteroidIndex], SpawnPos,
            asteroidPrefab [asteroidIndex].transform.rotation); 
    }
}
