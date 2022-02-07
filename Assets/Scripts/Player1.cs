using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public float speed;
    public Sprite playerForward;

    private Rigidbody2D rb;
    private SpriteRenderer mySpriteRenderer;
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

        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPos.z = 0;

        Vector3 origin = transform.position;
        Vector3 direction = mouseWorldPos - origin;

        bool button = Input.GetMouseButton(0);
        if (button)
        {
            RaycastHit2D hit = Physics2D.Raycast(origin, direction, direction.magnitude);
            if (hit && hit.collider.gameObject.tag == "Box")
            {
                Debug.Log("hit the box");
                //letter fall
                //hit.collider.gameObject.GetComponent<Letter>().LetterFall();
            }
        }
    }
}
