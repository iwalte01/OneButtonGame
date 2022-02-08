using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endgame : MonoBehaviour

{
    //This should be attached to the box in the endgame scene
    public GameObject nPrefab;

    int nCounter = 0;
    int tCounter = 0;
    int oCounter = 0;
    void Start()
    {
    }
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
            if(hit.collider != null)
                Debug.Log("Hit tag" + hit.collider.gameObject.tag);
            if(hit && hit.collider.gameObject.tag == "N")
            {
                Debug.Log("N is hit");
                nCounter++;
                if(nCounter == 1)
                {
                    //puts N at the origin
                    Vector3 pos = new Vector3(0, 0, 0);
                    Instantiate(nPrefab, pos, Quaternion.identity);
                }else
                {
                    //put an N in the "Button"
                    //Destroy display N
                }
            }
            if (hit && hit.collider.gameObject.tag == "E")
            {
                //put an E in "One"
                //Destroy display E
            }
            if (hit && hit.collider.gameObject.tag == "T")
            {
                tCounter++;
                if (tCounter == 1)
                {
                    //put an t in the "Button"
                    //Destroy display t
                }
                else
                {
                    //put an T in the "Button"
                    //Destroy display T
                }
            }
            if (hit && hit.collider.gameObject.tag == "O")
            {
                oCounter++;
                if (oCounter == 1)
                {
                    //put an O in the "One"
                }
                else
                {
                    //put an O in the "Button"
                    //Destroy display O
                }
            }

        }

        
    }
}
