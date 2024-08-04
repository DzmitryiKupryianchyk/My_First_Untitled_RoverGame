using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightProbeRotation : MonoBehaviour
{
    public Vector3 rotationDirection = Vector3.up;
    public float rotationSpeed;
    void Update()
    {
        transform.Rotate(rotationDirection * rotationSpeed * Time.deltaTime);
    }
}
