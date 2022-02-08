using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uScript : MonoBehaviour
    
{
    public GameObject uPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        Vector3 pos = new Vector3(0.4f, -0.97f, 0);
        Instantiate(uPrefab, pos, Quaternion.identity);
        Destroy(gameObject);
    }
}
