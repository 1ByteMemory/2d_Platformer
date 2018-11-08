using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

    public static bool IsPaused = false;
    public GameObject PauseMenuUI;

    private void Start()
    {
        PauseMenuUI.SetActive(false);
    }

    void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) {
            if (IsPaused)
            {
                Resume();
            } else
            {
                Pause();
            }
        }
	}

    public void Resume ()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        IsPaused = false;
    }

    public void Pause ()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        IsPaused = true;
    }

    public void MainMenu ()
    {
        
        SceneManager.LoadScene(0);
    }
}
