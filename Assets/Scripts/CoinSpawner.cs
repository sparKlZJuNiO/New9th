using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    // Reference to the coin prefab
    public GameObject coinPrefab;

    // Define the offset or range where the coin should spawn on the platform
    public Vector2 coinOffset = new Vector2(0, 1); // Adjust as necessary
    
    void Start()
    {
        // Spawn the coin on the platform at the desired position
        SpawnCoin();
    }

    
    void SpawnCoin()
    {
        // Calculate the coin position relative to the platform
        Vector3 coinPosition = transform.position + (Vector3)coinOffset;

        // Instantiate the coin at the calculated position
        Instantiate(coinPrefab, coinPosition, Quaternion.identity); 
    }
}
