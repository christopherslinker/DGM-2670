using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;

    private float verticalInput;

    private float speed = 5.0f;

    private float xRange = 4f;

    private float zRange = 8.5f;

    //private GameOverBehaviour gameOverBehaviour;
    

    void Start()
    {
        //gameOverBehaviour = GameObject.Find("GameOverBehaviour").GetComponent<GameOverBehaviour>();
    }
    
    void Update()
    {
                if (transform.position.x < -xRange)
                {
                    transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
                }
        
                if (transform.position.x > xRange)
                {
                    transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
                }
                if (transform.position.z < -zRange)
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y, -zRange );
                }
        
                if (transform.position.z > zRange)
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
                }
                
                horizontalInput = Input.GetAxis("Horizontal");
                transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
                
                verticalInput = Input.GetAxis("Vertical");
                transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
    }
    
}
