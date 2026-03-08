using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class Menu : MonoBehaviour
{
    public void PlayGame()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        SceneManager.LoadSceneAsync("level1");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
