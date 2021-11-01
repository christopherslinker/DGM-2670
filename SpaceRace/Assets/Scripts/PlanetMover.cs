using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetMover : MonoBehaviour
{
    public float speed = 3.0f;
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }
}
