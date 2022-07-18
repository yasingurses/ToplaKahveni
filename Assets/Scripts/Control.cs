using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{

    public float forwardSpeed;
    void Start()
    {
        
    }
    private float firstTouchX;
    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-1*forwardSpeed*Time.deltaTime,0,0);
        Vector3 moveVector = new Vector3(-1 * forwardSpeed * Time.deltaTime, 0, 0);
        float diff = 0;
        if (Input.GetMouseButtonDown(0))
        {
            firstTouchX = Input.mousePosition.x;
        }
        else if (Input.GetMouseButton(0))
        {
            float lastTouchX = Input.mousePosition.x;
            diff = lastTouchX - firstTouchX;
            moveVector += new Vector3(0, 0, diff * Time.deltaTime);
            firstTouchX = lastTouchX;
        }

        transform.position += moveVector;
    }
}

