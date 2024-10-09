using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{

    public GameObject DeathScreenCanvas2;
    private GameObject Player;
    public AudioClip backgroundMusic;

    public AudioSource sfxPlayer;
    public AudioSource musicPlayer;


    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Dead"))
        {
            DeathScreenCanvas2.SetActive(true);
            musicPlayer.Stop();
        }
    }
}
