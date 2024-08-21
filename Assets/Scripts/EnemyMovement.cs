using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem.HID;

public class EnemyMovement : MonoBehaviour
{

    public float patrolRadius;
    public float patrolDelay;
    public float targetCheckInterval;
    public TankTowerControll towerControl;

    private NavMeshAgent agent;
    private GameObject target;

    void OnEnable()
    {
        agent = GetComponent<NavMeshAgent>();
        StartCoroutine(PatrolRoutine());
        StartCoroutine(TargetCheckRoutine());
    }
    IEnumerator PatrolRoutine()
    {
        while (true)
        {
            if (target == null)
            {
                RandomPatrol();
            }
            yield return new WaitForSeconds(patrolDelay);
        }
    }

    IEnumerator TargetCheckRoutine()
    {
        while (true)
        {
            SetTarget();
            if (target != null)
            {
                SetDestination();
            }
            yield return new WaitForSeconds(targetCheckInterval);
        }
    }

    void SetTarget()
    {
        target = towerControl.GetTarget();
    }

    void SetDestination()
    {
        if (target != null)
        {
            Vector3 targetPosition = target.transform.position;
            if (Vector3.Distance(transform.position, targetPosition) <= 5.0f)
            {
                targetPosition = transform.position;
            }
            agent.SetDestination(targetPosition);
        }
    }

    void RandomPatrol()
    {
        Vector3 randomPoint = transform.position + Random.insideUnitSphere * patrolRadius;
        NavMeshHit hit;
        if (NavMesh.SamplePosition(randomPoint, out hit, patrolRadius, NavMesh.AllAreas))
        {
            agent.SetDestination(hit.position);
        }
    }
}
