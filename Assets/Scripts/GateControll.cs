using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateControll : MonoBehaviour, IResponsible
{
    bool isOpened;
    bool doIteration = false;
    Vector3 closePos;
    Vector3 openPos;
    Vector3 destination;
    float speed = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        closePos = transform.position;
        openPos = transform.position;
        openPos.y -= 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (doIteration) 
        {
            MoveGate();
            if (Vector3.Distance(transform.position, destination) < 0.1) 
            {
                doIteration = false;
            }
        }
    }
    void MoveGate() 
    {
        transform.position = Vector3.MoveTowards(transform.position, destination, Time.deltaTime * speed);
    }

    public void Respond(bool isGreen)
    {
        if (isGreen != isOpened)
        {
            destination = isGreen ? openPos : closePos;
            doIteration = true;
            isOpened = isGreen;
        }
    }
}
