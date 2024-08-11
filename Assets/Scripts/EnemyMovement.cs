using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem.HID;

public class EnemyMovement : MonoBehaviour
{
    
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
        randomPoint = target.transform.position;
        if (Vector3.Distance(transform.position, target.transform.position) < 5.0f) 
        {
            randomPoint = transform.position;
        }
        agent.SetDestination(randomPoint);
    }

    void RandomPatrol()
    {
        randomPoint = transform.position + Random.insideUnitSphere * patrolRadius;
        NavMeshHit hit;
        NavMesh.SamplePosition(randomPoint, out hit, patrolRadius, NavMesh.AllAreas);
        agent.SetDestination(hit.position);
    }
}
