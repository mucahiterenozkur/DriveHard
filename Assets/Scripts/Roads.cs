using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roads : MonoBehaviour
{
    public GameObject roadPrefab;
    Vector3 nextSpawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            SpawnRoadd();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnRoadd()
    {

        GameObject temp = Instantiate(roadPrefab, nextSpawnPoint, Quaternion.identity) as GameObject;
        nextSpawnPoint = temp.transform.GetChild(8).transform.position;


    }
}
