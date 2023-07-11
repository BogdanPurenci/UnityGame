using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class congratsscript : MonoBehaviour
{
    public void GoMainMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}
