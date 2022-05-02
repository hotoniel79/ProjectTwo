using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveToClick : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private NavMeshAgent Agent;

    [SerializeField] private RaycastHit Hit;

    [SerializeField] private Ray Ray;

    [SerializeField] private Camera Cam;

    [SerializeField] private Collider CheckpointCollider1;

    [SerializeField] private Collider CheckpointCollider2;

    [SerializeField] private Collider CheckpointCollider3;

    [SerializeField] private Collider CheckpointCollider4;

    [SerializeField] private bool FirstCheckpoint;

    [SerializeField] private bool SecondCheckpoint;

    [SerializeField] private bool ThirdCheckpoint;

    [SerializeField] private bool FourthCheckpoint;



    void Start()
    {
        Agent = GetComponent<NavMeshAgent>();

        FirstCheckpoint = false;

        SecondCheckpoint = false;

        ThirdCheckpoint = false;

        FourthCheckpoint = false;

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {
        Ray = Cam.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(Ray, out Hit))
            {
                if(Hit.collider == CheckpointCollider1 && FirstCheckpoint == false)
                {
                    Agent.destination = Hit.point;
                    FirstCheckpoint = true;
                }

                if(Hit.collider == CheckpointCollider2 && FirstCheckpoint && SecondCheckpoint == false)
                {
                    Agent.destination = Hit.point;
                    SecondCheckpoint = true;                  
                }

                if(Hit.collider == CheckpointCollider3 && FirstCheckpoint && SecondCheckpoint && ThirdCheckpoint == false)
                {
                    Agent.destination = Hit.point;
                    ThirdCheckpoint = true;
                }

                if (Hit.collider == CheckpointCollider3 && FirstCheckpoint && SecondCheckpoint && ThirdCheckpoint && FourthCheckpoint == false)
                {
                    Agent.destination = Hit.point;                    
                }

                if(Hit.collider == CheckpointCollider4 && FirstCheckpoint && SecondCheckpoint && ThirdCheckpoint && FourthCheckpoint == false)
                {
                    Agent.destination = Hit.point;
                }


            }
        }
    }
}
