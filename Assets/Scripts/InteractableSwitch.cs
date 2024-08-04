using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableSwitch : MonoBehaviour, IInterractable
{
    public bool IsGreen { get; set; }
    [SerializeField] Material redColor;
    [SerializeField] Material greenColor;
    [SerializeField] bool isStartGreen = false;
    [SerializeField] GameObject responsibleElement;
    public MeshRenderer buttonColor;
    // Start is called before the first frame update
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
        responsibleElement.GetComponent<IResponsible>().Respond(IsGreen);
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
