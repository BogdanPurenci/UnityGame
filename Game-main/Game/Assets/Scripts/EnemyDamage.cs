using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public int damage;

    public  void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerHealth.TakeDamage(damage);
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<PlayerHealth>().TakeDamage(damage);
        }
    }
}
