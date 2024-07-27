using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomHillsAndRocks : MonoBehaviour
{
    [SerializeField] GameObject[] prefabs;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(prefabs[Random.Range(0, prefabs.Length)], transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
