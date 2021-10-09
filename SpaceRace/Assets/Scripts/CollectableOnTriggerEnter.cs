using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableOnTriggerEnter : MonoBehaviour
{

    private ScoreManager scoreManager;

    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectable"))
        {
            scoreManager.UpdateScore(20);
            Destroy(other.gameObject);
        }
    }


}
