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
        rb.gravityScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.CompareTag("Floor")) {
            Debug.Log("Floor Hit");
            gameObject.transform.position = initpos;

        }
        //if (collision.collider.gameObject.CompareTag("Cart"))
        //{
        //   Debug.Log("Cart Hit");

        //}


    }

}
