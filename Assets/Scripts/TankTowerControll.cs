using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankTowerControll : MonoBehaviour
{
    public float detectionRadius = 20.0f;
    public float viewInDarkRadius = 6.0f;
    public float viewWithLightRadius = 10.0f;
    public float rotationSpeed;
    Quaternion firstRotationPoint;
    float attackRadius;
    public LayerMask targetLayer;
    private GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        firstRotationPoint = transform.localRotation;
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
            Debug.Log("There is no target!");
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
            transform.localRotation = Quaternion.Lerp(transform.localRotation, firstRotationPoint, rotationSpeed * Time.deltaTime);
        }
    }
}
