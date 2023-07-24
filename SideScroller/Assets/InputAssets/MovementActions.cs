//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.1
//     from Assets/InputAssets/MovementActions.inputactions
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

public partial class @MovementActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @MovementActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MovementActions"",
    ""maps"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""id"": ""339844b5-0f2d-4886-9d2d-8b8c7f6ab4d3"",
            ""actions"": [
                {
                    ""name"": ""MoveDirection"",
                    ""type"": ""Value"",
                    ""id"": ""edb8c3f5-c201-454a-a0f0-229b4e1fa9b3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""77548620-e255-4466-849b-84464db8c80e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""62efdeab-07c7-4233-9794-8a3814bdd88f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""JumpHold"",
                    ""type"": ""PassThrough"",
                    ""id"": ""057cffe8-fd07-497a-bb2f-d9f66f0b9ccd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""40baa72c-d95a-40dd-92b2-33a6dfe708dd"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDirection"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""04ba45ed-26a1-4c0b-bb79-2a0c9d8e6354"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""4505a262-66dc-45a5-b62b-5ed624af3219"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7ea90009-98aa-4061-b81d-56f3e10abd5f"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""20a3df1d-fd28-4c48-898a-70d8d72111d5"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""768d43ab-e96d-46bd-96de-05e94efdfe77"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""769fda05-4e55-476d-b937-b660d406f686"",
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
                    ""id"": ""13aa4a05-91a5-408b-8f92-fcecb6904e9f"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""JumpHold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Keyboard&Mouse
        m_KeyboardMouse = asset.FindActionMap("Keyboard&Mouse", throwIfNotFound: true);
        m_KeyboardMouse_MoveDirection = m_KeyboardMouse.FindAction("MoveDirection", throwIfNotFound: true);
        m_KeyboardMouse_Jump = m_KeyboardMouse.FindAction("Jump", throwIfNotFound: true);
        m_KeyboardMouse_Shoot = m_KeyboardMouse.FindAction("Shoot", throwIfNotFound: true);
        m_KeyboardMouse_JumpHold = m_KeyboardMouse.FindAction("JumpHold", throwIfNotFound: true);
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

    // Keyboard&Mouse
    private readonly InputActionMap m_KeyboardMouse;
    private List<IKeyboardMouseActions> m_KeyboardMouseActionsCallbackInterfaces = new List<IKeyboardMouseActions>();
    private readonly InputAction m_KeyboardMouse_MoveDirection;
    private readonly InputAction m_KeyboardMouse_Jump;
    private readonly InputAction m_KeyboardMouse_Shoot;
    private readonly InputAction m_KeyboardMouse_JumpHold;
    public struct KeyboardMouseActions
    {
        private @MovementActions m_Wrapper;
        public KeyboardMouseActions(@MovementActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveDirection => m_Wrapper.m_KeyboardMouse_MoveDirection;
        public InputAction @Jump => m_Wrapper.m_KeyboardMouse_Jump;
        public InputAction @Shoot => m_Wrapper.m_KeyboardMouse_Shoot;
        public InputAction @JumpHold => m_Wrapper.m_KeyboardMouse_JumpHold;
        public InputActionMap Get() { return m_Wrapper.m_KeyboardMouse; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KeyboardMouseActions set) { return set.Get(); }
        public void AddCallbacks(IKeyboardMouseActions instance)
        {
            if (instance == null || m_Wrapper.m_KeyboardMouseActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_KeyboardMouseActionsCallbackInterfaces.Add(instance);
            @MoveDirection.started += instance.OnMoveDirection;
            @MoveDirection.performed += instance.OnMoveDirection;
            @MoveDirection.canceled += instance.OnMoveDirection;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @Shoot.started += instance.OnShoot;
            @Shoot.performed += instance.OnShoot;
            @Shoot.canceled += instance.OnShoot;
            @JumpHold.started += instance.OnJumpHold;
            @JumpHold.performed += instance.OnJumpHold;
            @JumpHold.canceled += instance.OnJumpHold;
        }

        private void UnregisterCallbacks(IKeyboardMouseActions instance)
        {
            @MoveDirection.started -= instance.OnMoveDirection;
            @MoveDirection.performed -= instance.OnMoveDirection;
            @MoveDirection.canceled -= instance.OnMoveDirection;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @Shoot.started -= instance.OnShoot;
            @Shoot.performed -= instance.OnShoot;
            @Shoot.canceled -= instance.OnShoot;
            @JumpHold.started -= instance.OnJumpHold;
            @JumpHold.performed -= instance.OnJumpHold;
            @JumpHold.canceled -= instance.OnJumpHold;
        }

        public void RemoveCallbacks(IKeyboardMouseActions instance)
        {
            if (m_Wrapper.m_KeyboardMouseActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IKeyboardMouseActions instance)
        {
            foreach (var item in m_Wrapper.m_KeyboardMouseActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_KeyboardMouseActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public KeyboardMouseActions @KeyboardMouse => new KeyboardMouseActions(this);
    public interface IKeyboardMouseActions
    {
        void OnMoveDirection(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnJumpHold(InputAction.CallbackContext context);
    }
}
