
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
	public GameManager game;

    void OnTriggerEnter()
    {
        game.WinGame();
    }
}
