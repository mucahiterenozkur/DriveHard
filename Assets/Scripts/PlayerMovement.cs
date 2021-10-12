using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float zSpeedValue;
    public float goSideValues;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
            
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Make all the physics calculation in fixedupdate method. It's better than update.
        rb.AddForce(0, 0, zSpeedValue * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(goSideValues * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-goSideValues * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
