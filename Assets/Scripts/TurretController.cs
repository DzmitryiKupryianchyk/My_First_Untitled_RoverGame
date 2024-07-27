using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretController : MonoBehaviour
{
    public float detectionRadius = 20.0f;
    public float viewInDarkRadius = 6.0f;
    public float viewWithLightRadius = 10.0f;
    public float rotationSpeed;
    public Vector3 rotationDirection;
    Quaternion firstRotationPoint;
    float attackRadius;
    public LayerMask targetLayer;
    private GameObject target;
    // Start is called before the first frame update
    void Start()
    {
       firstRotationPoint = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        Rotation();
        FindNearestTarget();
    }
    void FindNearestTarget()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, detectionRadius, targetLayer);

        float nearestDistance = Mathf.Infinity;
        GameObject nearestTarget = null;
        foreach (Collider col in colliders)
        {
            float distance = Vector3.Distance(transform.position, col.transform.position);

            if (col.gameObject.GetComponent<PlayerControll>().headLight.enabled)
            {
                attackRadius = viewWithLightRadius;
            }
            else { attackRadius = viewInDarkRadius; }
            if (distance < attackRadius && distance < nearestDistance)
            {
                nearestDistance = distance;
                nearestTarget = col.gameObject;
            }
        }

        target = nearestTarget;
    }
    public GameObject GetTarget()
    {
        if (target != null)
        {
            return target;
        }
        else
        {
            return null;
        }
    }

    void Rotation() 
    {
        if (target != null)
        {
            Vector3 targetDirection = target.transform.position - transform.position;
            Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
        else
        {
            Quaternion secondRotationPoint = Quaternion.Euler(rotationDirection);
            transform.rotation = Quaternion.Lerp(firstRotationPoint, secondRotationPoint, Mathf.PingPong(Time.time * 0.2f, 1.0f));
        }
    }
}
