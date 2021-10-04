using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMover : MonoBehaviour
{
    private float speed = 20;
    
    void Update()
    {
        transform.Translate(Vector3.down * (Time.deltaTime * speed));
    }
}
