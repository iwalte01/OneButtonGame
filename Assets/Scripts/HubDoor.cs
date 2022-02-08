using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HubDoor : MonoBehaviour
{
    Rigidbody2D rb;
    //private AssetBundle myLoadedAssetBundle;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       // myLoadedAssetBundle = AssetBundle.LoadFromFile("Assets/AssetBundles/Scenes");
    }

    void OnMouseDown()
    {
        Debug.Log("ABOUT TO CHANGE SCENES");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    // Update is called once per frame
    void Update()
    {
        //if the door is clicked
        
    }
}
