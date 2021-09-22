using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableSpawner : MonoBehaviour
{
    public GameObject collectable;
    
    private float ySpawn = 0.75f;
    
    public float xSpawnRange = 5.0f;

    public float zSpawnRange = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnCollectable()
    {
    float randomX = Random.Range(-xSpawnRange, xSpawnRange);
    float randomZ = Random.Range(-zSpawnRange, zSpawnRange);
    
    var spawnPos = new Vector3(randomX, ySpawn, randomZ);
    Instantiate(collectable, spawnPos, collectable.gameObject.transform.rotation);
    }
}
