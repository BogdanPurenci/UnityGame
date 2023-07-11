using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lvl5toend : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("Congratulations");
    }
}
