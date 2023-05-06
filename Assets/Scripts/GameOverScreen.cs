using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{

    public void Setup()
    {
        gameObject.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void RestartButton()
    {
        Application.LoadLevel("Map1");
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }

    public void MainMenuButton()
    {
        Application.LoadLevel("MainMenu");
    }
}
