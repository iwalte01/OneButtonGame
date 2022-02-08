using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Letters : MonoBehaviour
{
    Rigidbody2D rb;
    SpriteRenderer sr;
    float frameTimer;
    Vector2 initpos;

    

    // Start is called before the first frame update
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();

        if (sceneName == "NettoGame")
        {
            rb.gravityScale = 1;
        }
        else if (sceneName == "Endgame")
        {
            rb.gravityScale = 0;
        }
        
        
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
