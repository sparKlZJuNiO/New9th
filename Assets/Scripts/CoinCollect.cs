using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollect : MonoBehaviour
{

    public Text MyscoreText;
    private int ScoreNum;

    void Start()
    {
        ScoreNum = 0;
        MyscoreText.text = "SCORE : " + ScoreNum;
    }


   private void OnTriggerEnter2D(Collider2D Coin)
    {
        // Check if the object colliding with the coin is the player
        if (Coin.tag == "coin")
        {
            // Add any score incrementing logic here, e.g.:
            // ScoreManager.instance.AddScore(1);

            // Destroy the coin when it hits the player
            ScoreNum += 1;
            Destroy(Coin.gameObject);
            MyscoreText.text = "SCORE : " + ScoreNum;
        }
    }
}
