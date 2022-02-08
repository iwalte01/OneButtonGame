using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ePrefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        Vector3 pos = new Vector3(-3.44f, -1.2f, 0);
        Instantiate(ePrefab, pos, Quaternion.identity);
        Destroy(gameObject);
    }
}
