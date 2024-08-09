using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompassNavigation : MonoBehaviour
{
    Transform target;
    // Start is called before the first frame update
    void Start()
    {
        target = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            transform.LookAt(target);
        }
       
    }
    public void GetTarget(Transform target) 
    {
        this.target = target;
    }

}
