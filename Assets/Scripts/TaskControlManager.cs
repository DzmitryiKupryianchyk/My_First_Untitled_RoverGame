using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskControlManager : ShellSingleton<TaskControlManager>
{
    public Transform ultimateGoal;
    public CompassNavigation compass;
    TaskToComplete[] tasks;
    TaskToComplete currentTask;
    bool isReadyToLaunch;
    int priority = 1;
    private void Awake()
    {
        tasks = FindObjectsOfType<TaskToComplete>();
    }
    // Start is called before the first frame update
    void Start()
    {
        currentTask = null;
        isReadyToLaunch = false;
    }
    private void Update()
    {
        if (currentTask == null || currentTask.GetStatus()) 
        {
            SetCurrentTask();
            if (!isReadyToLaunch)
            {
                SendCurrentTaskTransform();
            }
        }
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
                compass.GetTarget(ultimateGoal);
                isReadyToLaunch = true;
            }
        }
    }

    public bool IsReadyToLaunch() 
    {
        return isReadyToLaunch;
    }
    void SetCurrentTask() 
    {
        foreach (var task in tasks)
        {
            int taskPriority = task.GetPriority();
            if (taskPriority == priority)
            {
                if (!task.GetStatus())
                {
                    currentTask = task;
                    return;
                }
                else
                {
                    priority++;
                }
            }
        }
    }
    public void SendCurrentTaskTransform() 
    {
        compass.GetTarget(currentTask.transform);
    }
}
