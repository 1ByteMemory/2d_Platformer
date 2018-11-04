using UnityEngine.SceneManagement;
using UnityEngine;

public class Lives : MonoBehaviour {
    
    public int playerLives = 3;
    

    private void OnControllerColliderHit(ControllerColliderHit collision)
    {

        if (collision.collider.tag == "death")
        {
            playerLives -= 1;


            // Death Function
            if (playerLives <= 0)
            {
                FindObjectOfType<GameManager>().EndGame();
            }
        }
    }
}
