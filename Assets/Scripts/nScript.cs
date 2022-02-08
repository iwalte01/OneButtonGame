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
        Debug.Log("Mouse was clicked");
        counter++;
        if(counter == 1)
        {
            //put n in ONE
            Vector3 pos = new Vector3(0, 0, 0);
            Instantiate(nPrefab, pos, Quaternion.identity);
        }
    }
}
