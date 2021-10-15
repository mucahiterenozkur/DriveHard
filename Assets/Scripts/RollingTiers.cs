using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingTiers : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(-10000f, 0f, 0f) * Time.deltaTime); 
    }
}
