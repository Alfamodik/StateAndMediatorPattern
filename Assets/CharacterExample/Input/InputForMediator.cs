//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/CharacterExample/Input/InputForMediator.inputactions
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

public partial class @InputForMediator : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputForMediator()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputForMediator"",
    ""maps"": [
        {
            ""name"": ""Get"",
            ""id"": ""156e23a7-b718-4c5a-a4d7-170b510c438e"",
            ""actions"": [
                {
                    ""name"": ""Health"",
                    ""type"": ""Button"",
                    ""id"": ""ecf87403-d96b-4d13-ad60-68f82dcfe6c3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Expierence"",
                    ""type"": ""Button"",
                    ""id"": ""305b57ac-5ae6-40cb-abf1-6b7536459c60"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b65e2a41-8552-48da-a578-26ea40f230fe"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Health"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4859be46-d5ea-4ac1-9ba9-ae59f0de52b8"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Expierence"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Get
        m_Get = asset.FindActionMap("Get", throwIfNotFound: true);
        m_Get_Health = m_Get.FindAction("Health", throwIfNotFound: true);
        m_Get_Expierence = m_Get.FindAction("Expierence", throwIfNotFound: true);
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

    // Get
    private readonly InputActionMap m_Get;
    private IGetActions m_GetActionsCallbackInterface;
    private readonly InputAction m_Get_Health;
    private readonly InputAction m_Get_Expierence;
    public struct GetActions
    {
        private @InputForMediator m_Wrapper;
        public GetActions(@InputForMediator wrapper) { m_Wrapper = wrapper; }
        public InputAction @Health => m_Wrapper.m_Get_Health;
        public InputAction @Expierence => m_Wrapper.m_Get_Expierence;
        public InputActionMap Get() { return m_Wrapper.m_Get; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GetActions set) { return set.Get(); }
        public void SetCallbacks(IGetActions instance)
        {
            if (m_Wrapper.m_GetActionsCallbackInterface != null)
            {
                @Health.started -= m_Wrapper.m_GetActionsCallbackInterface.OnHealth;
                @Health.performed -= m_Wrapper.m_GetActionsCallbackInterface.OnHealth;
                @Health.canceled -= m_Wrapper.m_GetActionsCallbackInterface.OnHealth;
                @Expierence.started -= m_Wrapper.m_GetActionsCallbackInterface.OnExpierence;
                @Expierence.performed -= m_Wrapper.m_GetActionsCallbackInterface.OnExpierence;
                @Expierence.canceled -= m_Wrapper.m_GetActionsCallbackInterface.OnExpierence;
            }
            m_Wrapper.m_GetActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Health.started += instance.OnHealth;
                @Health.performed += instance.OnHealth;
                @Health.canceled += instance.OnHealth;
                @Expierence.started += instance.OnExpierence;
                @Expierence.performed += instance.OnExpierence;
                @Expierence.canceled += instance.OnExpierence;
            }
        }
    }
    public GetActions @Get => new GetActions(this);
    public interface IGetActions
    {
        void OnHealth(InputAction.CallbackContext context);
        void OnExpierence(InputAction.CallbackContext context);
    }
}
