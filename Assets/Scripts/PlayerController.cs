// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerController.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerActionController : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerActionController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerController"",
    ""maps"": [
        {
            ""name"": ""Prota"",
            ""id"": ""8a9e472c-d478-453c-8106-92f638f75137"",
            ""actions"": [
                {
                    ""name"": ""MoveX"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2463a9ca-ccb7-4f60-a1bf-69fd1341da4b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveY"",
                    ""type"": ""PassThrough"",
                    ""id"": ""6ac704bc-719d-4a9c-97ae-b09513c7de18"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""068ffd12-d36b-4270-9152-18653765ee4b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Lados"",
                    ""id"": ""1b717784-fde4-41c5-923c-3a35c3ba2dcd"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveX"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""f38ab197-f005-45f9-aa71-cfff6d788149"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""75f31b5e-0814-49a6-9388-8e4d153d8d77"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""951931b6-d33d-4eeb-ac9c-121864787c16"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Delante"",
                    ""id"": ""791282cb-fca2-4b73-b9b3-9deb845ac86f"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveY"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""e647630f-66b1-45fe-911d-b4d57e070897"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""a4b2ef0a-445f-4d0a-ae00-b2cc71b8c71b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Prota
        m_Prota = asset.FindActionMap("Prota", throwIfNotFound: true);
        m_Prota_MoveX = m_Prota.FindAction("MoveX", throwIfNotFound: true);
        m_Prota_MoveY = m_Prota.FindAction("MoveY", throwIfNotFound: true);
        m_Prota_Jump = m_Prota.FindAction("Jump", throwIfNotFound: true);
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

    // Prota
    private readonly InputActionMap m_Prota;
    private IProtaActions m_ProtaActionsCallbackInterface;
    private readonly InputAction m_Prota_MoveX;
    private readonly InputAction m_Prota_MoveY;
    private readonly InputAction m_Prota_Jump;
    public struct ProtaActions
    {
        private @PlayerActionController m_Wrapper;
        public ProtaActions(@PlayerActionController wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveX => m_Wrapper.m_Prota_MoveX;
        public InputAction @MoveY => m_Wrapper.m_Prota_MoveY;
        public InputAction @Jump => m_Wrapper.m_Prota_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Prota; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ProtaActions set) { return set.Get(); }
        public void SetCallbacks(IProtaActions instance)
        {
            if (m_Wrapper.m_ProtaActionsCallbackInterface != null)
            {
                @MoveX.started -= m_Wrapper.m_ProtaActionsCallbackInterface.OnMoveX;
                @MoveX.performed -= m_Wrapper.m_ProtaActionsCallbackInterface.OnMoveX;
                @MoveX.canceled -= m_Wrapper.m_ProtaActionsCallbackInterface.OnMoveX;
                @MoveY.started -= m_Wrapper.m_ProtaActionsCallbackInterface.OnMoveY;
                @MoveY.performed -= m_Wrapper.m_ProtaActionsCallbackInterface.OnMoveY;
                @MoveY.canceled -= m_Wrapper.m_ProtaActionsCallbackInterface.OnMoveY;
                @Jump.started -= m_Wrapper.m_ProtaActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_ProtaActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_ProtaActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_ProtaActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveX.started += instance.OnMoveX;
                @MoveX.performed += instance.OnMoveX;
                @MoveX.canceled += instance.OnMoveX;
                @MoveY.started += instance.OnMoveY;
                @MoveY.performed += instance.OnMoveY;
                @MoveY.canceled += instance.OnMoveY;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public ProtaActions @Prota => new ProtaActions(this);
    public interface IProtaActions
    {
        void OnMoveX(InputAction.CallbackContext context);
        void OnMoveY(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
