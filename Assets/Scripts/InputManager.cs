//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scripts/InputManager.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @InputManager: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputManager()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputManager"",
    ""maps"": [
        {
            ""name"": ""CharacterMap"",
            ""id"": ""19e18702-0676-438b-9b51-28ff0db59cad"",
            ""actions"": [
                {
                    ""name"": ""Motion"",
                    ""type"": ""Value"",
                    ""id"": ""ad3f6931-713d-41cc-8cbb-909481d41566"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Interaction"",
                    ""type"": ""Button"",
                    ""id"": ""7d3bc4b2-6de3-42c2-b527-aeb5ab1a4cde"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Light"",
                    ""type"": ""Button"",
                    ""id"": ""6855f4de-702d-4634-ae3f-d0982963468e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""View"",
                    ""type"": ""Button"",
                    ""id"": ""d69c95c6-ff57-4958-b9a1-f3cf766beeee"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""50d38e40-5577-4a3a-8658-a5978ea1e1df"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Forsage"",
                    ""type"": ""Button"",
                    ""id"": ""0cb5b4e1-5208-423b-b27e-07641db2bd0d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""ca762e76-6acf-4d7a-ab34-95bfaca43661"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""ebfcd1ab-e75c-4d8d-95e5-4fdf665c61d6"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Motion"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5c977308-d0bf-47c6-8e97-e37c9ca3fb05"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Motion"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""dbe6e700-bc16-4efd-8599-67704ca66ba5"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Motion"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ca2c9741-3b4b-409d-a109-12f3bade42a9"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Motion"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0004cd67-136b-4787-b3b6-8b235a57fa64"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Motion"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""7dd7bacd-47de-4887-867a-278749c4ed9a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Motion"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ae1ec562-e8f0-425a-8a6f-a26848014c71"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Motion"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""4ea51217-9c36-4152-b2b6-a08faa5a3f20"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Motion"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""65e584d8-e0ae-4693-8d77-a155739c1373"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Motion"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f1da6afb-81f4-49d4-8748-319e54ffc3f7"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Motion"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9a429b04-9a51-4f0f-9ce7-42b8025f1ca0"",
                    ""path"": ""<Keyboard>/#(E)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interaction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""68f2d21c-7e47-4629-b81e-5a383870d66a"",
                    ""path"": ""<Keyboard>/#(F)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Light"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0fc8f40a-a4a1-45a9-a9ea-c8c96183b9ae"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""View"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aa3fce3b-c554-4adb-9555-ed2ddf810020"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e033c498-b264-4580-9a6c-acd19fe9de0b"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Forsage"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3d467a56-d7c2-43e3-bfea-350ae102b996"",
                    ""path"": ""<Keyboard>/#(P)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // CharacterMap
        m_CharacterMap = asset.FindActionMap("CharacterMap", throwIfNotFound: true);
        m_CharacterMap_Motion = m_CharacterMap.FindAction("Motion", throwIfNotFound: true);
        m_CharacterMap_Interaction = m_CharacterMap.FindAction("Interaction", throwIfNotFound: true);
        m_CharacterMap_Light = m_CharacterMap.FindAction("Light", throwIfNotFound: true);
        m_CharacterMap_View = m_CharacterMap.FindAction("View", throwIfNotFound: true);
        m_CharacterMap_Shoot = m_CharacterMap.FindAction("Shoot", throwIfNotFound: true);
        m_CharacterMap_Forsage = m_CharacterMap.FindAction("Forsage", throwIfNotFound: true);
        m_CharacterMap_Pause = m_CharacterMap.FindAction("Pause", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // CharacterMap
    private readonly InputActionMap m_CharacterMap;
    private List<ICharacterMapActions> m_CharacterMapActionsCallbackInterfaces = new List<ICharacterMapActions>();
    private readonly InputAction m_CharacterMap_Motion;
    private readonly InputAction m_CharacterMap_Interaction;
    private readonly InputAction m_CharacterMap_Light;
    private readonly InputAction m_CharacterMap_View;
    private readonly InputAction m_CharacterMap_Shoot;
    private readonly InputAction m_CharacterMap_Forsage;
    private readonly InputAction m_CharacterMap_Pause;
    public struct CharacterMapActions
    {
        private @InputManager m_Wrapper;
        public CharacterMapActions(@InputManager wrapper) { m_Wrapper = wrapper; }
        public InputAction @Motion => m_Wrapper.m_CharacterMap_Motion;
        public InputAction @Interaction => m_Wrapper.m_CharacterMap_Interaction;
        public InputAction @Light => m_Wrapper.m_CharacterMap_Light;
        public InputAction @View => m_Wrapper.m_CharacterMap_View;
        public InputAction @Shoot => m_Wrapper.m_CharacterMap_Shoot;
        public InputAction @Forsage => m_Wrapper.m_CharacterMap_Forsage;
        public InputAction @Pause => m_Wrapper.m_CharacterMap_Pause;
        public InputActionMap Get() { return m_Wrapper.m_CharacterMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CharacterMapActions set) { return set.Get(); }
        public void AddCallbacks(ICharacterMapActions instance)
        {
            if (instance == null || m_Wrapper.m_CharacterMapActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_CharacterMapActionsCallbackInterfaces.Add(instance);
            @Motion.started += instance.OnMotion;
            @Motion.performed += instance.OnMotion;
            @Motion.canceled += instance.OnMotion;
            @Interaction.started += instance.OnInteraction;
            @Interaction.performed += instance.OnInteraction;
            @Interaction.canceled += instance.OnInteraction;
            @Light.started += instance.OnLight;
            @Light.performed += instance.OnLight;
            @Light.canceled += instance.OnLight;
            @View.started += instance.OnView;
            @View.performed += instance.OnView;
            @View.canceled += instance.OnView;
            @Shoot.started += instance.OnShoot;
            @Shoot.performed += instance.OnShoot;
            @Shoot.canceled += instance.OnShoot;
            @Forsage.started += instance.OnForsage;
            @Forsage.performed += instance.OnForsage;
            @Forsage.canceled += instance.OnForsage;
            @Pause.started += instance.OnPause;
            @Pause.performed += instance.OnPause;
            @Pause.canceled += instance.OnPause;
        }

        private void UnregisterCallbacks(ICharacterMapActions instance)
        {
            @Motion.started -= instance.OnMotion;
            @Motion.performed -= instance.OnMotion;
            @Motion.canceled -= instance.OnMotion;
            @Interaction.started -= instance.OnInteraction;
            @Interaction.performed -= instance.OnInteraction;
            @Interaction.canceled -= instance.OnInteraction;
            @Light.started -= instance.OnLight;
            @Light.performed -= instance.OnLight;
            @Light.canceled -= instance.OnLight;
            @View.started -= instance.OnView;
            @View.performed -= instance.OnView;
            @View.canceled -= instance.OnView;
            @Shoot.started -= instance.OnShoot;
            @Shoot.performed -= instance.OnShoot;
            @Shoot.canceled -= instance.OnShoot;
            @Forsage.started -= instance.OnForsage;
            @Forsage.performed -= instance.OnForsage;
            @Forsage.canceled -= instance.OnForsage;
            @Pause.started -= instance.OnPause;
            @Pause.performed -= instance.OnPause;
            @Pause.canceled -= instance.OnPause;
        }

        public void RemoveCallbacks(ICharacterMapActions instance)
        {
            if (m_Wrapper.m_CharacterMapActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ICharacterMapActions instance)
        {
            foreach (var item in m_Wrapper.m_CharacterMapActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_CharacterMapActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public CharacterMapActions @CharacterMap => new CharacterMapActions(this);
    public interface ICharacterMapActions
    {
        void OnMotion(InputAction.CallbackContext context);
        void OnInteraction(InputAction.CallbackContext context);
        void OnLight(InputAction.CallbackContext context);
        void OnView(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnForsage(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
}
