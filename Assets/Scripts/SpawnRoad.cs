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

    //private void OnTriggerEnter(Collider other)
    //{
    //    roads.SpawnRoadd();
    //    Destroy(gameObject, 1f);

    //}

    IEnumerator SpawnObstacless()
    {
        List<int> whereToPlaced = new List<int>();
        int numberOfSpawn = Random.Range(5, 7);
        //Debug.Log(numberOfSpawn);

        for (int i = 0; i < numberOfSpawn; i++)
        {
            int spawnPlace = Random.Range(1, 8);

            Transform spawnPoint = transform.GetChild(spawnPlace).transform;

            int whichObstacleToSpawn = Random.Range(0, obstacles.Length);

            if (!whereToPlaced.Contains(spawnPlace))
            {
                whereToPlaced.Add(spawnPlace);
                Instantiate(obstacles[whichObstacleToSpawn], spawnPoint.position, Quaternion.identity, transform);
            }

                
        }
           

        yield return new WaitForSeconds(0f);

    }


}
