using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letters : MonoBehaviour
{
    Rigidbody2D rb;
    SpriteRenderer sr;
    float frameTimer;
    Vector2 initpos;

    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        frameTimer = 1;
        initpos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        frameTimer -= Time.deltaTime;
        if (frameTimer <= 0)
        {
            LetterFall();

        }
    }

    public void LetterFall() {
        rb.gravityScale = 1;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.CompareTag("Floor")) {
            Debug.Log("Floor Hit");
            gameObject.transform.position = initpos;
            rb.gravityScale = 0;

        }
        //if (collision.collider.gameObject.CompareTag("Cart"))
        //{
        //   Debug.Log("Cart Hit");

        //}


    }

}
