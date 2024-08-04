using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShuttleBehavior : MonoBehaviour
{
    bool readyToLaunch;
    float verticalSpeed = 10;
    float windupVerticalSpeed = 0;
    float gravityTurnSpeed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        readyToLaunch = false;
    }
    void Update() 
    {
        if (readyToLaunch) 
        {
            windupVerticalSpeed += Time.deltaTime * 2;
            windupVerticalSpeed = Mathf.Clamp(windupVerticalSpeed, 0, verticalSpeed);

            transform.Translate(Vector3.forward * windupVerticalSpeed * Time.deltaTime);

            transform.Rotate(Vector3.right * gravityTurnSpeed * Time.deltaTime);
        }
    }
    public void TakeOff()
    {
        readyToLaunch=true;
    }
}
