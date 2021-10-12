using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRoad : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        transform.position += new Vector3(0, 0, transform.GetChild(0).GetComponent<Renderer>().bounds.size.z * 10);
        //Debug.Log("hit");
    }
}
