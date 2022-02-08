using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nScript : MonoBehaviour
{
    //when mouse button is clicked it gets put into the right spot
    public GameObject nPrefab;

    int counter;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        counter++;
        if(counter == 1)
        {
            //put n in ONE
            Vector3 pos = new Vector3(-4.67f, -1.18f, 0);
            Instantiate(nPrefab, pos, Quaternion.identity);
        }
        else
        {
            //put n in Button
            //destroy n
            Vector3 pos = new Vector3(5.69f, -1.18f, 0);
            Instantiate(nPrefab, pos, Quaternion.identity);

            Destroy(gameObject);
        }
    }
}
