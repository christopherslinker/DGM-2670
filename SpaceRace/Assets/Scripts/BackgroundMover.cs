using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMover : MonoBehaviour
{
    private float speed = 5;
    
    private Vector3 startPos;

    private float repeatLength;

    void Start()
    {
        startPos = transform.position;
        repeatLength = GetComponent<BoxCollider>().size.z / 5;
    }


    void Update()
    {
        if (transform.position.z < startPos.z - repeatLength)
        {
            transform.position = startPos;
        }
        transform.Translate(Vector3.down * (Time.deltaTime * speed));
    }
}
