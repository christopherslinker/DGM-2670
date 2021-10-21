using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerDestroy : MonoBehaviour
{
    private GameOverBehaviour gameOverBehaviour;

    private void Start()
    {
        gameOverBehaviour = GameObject.Find("GameOverBehaviour").GetComponent<GameOverBehaviour>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Asteroid"))
        {
            Destroy(gameObject);
            gameOverBehaviour.GameOver();
        }
    }
    
}
