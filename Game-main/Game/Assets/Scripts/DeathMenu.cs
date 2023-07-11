using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    public void RestartButton()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
        Time.timeScale = 1.0f;
    }

    public void MenuButton()
    {
        SceneManager.LoadScene("MainMenuScene");
        Time.timeScale = 0f;
    }
}
