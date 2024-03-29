//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.2.0
//     from Assets/Samples/XR Interaction Toolkit/2.0.0/Starter Assets/Shoot.inputactions
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

public partial class @Shoot : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Shoot()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Shoot"",
    ""maps"": [
        {
            ""name"": ""New action map"",
            ""id"": ""7f6a84d4-7efe-43ea-9bbf-f3d6cf151dda"",
            ""actions"": [
                {
                    ""name"": ""ShootRight"",
                    ""type"": ""Button"",
                    ""id"": ""2436960c-9f7d-4495-b66b-ae5552b53c6f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ShootLeft"",
                    ""type"": ""Button"",
                    ""id"": ""631d1f63-cf48-4f21-a3da-7db0b1dd7bb8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""72f70890-bbc1-4916-b315-7db6bd7d7090"",
                    ""path"": ""<XRController>{RightHand}/triggerPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8b912306-4b8b-4302-a5e7-4ebbcabb36e2"",
                    ""path"": ""<XRController>{LeftHand}/triggerPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // New action map
        m_Newactionmap = asset.FindActionMap("New action map", throwIfNotFound: true);
        m_Newactionmap_ShootRight = m_Newactionmap.FindAction("ShootRight", throwIfNotFound: true);
        m_Newactionmap_ShootLeft = m_Newactionmap.FindAction("ShootLeft", throwIfNotFound: true);
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

    // New action map
    private readonly InputActionMap m_Newactionmap;
    private INewactionmapActions m_NewactionmapActionsCallbackInterface;
    private readonly InputAction m_Newactionmap_ShootRight;
    private readonly InputAction m_Newactionmap_ShootLeft;
    public struct NewactionmapActions
    {
        private @Shoot m_Wrapper;
        public NewactionmapActions(@Shoot wrapper) { m_Wrapper = wrapper; }
        public InputAction @ShootRight => m_Wrapper.m_Newactionmap_ShootRight;
        public InputAction @ShootLeft => m_Wrapper.m_Newactionmap_ShootLeft;
        public InputActionMap Get() { return m_Wrapper.m_Newactionmap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(NewactionmapActions set) { return set.Get(); }
        public void SetCallbacks(INewactionmapActions instance)
        {
            if (m_Wrapper.m_NewactionmapActionsCallbackInterface != null)
            {
                @ShootRight.started -= m_Wrapper.m_NewactionmapActionsCallbackInterface.OnShootRight;
                @ShootRight.performed -= m_Wrapper.m_NewactionmapActionsCallbackInterface.OnShootRight;
                @ShootRight.canceled -= m_Wrapper.m_NewactionmapActionsCallbackInterface.OnShootRight;
                @ShootLeft.started -= m_Wrapper.m_NewactionmapActionsCallbackInterface.OnShootLeft;
                @ShootLeft.performed -= m_Wrapper.m_NewactionmapActionsCallbackInterface.OnShootLeft;
                @ShootLeft.canceled -= m_Wrapper.m_NewactionmapActionsCallbackInterface.OnShootLeft;
            }
            m_Wrapper.m_NewactionmapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ShootRight.started += instance.OnShootRight;
                @ShootRight.performed += instance.OnShootRight;
                @ShootRight.canceled += instance.OnShootRight;
                @ShootLeft.started += instance.OnShootLeft;
                @ShootLeft.performed += instance.OnShootLeft;
                @ShootLeft.canceled += instance.OnShootLeft;
            }
        }
    }
    public NewactionmapActions @Newactionmap => new NewactionmapActions(this);
    public interface INewactionmapActions
    {
        void OnShootRight(InputAction.CallbackContext context);
        void OnShootLeft(InputAction.CallbackContext context);
    }
}
