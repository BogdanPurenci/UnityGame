using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldPlayerMovement : MonoBehaviour
{
    [SerializeField]
    public float speed;
    [SerializeField]
    private float jumpforce;
    public float Move;
    [SerializeField]
    Rigidbody2D rb;
    Animator animator;
    private bool facingRight;
    private bool onGround;

    public void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }


    void Update()
    {
        Move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(speed * Move, rb.velocity.y);

        if (Input.GetButtonDown("Jump") && onGround)
        {

            rb.velocity = new Vector2(rb.velocity.x, jumpforce);
        }
        if (facingRight == false && Move < 0)
        {
            Flip();
        }
        else if (facingRight == true && Move > 0)
        {
            Flip();
        }
        void Flip()
        {
            facingRight = !facingRight;
            Vector3 Scaler = transform.localScale;
            Scaler.x *= -1;
            transform.localScale = Scaler;
        }
        animator.SetBool("run", Move != 0);
    }

    private void OnCollisionEnter2D(Collision2D colision)
    {
        if (colision.gameObject.CompareTag("Ground"))
        {
            onGround = true;
        }
    }
    private void OnCollisionExit2D(Collision2D colision)
    {
        if (colision.gameObject.CompareTag("Ground"))
        {
            onGround = false;
        }
    }

}