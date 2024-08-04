using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomHillsAndRocks : MonoBehaviour
{
    public float minScale;
    public float maxScale;
    [SerializeField] GameObject[] prefabs;
    void Start()
    {
        GameObject prefab = prefabs[Random.Range(0, prefabs.Length)];
        GameObject obj = Instantiate(prefab, transform.position, Quaternion.identity);
        float randomScale = Random.Range(minScale, maxScale);
        obj.transform.localScale = new Vector3(randomScale, randomScale, randomScale);
        Destroy(gameObject);
    }
}
