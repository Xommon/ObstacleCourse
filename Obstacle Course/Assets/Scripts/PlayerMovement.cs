using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public Rigidbody rb;

	public float forwardForce = 1200f;
	public float sideForce = 500f;
    public float difficulty;
    public GameManager game;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (game.gameHasEnded == false) {
        //Determine difficulty
            if (rb.position.z < 0) {
                difficulty = 1;
            } else {
                difficulty = (rb.position.z)/20;
            }

    	//Add a forward force
            rb.AddForce(0, 0, forwardForce * Time.deltaTime + difficulty);

            if (Input.GetKey("d")) {
               rb.AddForce(sideForce * Time.deltaTime + (difficulty/30), 0, 0, ForceMode.VelocityChange);
           }

           if (Input.GetKey("a")) {
               rb.AddForce(-sideForce * Time.deltaTime - (difficulty/30), 0, 0, ForceMode.VelocityChange);
           }

           //Game has ended if player falls off playform
           if (rb.position.x <= -7.5f || rb.position.x >= 7.5f) {
            FindObjectOfType<GameManager>().EndGame();
        }
    } else {
        sideForce = 0;
    }
}
}
