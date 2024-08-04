using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskToComplete : MonoBehaviour, IResponsible
{
    public Light probe;
    bool isCompleted;
    void Start()
    {
        isCompleted = false;
    }
    public void Respond(bool state)
    {
        if (!isCompleted)
        {
            isCompleted = state;
            SetLight();
            TaskControlManager.Instance.CheckStatus();
        }
        else { return; };
    }
    public bool GetStatus() 
    {
        return isCompleted;
    }
    
    void SetLight()
    {
        if (isCompleted)
        {
            probe.color = Color.green;
        }
        else
        {
            probe.color = Color.red;
        }
    }
}
