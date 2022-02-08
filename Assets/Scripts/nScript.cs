using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nScript : MonoBehaviour
{
    //when mouse button is clicked it gets put into the right spot

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
        }
    }
}
