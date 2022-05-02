using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public void  ChangeToAR()
    {
        SceneManager.LoadScene("AR Scene");
    }
    
    public void ChangeToMenu()
    {
        SceneManager.LoadScene("Menu Scene");
    }

    public void ChangeToViewMode()
    {
        SceneManager.LoadScene("View Scene");
    }
 
}
