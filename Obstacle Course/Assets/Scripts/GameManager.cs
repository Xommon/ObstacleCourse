using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public bool gameHasEnded = false;
    public bool gameWon = false;

    public GameObject gameWonUI;

	public float restartDelay = 3f;

    public void EndGame() {
    	if (gameHasEnded == false) {
    		gameHasEnded = true;
    		Invoke("Restart", restartDelay);
    	}
    }

    public void WinGame() {
        gameWonUI.SetActive(true);
    }

    void Update() {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

    void Restart() {
    	SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
