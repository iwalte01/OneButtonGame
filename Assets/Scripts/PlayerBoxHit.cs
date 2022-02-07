using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBoxHit : MonoBehaviour
{
    //IF player hits box then box disappears and then letter should fall

    private Rigidbody2D rb;
    public GameObject letterPrefab;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPos.z = 0;

        Vector3 origin = transform.position;
        Vector3 direction = mouseWorldPos - origin;

        bool button = Input.GetMouseButton(0);
        if(button)
        {
            RaycastHit2D hit = Physics2D.Raycast(origin, direction, direction.magnitude);
            if(hit && hit.collider.gameObject.tag == "Box")
            {
                //letter fall
                Debug.Log("Hit");
                Instantiate(letterPrefab, transform.position, Quaternion.identity);
                //hit.collider.gameObject.GetComponent<Letter>().LetterFall();
                Destroy(gameObject);
            }
        }
    }
}
