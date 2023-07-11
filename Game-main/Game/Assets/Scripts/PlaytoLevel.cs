using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaytoLevel : MonoBehaviour
{
    public void Change()
    {
        SceneManager.LoadScene("LevelSelectScene");
    }   
}
