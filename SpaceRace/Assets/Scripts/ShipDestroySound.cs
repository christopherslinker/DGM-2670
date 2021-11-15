using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipDestroySound : MonoBehaviour
{
    public AudioSource destroySound;
    
    

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Asteroid"))
        {
            destroySound.Play();
        }
    }
}
