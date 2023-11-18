using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl : MonoBehaviour
{
    float rotationSpeed = 40;
    float xAxis;
    float yAxis;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        xAxis = Input.GetAxis("Vertical");
        yAxis = Input.GetAxis("Horizontal");

        transform.Rotate(Vector3.down , xAxis * rotationSpeed * Time.deltaTime);
        transform.Rotate(Vector3.right, yAxis * rotationSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.Space))
        {
            transform.localScale += Vector3.one *  Time.deltaTime;
        }
        else
        {
            if (transform.localScale.x > 0.1f) 
            {
                transform.localScale -= Vector3.one *  Time.deltaTime;
            }
        }
    }
}

