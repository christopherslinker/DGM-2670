using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableSpawner : MonoBehaviour
{
    public GameObject Collectable;
    
    private float ySpawn = 0.75f;
    
    public float xSpawnRange;

    public float zCollectableRange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomCollectable()
    {
    float randomX = Random.Range(-xSpawnRange, xSpawnRange);
    float randomZ = Random.Range(-zCollectableRange, zCollectableRange);
    
    Vector3 spawnPos = new Vector3(randomX, ySpawn, randomZ);
    Instantiate(Collectable, spawnPos, Collectable.gameObject.transform.rotation);
    }
}
