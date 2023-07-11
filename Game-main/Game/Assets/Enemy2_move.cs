using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2_move : MonoBehaviour
{
    
    public float speed;
    public bool MoveRight;
    
    // Update is called once per frame
    void Update()
    {
        if(MoveRight)//daca se misca la dr
        {
            transform.Translate(0.5f * Time.deltaTime * speed, 0,0);
            transform.localScale = new Vector2(2,2);
        }
        else
        {
            transform.Translate(-0.5f * Time.deltaTime * speed, 0,0);
            transform.localScale = new Vector2(-2, 2);
        }
    }
    void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.CompareTag("turn_Enemy2")) 
        { 
            if(MoveRight)
            {
                MoveRight= false;
            }
            else
            {
                MoveRight = true;
            }
        }
    }
    // var 2
    /*
    [SerializeField] float moveSpeed = 1f;
    Rigidbody2D myRidbody;
    BoxCollider2D myboxCollider;
    
    void Start()
    {
        myRidbody = GetComponent<Rigidbody2D>();
        myboxCollider = GetComponent<BoxCollider2D>();
        
    }

    void Update()
    {
        if(isFacingRight())
        {
            myRidbody.velocity = new Vector2(moveSpeed, 0f);
        }else
        {
            myRidbody.velocity = new Vector2(-moveSpeed, 0f);
        }
    }
    private bool isFacingRight()
    {
        return transform.localScale.x > Mathf.Epsilon;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        transform.localScale = new Vector2(-(Mathf.Sign(myRidbody.velocity.x)),transform.localScale.y);
    }
    */
    /*
    public float speed;
    public float rayDist;
    public bool movingRight;
    public Transform groundDetect;

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        RaycastHit2D groundCheck = Physics2D.Raycast(groundDetect.position, Vector2.down, rayDist);

        if (groundCheck.collider  == false) 
        {
            if(movingRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
            }else
            {
                transform.eulerAngles = new Vector3(0,0,0);
                movingRight = true;
            }
        }
    }*/
}
