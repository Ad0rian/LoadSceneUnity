using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         //SceneManager.LoadScene("Game");
         SceneManager.LoadScene(SceneManager.GetActiveScene().name);
         Cursor.visible= true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
