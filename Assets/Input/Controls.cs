// GENERATED AUTOMATICALLY FROM 'Assets/Input/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""GamePlayControls"",
            ""id"": ""6e5e0592-dd39-44b3-8652-d8c60f3464e0"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""17846658-b7cc-4087-9ce6-00b5bc8cafc4"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""0e9f2e08-734e-4dc3-8c80-65da316779eb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Value"",
                    ""id"": ""01535366-2dd7-46ed-937b-213979114569"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""cd5d35ec-8aa0-4e43-8df8-701cac556908"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""gamepadAim"",
                    ""type"": ""PassThrough"",
                    ""id"": ""cf88a9f0-05fa-4804-bcb1-f1de4c3eb5bb"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""mouseAim"",
                    ""type"": ""PassThrough"",
                    ""id"": ""218fac98-2a6c-41bc-ab8a-771c41ccc571"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Melee"",
                    ""type"": ""Button"",
                    ""id"": ""4d9b5f7f-cac1-422d-aa2a-3d9b303f5c03"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Horizontal Keyboard "",
                    ""id"": ""a8462f6b-f8ee-4959-b388-1e4e64b5486a"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""2f1db292-20e3-4a7c-9659-4085d7ae222f"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""4bd9d98c-6af3-4bf9-8a20-6f27e5352064"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Horizontal Gamepad"",
                    ""id"": ""030de4f8-cdd4-4b70-9f87-356d200876cb"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""2d9cd8a7-2c21-4dc2-a4b0-7a370589ad55"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""e7e0c2c5-b79f-4cd2-b609-dac75c284500"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a43753a5-3fcc-4970-a298-e65fb65f3442"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""850a9347-7142-4cdf-976e-cff8dffe0a76"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5266a311-6bbd-4ffe-87f6-76a1dce69b65"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9d9da4c7-f0ed-411a-bc37-2f92abb55989"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""476dfbb0-b9e9-4c4f-8687-b23c7d20fc96"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""81896c49-3116-497d-8b85-34e972db0b20"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""027e851c-4924-448e-ab20-ab33dd886529"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""gamepadAim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6b0b8f0e-e537-4da2-bddf-f35b1e53a4cc"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""mouseAim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6497aabc-7b81-4de4-8e84-462ca97e64bc"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Melee"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""859b5706-60d2-415c-818c-9fc8380a5b6e"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Melee"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Keyboard and Mouse"",
            ""bindingGroup"": ""Keyboard and Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": true,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // GamePlayControls
        m_GamePlayControls = asset.FindActionMap("GamePlayControls", throwIfNotFound: true);
        m_GamePlayControls_Move = m_GamePlayControls.FindAction("Move", throwIfNotFound: true);
        m_GamePlayControls_Jump = m_GamePlayControls.FindAction("Jump", throwIfNotFound: true);
        m_GamePlayControls_Crouch = m_GamePlayControls.FindAction("Crouch", throwIfNotFound: true);
        m_GamePlayControls_Shoot = m_GamePlayControls.FindAction("Shoot", throwIfNotFound: true);
        m_GamePlayControls_gamepadAim = m_GamePlayControls.FindAction("gamepadAim", throwIfNotFound: true);
        m_GamePlayControls_mouseAim = m_GamePlayControls.FindAction("mouseAim", throwIfNotFound: true);
        m_GamePlayControls_Melee = m_GamePlayControls.FindAction("Melee", throwIfNotFound: true);
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

    // GamePlayControls
    private readonly InputActionMap m_GamePlayControls;
    private IGamePlayControlsActions m_GamePlayControlsActionsCallbackInterface;
    private readonly InputAction m_GamePlayControls_Move;
    private readonly InputAction m_GamePlayControls_Jump;
    private readonly InputAction m_GamePlayControls_Crouch;
    private readonly InputAction m_GamePlayControls_Shoot;
    private readonly InputAction m_GamePlayControls_gamepadAim;
    private readonly InputAction m_GamePlayControls_mouseAim;
    private readonly InputAction m_GamePlayControls_Melee;
    public struct GamePlayControlsActions
    {
        private @Controls m_Wrapper;
        public GamePlayControlsActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_GamePlayControls_Move;
        public InputAction @Jump => m_Wrapper.m_GamePlayControls_Jump;
        public InputAction @Crouch => m_Wrapper.m_GamePlayControls_Crouch;
        public InputAction @Shoot => m_Wrapper.m_GamePlayControls_Shoot;
        public InputAction @gamepadAim => m_Wrapper.m_GamePlayControls_gamepadAim;
        public InputAction @mouseAim => m_Wrapper.m_GamePlayControls_mouseAim;
        public InputAction @Melee => m_Wrapper.m_GamePlayControls_Melee;
        public InputActionMap Get() { return m_Wrapper.m_GamePlayControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GamePlayControlsActions set) { return set.Get(); }
        public void SetCallbacks(IGamePlayControlsActions instance)
        {
            if (m_Wrapper.m_GamePlayControlsActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnJump;
                @Crouch.started -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnCrouch;
                @Shoot.started -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnShoot;
                @gamepadAim.started -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnGamepadAim;
                @gamepadAim.performed -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnGamepadAim;
                @gamepadAim.canceled -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnGamepadAim;
                @mouseAim.started -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnMouseAim;
                @mouseAim.performed -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnMouseAim;
                @mouseAim.canceled -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnMouseAim;
                @Melee.started -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnMelee;
                @Melee.performed -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnMelee;
                @Melee.canceled -= m_Wrapper.m_GamePlayControlsActionsCallbackInterface.OnMelee;
            }
            m_Wrapper.m_GamePlayControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @gamepadAim.started += instance.OnGamepadAim;
                @gamepadAim.performed += instance.OnGamepadAim;
                @gamepadAim.canceled += instance.OnGamepadAim;
                @mouseAim.started += instance.OnMouseAim;
                @mouseAim.performed += instance.OnMouseAim;
                @mouseAim.canceled += instance.OnMouseAim;
                @Melee.started += instance.OnMelee;
                @Melee.performed += instance.OnMelee;
                @Melee.canceled += instance.OnMelee;
            }
        }
    }
    public GamePlayControlsActions @GamePlayControls => new GamePlayControlsActions(this);
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_KeyboardandMouseSchemeIndex = -1;
    public InputControlScheme KeyboardandMouseScheme
    {
        get
        {
            if (m_KeyboardandMouseSchemeIndex == -1) m_KeyboardandMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard and Mouse");
            return asset.controlSchemes[m_KeyboardandMouseSchemeIndex];
        }
    }
    public interface IGamePlayControlsActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnGamepadAim(InputAction.CallbackContext context);
        void OnMouseAim(InputAction.CallbackContext context);
        void OnMelee(InputAction.CallbackContext context);
    }
}
