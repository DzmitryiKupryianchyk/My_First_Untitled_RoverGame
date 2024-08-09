using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour
{
    public  GameObject target;
    public Vector3 offset;
    public float smoothTime = 0.3f;
    private Vector3 velocity = Vector3.zero;
    public Camera minimapCamera;

    void Start()
    {
        int lightingLayer = LayerMask.NameToLayer("Light");
        minimapCamera.cullingMask &= ~(1 << lightingLayer);
    }

    void LateUpdate()
    {
        Vector3 targetPosition = target.transform.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
        //Quaternion targetRotation = Quaternion.LookRotation(target.transform.position - transform.position);
        //transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, 5);
    }
}
