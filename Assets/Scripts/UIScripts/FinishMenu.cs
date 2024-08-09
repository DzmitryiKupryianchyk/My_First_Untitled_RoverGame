using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FinishMenu : MonoBehaviour
{
    public TMP_Text text1;
    public TMP_Text text2;
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.Cursor.lockState = CursorLockMode.None;
        Invoke(nameof(ActiveText1), 3f);
        Invoke(nameof(ActiveText2), 5f);
        Invoke(nameof(ActiveButton), 7f);
    }
    void ActiveText1() 
    {
        text1.gameObject.SetActive(true);
    }
    void ActiveText2()
    {
        text2.gameObject.SetActive(true);
    }
    void ActiveButton()
    {
        button.gameObject.SetActive(true);
    }


}
