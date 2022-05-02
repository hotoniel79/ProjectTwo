using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour
{
    [SerializeField] private Color Active;
    
    [SerializeField] private Color Inactive;

    [SerializeField] private GameObject Buttons;

    [SerializeField] private GameObject VideoScreen;




    public void OnTriggerStay(Collider other)
    {
       
            Renderer renderer = GetComponent<Renderer>();
            renderer.material.color = Active;
            Buttons.SetActive(true);
            VideoScreen.SetActive(true);
    }

    public void OnTriggerExit(Collider other)
    {
            Renderer renderer = GetComponent<Renderer>();
            renderer.material.color = Inactive;
            Buttons.SetActive(false);
            VideoScreen.SetActive(false);
       
    }
}
