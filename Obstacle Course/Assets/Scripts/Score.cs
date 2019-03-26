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
		if (game.gameHasEnded == false) {
			if (player.position.z > 10) {
				scoreText.text = (((player.position.z)-10)/20).ToString("0");
			} else {
				scoreText.text = "";
			}
		} else {
			scoreText.color = Color.red;
		}
	}
}