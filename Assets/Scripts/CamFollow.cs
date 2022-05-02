using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Transform Target;
    [SerializeField] private float Smoothing;
    [SerializeField] private Vector3 Offset;


    void Start()
    {
        Offset = transform.position - Target.position;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 TargetCamPos = Target.position + Offset;
        transform.position = Vector3.Lerp(transform.position, TargetCamPos, Smoothing);
    }
}
