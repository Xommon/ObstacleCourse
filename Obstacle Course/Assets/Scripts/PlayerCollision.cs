using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
	//
	public PlayerMovement movement;
	public GameManager game;

	//Stop the player if they hit an obstacle
	void OnCollisionEnter(Collision collisionInfo) {
		if (collisionInfo.collider.tag == "Obstacle") {
			movement.enabled = false;
			FindObjectOfType<GameManager>().EndGame();
		}
	}
}