using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
	public Transform player;
	public Text scoreText;
	public GameManager game;

    // Update is called once per frame
	void Update()
	{
		//If the player hasn't lost NOR won, score keeps increasing
		if (game.gameHasEnded == false && game.gameWon == false) {
			if (player.position.z > 10) {
				scoreText.text = (((player.position.z)-10)/20).ToString("0");
			} else {
				scoreText.text = "";
			}
		}

		//If the player hasn't lost AND has won
		if (game.gameHasEnded == false && game.gameWon == true) {
			scoreText.color = Color.green;
		} 

		//If the player has lost
		if (game.gameHasEnded == true)
		{
			scoreText.color = Color.red;
		}
	}
}
