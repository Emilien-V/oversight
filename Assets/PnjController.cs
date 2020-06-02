using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PnjController : MonoBehaviour
{
    public Camera cam;
    public NavMeshAgent agent;
    public Transform transform;
    public Vector3 start;
    public Vector3 end;

    private bool goToEnd = true;

    void Start() 
    {
        agent.SetDestination(end);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(transform.position.x == end.x && transform.position.z == end.z);

        if (transform.position.x == end.x && transform.position.z == end.z) {
            agent.SetDestination(start);
        } 

        if (transform.position.x == start.x && transform.position.z == start.z) {
            agent.SetDestination(end);
        }
    }
}
