// GENERATED AUTOMATICALLY FROM 'Assets/Input.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Input : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Input()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Input"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""5981716d-2cf7-420c-9fca-e33e451f3449"",
            ""actions"": [
                {
                    ""name"": ""MoveX"",
                    ""type"": ""Value"",
                    ""id"": ""de672f26-3c80-4990-a9d6-7e362e4130e5"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveY"",
                    ""type"": ""Value"",
                    ""id"": ""0579bf09-e268-465d-8b4b-53a8e76fb86b"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Start"",
                    ""type"": ""Button"",
                    ""id"": ""78a768cd-4170-4833-bee0-8a5874f94215"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rewind"",
                    ""type"": ""Button"",
                    ""id"": ""a4d7cd75-bb94-43e4-b648-3d1149bf5091"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Hit"",
                    ""type"": ""Button"",
                    ""id"": ""9d0e5a84-d3c4-4aa9-adc8-a175040cdff6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""HitDirection"",
                    ""type"": ""Value"",
                    ""id"": ""50635cd8-0110-4585-b4fe-f02f459b6198"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4c96ba13-1461-4ce0-8cd3-5f56a29e4e36"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""65a627f1-628b-44d6-a355-e956b918f620"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d7c26e22-cb50-4e75-a8e8-891e9924d6f7"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rewind"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b6683e28-10ae-46ae-9072-126e5ffac8e0"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6e5839ba-2278-4e3c-bcbd-fc02e457b1c4"",
                    ""path"": ""<Gamepad>/leftStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ca595981-9aeb-47a7-af81-b3896d7848f0"",
                    ""path"": ""<Gamepad>/rightStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HitDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_MoveX = m_Player.FindAction("MoveX", throwIfNotFound: true);
        m_Player_MoveY = m_Player.FindAction("MoveY", throwIfNotFound: true);
        m_Player_Start = m_Player.FindAction("Start", throwIfNotFound: true);
        m_Player_Rewind = m_Player.FindAction("Rewind", throwIfNotFound: true);
        m_Player_Hit = m_Player.FindAction("Hit", throwIfNotFound: true);
        m_Player_HitDirection = m_Player.FindAction("HitDirection", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_MoveX;
    private readonly InputAction m_Player_MoveY;
    private readonly InputAction m_Player_Start;
    private readonly InputAction m_Player_Rewind;
    private readonly InputAction m_Player_Hit;
    private readonly InputAction m_Player_HitDirection;
    public struct PlayerActions
    {
        private @Input m_Wrapper;
        public PlayerActions(@Input wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveX => m_Wrapper.m_Player_MoveX;
        public InputAction @MoveY => m_Wrapper.m_Player_MoveY;
        public InputAction @Start => m_Wrapper.m_Player_Start;
        public InputAction @Rewind => m_Wrapper.m_Player_Rewind;
        public InputAction @Hit => m_Wrapper.m_Player_Hit;
        public InputAction @HitDirection => m_Wrapper.m_Player_HitDirection;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @MoveX.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveX;
                @MoveX.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveX;
                @MoveX.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveX;
                @MoveY.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveY;
                @MoveY.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveY;
                @MoveY.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveY;
                @Start.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStart;
                @Start.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStart;
                @Start.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStart;
                @Rewind.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRewind;
                @Rewind.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRewind;
                @Rewind.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRewind;
                @Hit.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHit;
                @Hit.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHit;
                @Hit.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHit;
                @HitDirection.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHitDirection;
                @HitDirection.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHitDirection;
                @HitDirection.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHitDirection;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveX.started += instance.OnMoveX;
                @MoveX.performed += instance.OnMoveX;
                @MoveX.canceled += instance.OnMoveX;
                @MoveY.started += instance.OnMoveY;
                @MoveY.performed += instance.OnMoveY;
                @MoveY.canceled += instance.OnMoveY;
                @Start.started += instance.OnStart;
                @Start.performed += instance.OnStart;
                @Start.canceled += instance.OnStart;
                @Rewind.started += instance.OnRewind;
                @Rewind.performed += instance.OnRewind;
                @Rewind.canceled += instance.OnRewind;
                @Hit.started += instance.OnHit;
                @Hit.performed += instance.OnHit;
                @Hit.canceled += instance.OnHit;
                @HitDirection.started += instance.OnHitDirection;
                @HitDirection.performed += instance.OnHitDirection;
                @HitDirection.canceled += instance.OnHitDirection;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnMoveX(InputAction.CallbackContext context);
        void OnMoveY(InputAction.CallbackContext context);
        void OnStart(InputAction.CallbackContext context);
        void OnRewind(InputAction.CallbackContext context);
        void OnHit(InputAction.CallbackContext context);
        void OnHitDirection(InputAction.CallbackContext context);
    }
}
