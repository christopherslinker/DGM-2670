using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;

    private float verticalInput;

    private float speed = 5.0f;

    private float xRange = 6;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
