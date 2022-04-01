using System;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;
using Random = UnityEngine.Random;

public class LlamaMovement : MonoBehaviour
{
    [SerializeField] NavMeshAgent agent;
    [SerializeField] float wanderRadius = 15f;
    
    private void Update()
    {
        if (agent.isOnNavMesh && agent.remainingDistance <= agent.stoppingDistance)
        {
            var destination = Random.insideUnitSphere * wanderRadius + this.transform.position;
            agent.SetDestination(destination);
        }
    }
}
