using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public GameObject endGameCanvas;
    public GameObject inGameCanvas;
    public Animator endGameCanvasAnimator;
    public Animator inGameCanvasAnimator;
    //public GameObject darkLayer;


    // Start is called before the first frame update
    void Start()
    {
        endGameCanvasAnimator.SetBool("isGameOver", false);
        inGameCanvasAnimator.SetBool("isGameOverDarker", false);
        //darkLayer.SetActive(false);
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
            
            //darkLayer.SetActive(true);
            endGameCanvas.gameObject.SetActive(true);
            endGameCanvasAnimator.SetBool("isGameOver", true);
            inGameCanvasAnimator.SetBool("isGameOverDarker", true);
            playerMovement.scoreText.color = Color.green;
            Debug.Log("Hit");
            playerMovement.rb.velocity = new Vector3(0, 0, 0);
            playerMovement.enabled = false;
            
        }
    }

    
}
