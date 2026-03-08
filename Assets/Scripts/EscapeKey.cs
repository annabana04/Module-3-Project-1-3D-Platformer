using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class EscapeKey : MonoBehaviour
{
    void Update()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene("Menu");
            Debug.Log("Open Menu.");
        }
    }
}
