using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NextLevel : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.buildIndex + 1);
        }
    }
}
