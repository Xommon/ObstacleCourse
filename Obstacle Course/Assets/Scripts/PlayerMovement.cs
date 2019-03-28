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
    	//Add a forward force
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);

            if (Input.GetKey("right") || Input.GetKey("d")) {
               //rb.AddForce(sideForce * Time.deltaTime + (difficulty/30), 0, 0, ForceMode.VelocityChange);
              transform.Translate(Vector3.right * Time.deltaTime * 16);
           }

           if (Input.GetKey("left") || Input.GetKey("a")) {
               //rb.AddForce(-sideForce * Time.deltaTime - (difficulty/30), 0, 0, ForceMode.VelocityChange);
              transform.Translate(Vector3.left * Time.deltaTime * 16);
           }

           //Game has ended if player falls off playform
           if (rb.position.x <= -7.5f || rb.position.x >= 7.5f) {
            FindObjectOfType<GameManager>().EndGame();

            //Player wins if they make it to the end
            if (rb.position.z >= 2000) {
              FindObjectOfType<GameManager>().WinGame();
            }
        }
    } else {
        sideForce = 0;
    }
}
}
