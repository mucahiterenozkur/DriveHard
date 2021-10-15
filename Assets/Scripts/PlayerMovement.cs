using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float zSpeedValue;
    public float goSideValues;

    public TextMeshProUGUI scoreText;


    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "0";
    }

    void Update()
    {
        scoreText.text = transform.position.z.ToString("0");

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Make all the physics calculation in fixedupdate method. It's better than update.
        //rb.AddForce(0, 0, zSpeedValue * Time.deltaTime);
        rb.AddRelativeForce(Vector3.forward * zSpeedValue * Time.deltaTime - rb.velocity);
        //rb.velocity = new Vector3(0, 0, zSpeedValue * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(goSideValues * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            //rb.velocity = new Vector3(goSideValues * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-goSideValues * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            //rb.velocity = new Vector3(-goSideValues * Time.deltaTime, 0, 0);
        }
    }
}
