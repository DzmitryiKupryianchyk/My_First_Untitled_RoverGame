using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightAndEnemyActivation : MonoBehaviour
{
    public GameObject prefab;
    public Transform player;
    public float activationDistance;

    private void Start()
    {
        prefab.SetActive(false);
    }

    private void Update()
    {
        float distance = Vector3.Distance(player.position, prefab.transform.position);

        if (distance <= activationDistance)
        {
            prefab.SetActive(true);
        }
        else
        {
            prefab.SetActive(false);
        }
    }
}
