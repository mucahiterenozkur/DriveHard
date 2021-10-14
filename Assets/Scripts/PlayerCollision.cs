using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public GameObject endGameCanvas;
    public GameObject inGameCanvas;


    // Start is called before the first frame update
    void Start()
    {
        endGameCanvas.gameObject.SetActive(false);
        playerMovement.scoreText.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Obstacle" || other.gameObject.tag == "SideWalls")
        {
            endGameCanvas.gameObject.SetActive(true);
            playerMovement.scoreText.color = Color.red;
            Debug.Log("Hit");
            playerMovement.rb.velocity = new Vector3(0, 0, 0);
            playerMovement.enabled = false;
            
        }
    }

    
}
