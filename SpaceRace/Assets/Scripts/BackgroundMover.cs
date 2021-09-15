using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMover : MonoBehaviour
{
    private float speed = 5;
    

    private Vector3 startPos;

    private float repeatLength;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        repeatLength = GetComponent<BoxCollider>().size.z;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < startPos.z - repeatLength)
        {
            transform.position = startPos;
        }
        transform.Translate(Vector3.down * Time.deltaTime * speed);
    }
}
