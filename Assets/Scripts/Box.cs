using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer mySpriteRenderer;
    public GameObject letterPrefab;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Explode() {
        Debug.Log("Hit");
        Instantiate(letterPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    void OnMouseDown()
    {
        // this object was clicked - do something
        Debug.Log("hit the box");
        Explode();
        Destroy(this.gameObject);
    }

}
