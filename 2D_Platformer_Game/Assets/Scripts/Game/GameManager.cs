using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    // This script is used to restart the level or end the game whe the players lives reach 0.

    public GameObject deathScreen;                                     // Reference to the Death UI.
    public GameObject player;                                          // Reference to the Player.
    public Text text;                                                  // Reference to the text that shows remaining lives.
    public Lives livesScript;                                          // Reference to the scriptable object.
    public int lives = 3;                                              // Amount of lives the player starts with.
    public bool isFirstLevel = false;                                  // If this GameManger is on the first level
    Vector2 startPosition;


    private void Start()                                               // When the scene starts.
    {
        Time.timeScale = 1;                                            // Time is set to 1, the default speed of the game.
        deathScreen.SetActive(false);                                  // The Death UI is deactivated.
        startPosition = player.transform.position;                     // The start position of the player. To reset to without restarting the scene.
        Cursor.visible = false;                                        // Hides the cursor.

        if (isFirstLevel)                                              // If this is the first level.
        {
            livesScript.playerLives = lives;                           // The playerLives variable in the scriptable object is reset.
        }
        text.text = "Lives: " + livesScript.playerLives;               // Remaining lives is shown.
    }

    public void RestartLevel()                                         // Function to restart the level when the player touches a trap.
    {
        player.transform.position = startPosition;                     // Player is sent back to the starting position.

        livesScript.playerLives -= 1;                                  // Remaining lives is deducted by 1.
        text.text = "Lives: " + livesScript.playerLives;               // Remaining lives shown is updated.

        if (livesScript.playerLives <= 0)                              // If the plyers lives is below or equal to 0:
        {
            EndGame();                                                 // EndGame Function is called.
        }
    }

	public void EndGame()                                              // Function that ends the game.
    {
        deathScreen.SetActive(true);                                   // The Death UI is activated.
        Time.timeScale = 0;                                            // Game Time is stopped.
        Cursor.visible = true;                                        // Shows the cursor.
    }
}
