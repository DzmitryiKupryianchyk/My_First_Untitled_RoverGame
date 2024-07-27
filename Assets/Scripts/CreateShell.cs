using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateShell : MonoBehaviour
{
    public List<GameObject> shellsPrefabs;
    public List<string> shellsNames;
    public List<int> quantityOfEach;
    private void Awake()
    {
        for (int i = 0; i < shellsPrefabs.Count; i++) 
        {
            ShellPool.Instance.CreateBulletPool(shellsNames[i], shellsPrefabs[i], quantityOfEach[i]);
        } 
    }
  
}
