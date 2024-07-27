using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    //public Transform[] waypoints;
    //public float patrolSpeed = 3f;
    //private NavMeshAgent navMeshAgent;
    //private int currentWaypointIndex = 0;

    //void Start()
    //{
    //    navMeshAgent = GetComponent<NavMeshAgent>();
    //    navMeshAgent.autoBraking = false;

    //    if (waypoints.Length > 0)
    //    {
    //        SetDestination();
    //    }
    //}

    //void Update()
    //{
    //    if (!navMeshAgent.pathPending && navMeshAgent.remainingDistance < 0.5f)
    //    {
    //        SetDestination();
    //    }
    //}

    //void SetDestination()
    //{
    //    if (waypoints.Length == 0)
    //    {
    //        return;
    //    }

    //    navMeshAgent.destination = waypoints[currentWaypointIndex].position;
    //    currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
    //}
    public float patrolRadius = 10f;
    private NavMeshAgent agent;
    private Vector3 randomPoint;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        StartCoroutine(RandomPatrol());
    }

    IEnumerator RandomPatrol()
    {
        while (true)
        {
            randomPoint = transform.position + Random.insideUnitSphere * patrolRadius;
            NavMeshHit hit;
            NavMesh.SamplePosition(randomPoint, out hit, patrolRadius, NavMesh.AllAreas);
            agent.SetDestination(hit.position);

            yield return new WaitForSeconds(Random.Range(5f, 10f));
        }
    }
}
