using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPoint : MonoBehaviour
{
    public Light probe;
    bool isCurrentRespawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        isCurrentRespawnPoint = false;
        SetLight();
    }

    public void SetSpot() 
    {
        RespawnPointsManager.Instance.SetCurrentRespawnPoint(this);
        SetLight();

    }
    public void ChangeStatus(bool isCurrentSpot) 
    {
        isCurrentRespawnPoint = isCurrentSpot;

        SetLight();
    }
    void SetLight() 
    {
        if (isCurrentRespawnPoint) 
        {
            probe.color = Color.green;
        }
        else 
        {
            probe.color = Color.red;
        }
    }
}
