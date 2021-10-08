using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;

    private float verticalInput;

    private float speed = 5.0f;

    private float xRange = 4.5f;

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
                
                horizontalInput = Input.GetAxis("Horizontal");
                transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
                
                verticalInput = Input.GetAxis("Vertical");
                transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
    }

}
