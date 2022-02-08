using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject tPrefab;
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
            Vector3 pos = new Vector3(1.98f, -1.19f, 0);
            Instantiate(tPrefab, pos, Quaternion.identity);
        }
        else
        {
            //put n in Button
            //destroy n
            Vector3 position = new Vector3(3.32f, -1.19f, 0);
            Instantiate(tPrefab, position, Quaternion.identity);

            Destroy(gameObject);
        }
    }
}
