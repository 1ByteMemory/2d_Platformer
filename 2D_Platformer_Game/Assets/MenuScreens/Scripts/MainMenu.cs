using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    public int firstLevelIndex = 1;

    public void PlayGame ()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.buildIndex + 1);
    }

    public void Resart ()
    {
        SceneManager.LoadScene(firstLevelIndex);
    }

    public void QuitGame ()
    {
        Application.Quit();
    }
}
