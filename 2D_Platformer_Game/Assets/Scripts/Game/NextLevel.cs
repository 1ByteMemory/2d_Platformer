using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NextLevel : MonoBehaviour {

    // Script that sends the player to the next level.
    // And if it's the final level then it brings up the Win screen.

    public GameObject WinMenu;                                          // Referance to the win ui.

    private void Start()                                                // On the start of the scene.
    {
        if (WinMenu != null)                                            // If no Win UI was set then it skips this bit.
        {
            WinMenu.SetActive(false);                                   // Deactivates the WIn UI so that it doesn't appear while playing.
        }

    }

    private void OnTriggerEnter(Collider other)                         // When something Enters the trigger
    {
        if (other.tag == "Player")                                      // If that something is the player
        {
            if (gameObject.tag == "Win" && WinMenu != null)             // If there is a win menu and this object has the win tag. (Hind site I could have a public bool isWinPortal)
            {
                Win();                                                  // Calls the Win function
            } else                                                      // If it isn't the winning portal then:
            {
                Scene scene = SceneManager.GetActiveScene();            // Gets the currently active scene
                SceneManager.LoadScene(scene.buildIndex + 1);           // Loads up the next scene in the index.
            }

        }
    }

    void Win ()                                                         // Win Function.
    {
        WinMenu.SetActive(true);                                        // Activates the Win UI
        Time.timeScale = 0f;                                            // Game Time is set to 0, the player cannot move the character.
        Cursor.visible = true;                                          // Shows the cursor.
        return;
    }

}
