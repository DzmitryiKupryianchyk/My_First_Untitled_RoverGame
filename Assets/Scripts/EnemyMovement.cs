using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem.HID;

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
    public float frequency;
    private float time;
    public float patrolRadius = 10f;
    public TankTowerControll towerControl;
    private NavMeshAgent agent;
    private Vector3 randomPoint;
    GameObject target;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        
    }

    private void Update()
    {
        SetTarget();
        if (target == null)
        {
            time += Time.deltaTime;
            if (time > frequency)
            {
                RandomPatrol();
                time = 0;
            }
            
        }
        else 
        {
            SetDestination();
        }
    }

    void SetTarget() 
    {
        target = towerControl.GetTarget();
    }
    void SetDestination() 
    {
        Vector3 point = target.transform.position;
        if (Vector3.Distance(transform.position, target.transform.position) < 5.0f) 
        {
            randomPoint = transform.position;
        }
        agent.SetDestination(point);
    }

    void RandomPatrol()
    {
        randomPoint = transform.position + Random.insideUnitSphere * patrolRadius;
        NavMeshHit hit;
        NavMesh.SamplePosition(randomPoint, out hit, patrolRadius, NavMesh.AllAreas);
        agent.SetDestination(hit.position);
    }
}
