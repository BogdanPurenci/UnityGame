using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathSceneScript : MonoBehaviour
{
    public void GoMain()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
    public void GoRetry()
    {

    }
}
