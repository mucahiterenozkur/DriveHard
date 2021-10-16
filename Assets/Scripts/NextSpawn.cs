using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextSpawn : MonoBehaviour
{
    private Roads roads;
    public SpawnRoad spawnRoadPrefab;

    // Start is called before the first frame update
    void Start()
    {
        roads = FindObjectOfType<Roads>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        roads.SpawnRoadd();
        Destroy(spawnRoadPrefab.gameObject, 1f);
    }
}
