using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public GameObject deathScreen;
    public GameObject player;
    public Text text;
    public Lives livesScript;
    public int lives = 3;
    public bool isFirstLevel = false;
    Vector2 startPosition;


    private void Start()
    {
        Time.timeScale = 1;
        deathScreen.SetActive(false);
        startPosition = player.transform.position;

        if (isFirstLevel)
        {
            livesScript.playerLives = lives;
        }
        text.text = "Lives: " + livesScript.playerLives;
    }

    public void RestartLevel()
    {
        player.transform.position = startPosition;

        livesScript.playerLives -= 1;
        text.text = "Lives: " + livesScript.playerLives;

        if (livesScript.playerLives <= 0)
        {
            EndGame();
        }
    }




	public void EndGame()
    {
        deathScreen.SetActive(true);
        Time.timeScale = 0;
    }
}
