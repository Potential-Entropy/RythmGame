//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.0
//     from Assets/Features/Input/MainControls.inputactions
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

public partial class @MainControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @MainControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MainControls"",
    ""maps"": [
        {
            ""name"": ""Default"",
            ""id"": ""6960fa8b-a152-49ff-86fd-a73fb8af259a"",
            ""actions"": [
                {
                    ""name"": ""Debug"",
                    ""type"": ""Button"",
                    ""id"": ""f2a7f033-aece-4d18-86ab-825a42fd6521"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""S"",
                    ""type"": ""Button"",
                    ""id"": ""7ec9578c-d3c1-498e-84c0-b9721e9c69e0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""D"",
                    ""type"": ""Button"",
                    ""id"": ""de4c42f6-3fe1-40a0-8b13-e659a7b26e35"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""J"",
                    ""type"": ""Button"",
                    ""id"": ""0bf72283-26f2-4f16-805f-c14a5c6473a8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""K"",
                    ""type"": ""Button"",
                    ""id"": ""2d8e5a51-1471-4f6e-bff4-32c99e13be25"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""556a0f3e-d88f-49c4-8ae6-24713efe4e70"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Debug"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fb000490-c38a-4e33-bc46-c4ce75f18276"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""S"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3f803144-cbf2-406d-bf62-80c761389f9f"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""S"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""82791cf3-c6f5-485f-9da0-80c46d9ba292"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""D"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4f3b3283-9141-4a26-ab53-4a9bed2abb0a"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""D"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f673616b-519f-407b-9739-4cc5724de8bb"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""J"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0b49d7aa-4398-49cd-b74d-9fd4eaae6dbe"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""J"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b09f788a-c7b8-4f78-91bb-5acec08d2533"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""K"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d3f2dfcc-4b86-40a0-9c41-8cf95431b1f2"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""K"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""kbm"",
            ""bindingGroup"": ""kbm"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Default
        m_Default = asset.FindActionMap("Default", throwIfNotFound: true);
        m_Default_Debug = m_Default.FindAction("Debug", throwIfNotFound: true);
        m_Default_S = m_Default.FindAction("S", throwIfNotFound: true);
        m_Default_D = m_Default.FindAction("D", throwIfNotFound: true);
        m_Default_J = m_Default.FindAction("J", throwIfNotFound: true);
        m_Default_K = m_Default.FindAction("K", throwIfNotFound: true);
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

    // Default
    private readonly InputActionMap m_Default;
    private List<IDefaultActions> m_DefaultActionsCallbackInterfaces = new List<IDefaultActions>();
    private readonly InputAction m_Default_Debug;
    private readonly InputAction m_Default_S;
    private readonly InputAction m_Default_D;
    private readonly InputAction m_Default_J;
    private readonly InputAction m_Default_K;
    public struct DefaultActions
    {
        private @MainControls m_Wrapper;
        public DefaultActions(@MainControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Debug => m_Wrapper.m_Default_Debug;
        public InputAction @S => m_Wrapper.m_Default_S;
        public InputAction @D => m_Wrapper.m_Default_D;
        public InputAction @J => m_Wrapper.m_Default_J;
        public InputAction @K => m_Wrapper.m_Default_K;
        public InputActionMap Get() { return m_Wrapper.m_Default; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DefaultActions set) { return set.Get(); }
        public void AddCallbacks(IDefaultActions instance)
        {
            if (instance == null || m_Wrapper.m_DefaultActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_DefaultActionsCallbackInterfaces.Add(instance);
            @Debug.started += instance.OnDebug;
            @Debug.performed += instance.OnDebug;
            @Debug.canceled += instance.OnDebug;
            @S.started += instance.OnS;
            @S.performed += instance.OnS;
            @S.canceled += instance.OnS;
            @D.started += instance.OnD;
            @D.performed += instance.OnD;
            @D.canceled += instance.OnD;
            @J.started += instance.OnJ;
            @J.performed += instance.OnJ;
            @J.canceled += instance.OnJ;
            @K.started += instance.OnK;
            @K.performed += instance.OnK;
            @K.canceled += instance.OnK;
        }

        private void UnregisterCallbacks(IDefaultActions instance)
        {
            @Debug.started -= instance.OnDebug;
            @Debug.performed -= instance.OnDebug;
            @Debug.canceled -= instance.OnDebug;
            @S.started -= instance.OnS;
            @S.performed -= instance.OnS;
            @S.canceled -= instance.OnS;
            @D.started -= instance.OnD;
            @D.performed -= instance.OnD;
            @D.canceled -= instance.OnD;
            @J.started -= instance.OnJ;
            @J.performed -= instance.OnJ;
            @J.canceled -= instance.OnJ;
            @K.started -= instance.OnK;
            @K.performed -= instance.OnK;
            @K.canceled -= instance.OnK;
        }

        public void RemoveCallbacks(IDefaultActions instance)
        {
            if (m_Wrapper.m_DefaultActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IDefaultActions instance)
        {
            foreach (var item in m_Wrapper.m_DefaultActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_DefaultActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public DefaultActions @Default => new DefaultActions(this);
    private int m_kbmSchemeIndex = -1;
    public InputControlScheme kbmScheme
    {
        get
        {
            if (m_kbmSchemeIndex == -1) m_kbmSchemeIndex = asset.FindControlSchemeIndex("kbm");
            return asset.controlSchemes[m_kbmSchemeIndex];
        }
    }
    public interface IDefaultActions
    {
        void OnDebug(InputAction.CallbackContext context);
        void OnS(InputAction.CallbackContext context);
        void OnD(InputAction.CallbackContext context);
        void OnJ(InputAction.CallbackContext context);
        void OnK(InputAction.CallbackContext context);
    }
}
