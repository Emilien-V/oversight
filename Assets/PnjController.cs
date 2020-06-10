using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;

public class PnjController : MonoBehaviour
{
    public Camera cam;
    public NavMeshAgent agent;
    public Transform transform;
    public Vector3 start;
    public Vector3 end;
    public ThirdPersonCharacter character;

    private bool goToEnd = true;

    void Start() 
    {
        agent.updateRotation = false;
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

        if (agent.remainingDistance > agent.stoppingDistance) {
            character.Move(agent.desiredVelocity/2, false, false);            
        } else {
            character.Move(Vector3.zero, false, false);
        }
    }
}
