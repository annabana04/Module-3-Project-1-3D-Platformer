using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        int currSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currSceneIndex + 1;

        if (other.CompareTag("Player"))
        {
            if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
            {
                SceneManager.LoadScene(nextSceneIndex);
            }
            else
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                SceneManager.LoadScene(0);
            }
        }
    }
}
