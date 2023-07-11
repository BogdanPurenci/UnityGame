using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectorBack : MonoBehaviour
{
    public void GoBack()
    {
        SceneManager.LoadScene("MainMenuScene");
    }

    public void GoLvl1()
    {
        SceneManager.LoadScene("Level1");
    }
    
    public void GoLvl2()
    {
        SceneManager.LoadScene("Level2Again");
    }

    public void GoLvl3()
    {
        SceneManager.LoadScene("Level3");
    }

    public void GoLvl4()
    {
        SceneManager.LoadScene("Level4");
    }

    public void GoLvl5()
    {
        SceneManager.LoadScene("Level5");
    }
}
