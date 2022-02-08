using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public float speed;
    public Sprite playerForward;
    public Sprite cartN;
    public Sprite cartE;
    public Sprite cartT;
    public Sprite cartO;

    private Rigidbody2D rb;
    private SpriteRenderer mySpriteRenderer;
    int letterCount = 0;
    //public GameObject crosshair;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(inputX, 0) * speed;
        if(rb.velocity.x > 0)
        {
            mySpriteRenderer.flipX = false;
            mySpriteRenderer.sprite = playerForward;
        }
        if(rb.velocity.x < 0)
        {
            mySpriteRenderer.sprite = playerForward;
            mySpriteRenderer.flipX = true;
        }

        if (letterCount >= 5)
        {
            Debug.Log("Level Complete go to next stage");
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("hit cart");

        if(collision.collider.gameObject.tag == "N")
        {
            letterCount++;
            mySpriteRenderer.sprite = cartN;
        }
        if(collision.collider.gameObject.tag == "E")
        {
            letterCount++;
            mySpriteRenderer.sprite = cartE;
        }
        if(collision.collider.gameObject.tag == "T")
        {
            letterCount++;
            mySpriteRenderer.sprite = cartT;
        }
        if(collision.collider.gameObject.tag == "O")
        {
            letterCount++;
            mySpriteRenderer.sprite = cartO;
        }
        Destroy(collision.gameObject);
    }
}
