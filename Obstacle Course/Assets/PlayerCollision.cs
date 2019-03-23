using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
	//
	public PlayerMovement movement;

	//Stop the player if they hit an obstacle
	void OnCollisionEnter(Collision collisionInfo) {
		if (collisionInfo.collider.tag == "Obstacle") {
			movement.enabled = false;
			Debug.Log("OBSTACLE COLLISION.");
		}

		// //Stop the player if they fall off the map
		// if (collisionInfo.collider.name != "Ground") {
		// 	movement.enabled = false;
		// 	Debug.Log("No ground collision.");
		// }
	}
}