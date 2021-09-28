using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundRepeat : MonoBehaviour
{

    public float speed = 0.5f;
    
    void Update()
    {
        Vector3 offset = new Vector3(0, Time.deltaTime * speed);
        Renderer.material.mainTextureOffset = offset;
    }
}
