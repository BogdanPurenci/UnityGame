using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScene : MonoBehaviour
{
   
    private void IsDead()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
