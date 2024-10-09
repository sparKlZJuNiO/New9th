using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Obstacle : MonoBehaviour
{

    private GameObject Player;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "destroy")
        {
            Destroy(this.gameObject);
        }

        else if (collision.tag == "Player")
        {
            Player.gameObject.tag = "Dead";
            Debug.Log(collision.tag);
        }
    


    }
}
