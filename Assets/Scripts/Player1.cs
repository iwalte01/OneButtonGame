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
    public GameObject crosshair;


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

        Vector3 mouseWorldPos = GetMouseWorldPosition();
        UpdateCrosshair(mouseWorldPos);

        Vector2 origin = transform.position;
        Vector2 target = crosshair.transform.position;
        Vector2 direction = target - origin;
        RaycastHit2D hit = Physics2D.Raycast(origin, direction, direction.magnitude);


        if (Input.GetMouseButton(0))
        {
            if (hit.collider != null && hit.collider.gameObject.CompareTag("Box"))
            {
                Debug.Log("hit the box");
                hit.collider.GetComponent<Box>().Explode();
                
                //letter fall
                //hit.collider.gameObject.GetComponent<Letter>().LetterFall();
            }
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        int letterCount = 0;

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
        if(letterCount >= 5)
        {
            Debug.Log("Level Complete go to next stage");
        }
    }

    Vector3 GetMouseWorldPosition()
    {
        // this gets the current mouse position (in screen coordinates) and transforms it into world coordinates
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // the camera is on z = -10, so all screen coordinates are on z = -10. To be on the same plane as the game, we need to set z to 0
        mouseWorldPos.z = 0;

        return mouseWorldPos;
    }

    void UpdateCrosshair(Vector3 newCrosshairPosition)
    {
        crosshair.transform.position = newCrosshairPosition;
    }
}
