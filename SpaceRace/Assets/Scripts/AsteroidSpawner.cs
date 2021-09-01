using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class AsteroidSpawner : MonoBehaviour
{

    public GameObject[] asteroidPrefab;
    public Vector3 spawnPoint;
    public int timeTilNextSpawn = 2;
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
            int asteroidIndex = Random.Range(0, this.asteroidPrefab.Length);
            Instantiate(asteroidPrefab[asteroidIndex], new Vector3(0, 0, 20),
            asteroidPrefab[asteroidIndex].transform.rotation);
            timer = 0;
        }
    }
}
