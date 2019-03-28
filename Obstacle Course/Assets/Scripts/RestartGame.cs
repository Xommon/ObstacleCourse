using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public void QuitTheGame() {
    	Application.Quit();
    	Debug.Log("Application terminated.");
    }
}
