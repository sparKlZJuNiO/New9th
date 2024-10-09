using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathManager : MonoBehaviour
{ 
    public GameObject DeathScreenCanvas; // Reference to the Death Screen Canvas

    public AudioClip backgroundMusic;

    public AudioSource sfxPlayer;
    public AudioSource musicPlayer;

    // Show the death screen
    public void ShowDeathScreen()
{
    // Activate the death screen UI
    DeathScreenCanvas.SetActive(true);

        // Pause the game
        Time.timeScale = 1f;
        musicPlayer.Stop();
    }


    // Restart the game (called by a button)

    public void RestartGame()
    {

    // Reset time and reload the current scene
    Time.timeScale = 1f;
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Quit the game (called by a button)

public void QuitGame()
    {
    // Reset time scale and quit application
        Time.timeScale = 1f;
        Application.Quit();
    }
}

