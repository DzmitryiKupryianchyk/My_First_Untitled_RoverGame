using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPointSwitch : MonoBehaviour, IInterractable
{
    public bool IsGreen { get; set; }
    [SerializeField] Material redColor;
    [SerializeField] Material greenColor;
    [SerializeField] bool isStartGreen = false;
    [SerializeField] RespawnPoint resp;
    public MeshRenderer buttonColor;

    void Start()
    {
        SetState(isStartGreen);
    }

    public void SetState(bool State)
    {
        IsGreen = State;
        if (IsGreen)
        {
            buttonColor.material = greenColor;
        }
        else
        {
            buttonColor.material = redColor;
        }
        
    }
    public void Operate()
    {
        resp.SetSpot();
        if (IsGreen)
        {
            SetState(false);
        }
        else { SetState(true); }

    }
    public void Interact()
    {
        Operate();
    }
}
