using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bPrefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        Vector3 pos = new Vector3(-1.03f, -1.06f, 0);
        Instantiate(bPrefab, pos, Quaternion.identity);
        Destroy(gameObject);
    }
}
