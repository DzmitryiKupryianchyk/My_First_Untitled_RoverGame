using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabActivatorManager : MonoBehaviour
{
    public GameObject[] objects; 
    public Transform player;
    public float activationRadius;
    public float interval;
    private float timeSinceLastUpdate;

    void Update()
    {
        timeSinceLastUpdate += Time.deltaTime;
        if (timeSinceLastUpdate >= interval)
        {
            foreach (GameObject obj in objects)
            {
                if (obj == null) continue;

                float distanceToPlayer = Vector3.Distance(player.position, obj.transform.position);
                if (distanceToPlayer <= activationRadius)
                {
                    if (!obj.activeInHierarchy)
                    {
                        obj.SetActive(true);
                    }
                }
                else
                {
                    if (obj.activeInHierarchy)
                    {
                        obj.SetActive(false);
                    }
                }
            }
        }
    }
}
