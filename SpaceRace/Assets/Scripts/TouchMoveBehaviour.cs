using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMoveBehaviour : MonoBehaviour
{
    private Touch touch;
    private float speed = 0.01f;

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(
                    transform.position.x + touch.deltaPosition.x * speed,
                    transform.position.y,
                    transform.position.z + touch.deltaPosition.y * speed);
            }
        }
    }
    
    //source: https://www.youtube.com/watch?v=3_CX-KtsDic&t=148s
}
