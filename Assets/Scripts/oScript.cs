using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject oPrefab;
    int counter = 0;

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
        if (counter == 1)
        {
            //put n in ONE
            Vector3 pos = new Vector3(-5.88f, -1.14f, 0);
            Instantiate(oPrefab, pos, Quaternion.identity);
        }
        else
        {
            //put n in Button
            //destroy n
            Vector3 pos = new Vector3(4.48f, -1.09f, 0);
            Instantiate(oPrefab, pos, Quaternion.identity);

            Destroy(gameObject);
        }
    }
}
