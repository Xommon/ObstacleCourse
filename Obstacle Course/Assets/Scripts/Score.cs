using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
    	if (player.position.z > 5) {
    		scoreText.text = (((player.position.z)-10)/20).ToString("0");
    	} else {
    		scoreText.text = "";
    	}

    }
}
