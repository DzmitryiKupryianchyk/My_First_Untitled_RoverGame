using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableSwitch : MonoBehaviour, IInterractable
{
    public bool IsGreen { get; set; }
    [SerializeField] Material redColor;
    [SerializeField] Material greenColor;
    [SerializeField] bool isStartGreen = false;
    [SerializeField] GateControll gateToControll;
    public MeshRenderer buttonColor;
    // Start is called before the first frame update
    void Start()
    {
        SetState(isStartGreen);
    }

    // Update is called once per frame
    void Update()
    {
        
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
        gateToControll.ChangeState(IsGreen);
    }
    public void Operate() 
    {
        if (IsGreen) 
        {
            SetState(false);
        }
        else {SetState(true); }

    }
    public void Interact()
    {
        Operate();
    }
}
