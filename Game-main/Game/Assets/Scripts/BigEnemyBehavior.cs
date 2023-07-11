using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigEnemyBehavior : MonoBehaviour
{
    public float speed = 2.0f;
    public float leftBoundary;
    public float rightBoundary;
    private Vector3 spriteScale;
    private Rigidbody2D rb;
    private int direction = 1;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed * direction, 0);
        spriteScale = transform.localScale;
    }

    void Update()
    {
        if (transform.position.x >= rightBoundary && direction == 1)
        {
            ChangeDirection(-1);
        }
        else if (transform.position.x <= leftBoundary && direction == -1)
        {
            ChangeDirection(1);
        }
    }

    void ChangeDirection(int newDirection)
    {
        direction = newDirection;
        rb.velocity = new Vector2(speed * direction, 0);
        spriteScale.x *= -1;
        transform.localScale = spriteScale;
    }
}
