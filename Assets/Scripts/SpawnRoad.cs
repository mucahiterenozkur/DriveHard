using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRoad : MonoBehaviour
{
    //public Transform[] spawnPoints;
    private Roads roads;
    public GameObject[] obstacles;
    
    
    // Start is called before the first frame update
    void Start()
    {
        roads = FindObjectOfType<Roads>();
        StartCoroutine(SpawnObstacless());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        roads.SpawnRoadd();
        Destroy(gameObject, 1f);

        //Destroy(gameObject);

        //transform.position += new Vector3(0, 0, transform.GetChild(0).GetComponent<Renderer>().bounds.size.z * 5);
        //GameObject newRoad = Instantiate(roadPrefab, currentRoads[0].transform.GetChild(0).GetComponent<Renderer>().bounds.size * 5, Quaternion.identity) as GameObject;
        //currentRoads.Add(newRoad);
        //Destroy(gameObject);

        //Debug.Log("hit");
    }

    IEnumerator SpawnObstacless()
    {
        List<int> whereToPlaced = new List<int>();
        int numberOfSpawn = Random.Range(3, 5);
        Debug.Log(numberOfSpawn);

        for (int i = 0; i < numberOfSpawn; i++)
        {
            int spawnPlace = Random.Range(1, 6);
            Transform spawnPoint = transform.GetChild(spawnPlace).transform;

            int whichObstacleToSpawn = Random.Range(0, obstacles.Length);

           
            if (!whereToPlaced.Contains(spawnPlace))
            {
                whereToPlaced.Add(spawnPlace);
                Instantiate(obstacles[whichObstacleToSpawn], spawnPoint.position, Quaternion.identity, transform);
            }

                
        }
           

        yield return new WaitForSeconds(1f);

    }


}
