using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public float fallThreshold = -10f; // Y position threshold at which player dies
    private DeathManager DeathManager; // Reference to the DeathManager script

    // Start is called before the first frame update
    void Start()
    {
        // Get reference to the DeathManager 
        DeathManager = FindObjectOfType<DeathManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the player falls below the Y-axis threshold
        if (transform.position.y < fallThreshold)
        {
            // Call the method to show the death screen
             DeathManager.ShowDeathScreen();
        }
    }
}
