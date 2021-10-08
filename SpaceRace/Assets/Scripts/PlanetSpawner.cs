using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlanetSpawner : MonoBehaviour
{
    public Sprite[] planetSprite;
    private float spawnRangeX = 0f;
    private float spawnRangeZ = 0f;
    private float startDelay = 5f;
    private float spawnInterval = 10f;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnPlanets), startDelay, spawnInterval);
    }

    private void SpawnPlanets()
    {
        var spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);
        int planetIndex = Random.Range(0, planetSprite.Length);
        
       // Instantiate(planetSprite [planetIndex], spawnPos,
            //planetSprite [planetIndex].transform.rotation); 
    }

}
