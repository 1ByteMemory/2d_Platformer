using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NextLevel : MonoBehaviour {

    public GameObject WinMenu;

    private void Start()
    {
        if (WinMenu != null)
        {
            WinMenu.SetActive(false);
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (gameObject.tag == "Win" && WinMenu != null)
            {
                Win();
            } else
            {
                Scene scene = SceneManager.GetActiveScene();
                SceneManager.LoadScene(scene.buildIndex + 1);
            }
            
        }
    }

    void Win ()
    {
        WinMenu.SetActive(true);
        Time.timeScale = 0f;
        return;
    }

}
