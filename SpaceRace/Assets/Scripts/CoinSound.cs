using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSound : MonoBehaviour
{
    public AudioSource coinSound;
    
    

 void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectable"))
        {
            coinSound.Play();
        }
    }

}
