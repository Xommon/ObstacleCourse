﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public void RestartTheGame() {
    	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
