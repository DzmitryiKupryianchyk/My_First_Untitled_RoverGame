using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskControlManager : ShellSingleton<TaskControlManager>
{
    TaskToComplete[] tasks;
    bool isReadyToLaunch;
    private void Awake()
    {
        tasks = FindObjectsOfType<TaskToComplete>();
    }
    // Start is called before the first frame update
    void Start()
    {
        isReadyToLaunch = false;
    }

    public void CheckStatus() 
    {
        foreach (var task in tasks) 
        {
            if (!task.GetStatus())
            {
                isReadyToLaunch = false;
                return;
            }
            else 
            {
                isReadyToLaunch = true;
            }
        }
    }

    public bool IsReadyToLaunch() 
    {
        return isReadyToLaunch;
    }
}