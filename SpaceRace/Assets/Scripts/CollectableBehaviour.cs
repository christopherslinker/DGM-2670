using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableBehaviour : MonoBehaviour
{

    private ScoreManager scoreManager;


    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
           scoreManager.UpdateScore(5);
        }
    }


   /* private void OnDestroy()
    {
        scoreManager.UpdateScore(5);
    }*/
}
