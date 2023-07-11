using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathTrigger : MonoBehaviour
{

    public GameObject deathCanvasUI;

    void OnTriggerEnter2D(Collider2D other)
    {
        deathCanvasUI.SetActive(true);
    }
}