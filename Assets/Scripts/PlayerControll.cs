using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    public float moveSpeed;
    public float forsageSpeed;
    public float moveBackwardsSpeed;
    public float interactArea;
    public float turnSpeed;
    float yRotation;
    float gravity = -9.81f;
    bool isForsageMode;

    public GameObject pauseMenuUI;
    private bool isPaused = false;
    public Light headLight;
    public LayerMask allAvailableLayer;
    private InputManager inputManager;
    CharacterController characterController;

    public CharacterController CharacterController { get { return characterController = characterController ?? GetComponent<CharacterController>(); } }

    private void OnEnable()
    {
        inputManager = new InputManager();
        inputManager.CharacterMap.Interaction.performed += Interaction_performed;
        inputManager.CharacterMap.Light.performed += Light_performed;
        inputManager.CharacterMap.Pause.performed += Pause_performed;
        inputManager.Enable();
    }

    

    private void OnDisable()
    {
        inputManager.CharacterMap.Interaction.performed -= Interaction_performed;
        inputManager.CharacterMap.Light.performed -= Light_performed;
        inputManager.CharacterMap.Pause.performed -= Pause_performed;
        inputManager.Disable();
    }
    // Start is called before the first frame update
    void Start()
    {
        pauseMenuUI.SetActive(false);
        UnityEngine.Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = inputManager.CharacterMap.Motion.ReadValue<Vector2>().normalized;
        if (CharacterController != null)
        {
            Move(direction);
            Rotation(direction);
        }
    }

    private void Light_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        if (headLight != null) 
        {
            if (headLight.enabled)
            {
                headLight.enabled = false;
            }
            else
            {
                headLight.enabled = true;
            }
        }
    }

    private void Interaction_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        var colliders = Physics.OverlapSphere(transform.position, interactArea, allAvailableLayer);
        foreach (Collider col in colliders)
        {
            if (col.gameObject.CompareTag("Interactable"))
            {
                col.GetComponent<IInterractable>().Interact();
            }
        }
    }

    private void Pause_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        if (isPaused)
            Resume();
        else
            Pause();
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        UnityEngine.Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1f;
        isPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        UnityEngine.Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0f;
        isPaused = true;
    }

    void Move(Vector2 direction) 
    {
        Vector3 moveDirection = new Vector3(0, gravity, direction.y);
        isForsageMode = inputManager.CharacterMap.Forsage.IsPressed();
        float currentSpeed = isForsageMode ? forsageSpeed : moveSpeed;
        if (direction.y < -0.15)
        {
            currentSpeed = moveBackwardsSpeed;
        }
        
        CharacterController.Move(transform.TransformDirection(moveDirection.x * currentSpeed, moveDirection.y, moveDirection.z * currentSpeed) * Time.deltaTime);
    }
    void Rotation(Vector2 direction)
    {
        if (direction.y < -0.15)
        {
            CharacterController.transform.Rotate(0, -direction.x, 0);
        }
        else
        {
            CharacterController.transform.Rotate(0, direction.x * turnSpeed, 0);
        }
    }
    void OnApplicationPause(bool pauseStatus)
    {
        if (pauseStatus)
        {
            Pause();
        }
    }

    void OnApplicationFocus(bool hasFocus)
    {
        if (!hasFocus)
        {
            Pause();
        }
    }

}
