using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewMode : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private float RotationSpeed;

    [SerializeField] private bool Dragging = false;

    [SerializeField] private Rigidbody RB;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonUp(0))
        {
            Dragging = false;
        }
    }

    private void OnMouseDrag()
    {
        Dragging = true;
    }

    private void FixedUpdate()
    {
        if(Dragging)
        {
            float X = Input.GetAxis("Mouse X") * RotationSpeed * Time.fixedDeltaTime;
            float Y = Input.GetAxis("Mouse Y") * RotationSpeed * Time.fixedDeltaTime;

            RB.AddTorque(Vector3.down * X);
            RB.AddTorque(Vector3.right * Y);

        }
    }

}
