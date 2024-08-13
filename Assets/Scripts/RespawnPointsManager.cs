using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class RespawnPointsManager : ShellSingleton<RespawnPointsManager>
{

    RespawnPoint[] respawnPoints;
    private RespawnPoint currentRespawnPoint;
    private void Awake()
    {
        respawnPoints = FindObjectsOfType<RespawnPoint>();
    }
    void Start()
    {
        currentRespawnPoint = null;
    }
    public void SetCurrentRespawnPoint(RespawnPoint newRespawnPoint)
    {
        foreach (var point in respawnPoints)
        {
            point.ChangeStatus(false);
        }
        currentRespawnPoint = newRespawnPoint;
        currentRespawnPoint.ChangeStatus(true);
    }
    public Transform GetCurrentRespawnPoint() 
    {
        if (currentRespawnPoint == null)
        {
            return null;
        }
        else { return currentRespawnPoint.transform; }
    }
}
