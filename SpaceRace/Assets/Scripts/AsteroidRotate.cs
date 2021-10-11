using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidRotate : MonoBehaviour
{
    
    public float rotateSpeed = 100.0f;

    void Start()
    {
        
    }

    private void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * rotateSpeed);
    }
    
}
