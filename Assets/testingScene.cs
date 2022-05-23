using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class testingScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       /* if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene(4);
        }*/
    }

    public void veiwMode()
    {
        SceneManager.LoadScene(4);
    }
}
