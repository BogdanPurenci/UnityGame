 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 4;
    public int currentHealth;

    public HealthBarScript healthBar;

    public GameObject deathCanvasUI;
    [Header("Iframes")]
    [SerializeField] private float iframesDuration;
    [SerializeField] private int numberOfFlashes;
    private SpriteRenderer spriteRend;
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    private void FixedUpdate()
    {
        if (currentHealth == 0)
        { 
            deathCanvasUI.SetActive(true);
        }
    }

    public void TakeDamage(int _damage)
    {
    
        currentHealth = Mathf.Clamp(currentHealth - _damage , 0, maxHealth);
        /* if (currentHealth > 0)
         {
             StartCoroutine(Invulnerability());

         }*/
        healthBar.SetHealth(currentHealth);
   
      
    }
   /* private IEnumerator Invulnerability()
    {
        Physics2D.IgnoreLayerCollision(7, 9, true);
        for (int i = 0; i < numberOfFlashes; i++)
        {
        {
            spriteRend.color = new Color(1, 0, 0, 0.5f);
            yield return new WaitForSeconds(iframesDuration / (numberOfFlashes*2));
            spriteRend.color = Color.white;
            yield return new WaitForSeconds(iframesDuration / (numberOfFlashes * 2));
        }
        Physics2D.IgnoreLayerCollision(7, 9, false);
    }*/
} 
