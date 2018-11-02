using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives : MonoBehaviour {
    
    public int playerLives = 3;

    public void PlayerLives (int amount)
    {
        playerLives -= amount;

        // Death Function
        if (playerLives <= 0)
        {
            // restart the scene.
        }
    }

}
