using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class YouWon : MonoBehaviour
{

    public void Setup()
    {
        gameObject.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void MainMenuButton()
    {
        Application.LoadLevel("MainMenu");
    }
}
