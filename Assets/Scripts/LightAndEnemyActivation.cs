using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightAndEnemyActivation : MonoBehaviour
{
    public GameObject prefab;
    PlayerControll player;
    public float activationDistance;

    private void Start()
    {
        ///////////////////////////////////////////////////////////////
        ///
        ///               This script is not used!                 ///   
        ///
        //////////////////////////////////////////////////////////////
        player = FindObjectOfType<PlayerControll>(gameObject);
        prefab.SetActive(false);
    }

    private void Update()
    {
        float distance = Vector3.Distance(player.transform.position, transform.position);

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
