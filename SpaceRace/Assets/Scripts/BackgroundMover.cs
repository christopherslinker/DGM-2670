using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMover : MonoBehaviour
{
    private float speed = 1f;
    
    void Update()
    {
        transform.Translate(Vector3.down * (Time.deltaTime * speed));
    }
}
