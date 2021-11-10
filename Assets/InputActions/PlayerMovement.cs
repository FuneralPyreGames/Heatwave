//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.1.1
//     from Assets/InputActions/PlayerMovement.inputactions
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

public partial class @PlayerMovement : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerMovement()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerMovement"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""9890d8b8-66b8-4898-81d1-6cfeba1de83a"",
            ""actions"": [
                {
                    ""name"": ""GroundMovement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""7a165517-1e52-4018-9109-e26e7f317733"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""b8b953e4-e591-447e-af4a-f341b09b9fa0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LookX"",
                    ""type"": ""PassThrough"",
                    ""id"": ""17c283da-2d2b-4658-a21f-6308d06252dc"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LookY"",
                    ""type"": ""PassThrough"",
                    ""id"": ""7bef0032-3818-49be-b822-64a446f5a02e"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""2b5d4b86-7c92-483a-b096-8bdf8aaccce9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""324046b1-e905-41a8-89ee-a7636eefdc68"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GroundMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b79f2343-9e73-4afe-8ee5-2c640af994b8"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""GroundMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""449a93bb-40a3-4f93-be9f-4a510f66fc5f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""GroundMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""56372946-d476-464f-a125-2a5e36e1a16e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""GroundMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ccb38889-c2a5-4ad1-b202-0bf6fbbde4fa"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""GroundMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left Stick"",
                    ""id"": ""920824a9-3ff1-4121-a963-2dad00ccb76a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GroundMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""43bc019c-1635-4690-9525-5aa462169d79"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""GroundMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""27366fbe-4299-4159-911d-b205beca4b31"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""GroundMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7cf63bee-6732-4ddb-ab16-044ac36ef781"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""GroundMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f9994f9e-b945-4d48-8f24-088fb530e129"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""GroundMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""13514bef-a5f5-45bb-89af-d1add837bb41"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e522452c-656e-474e-9b98-dacba1d27782"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ce33048a-66c5-4a62-b58e-752843f50273"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""LookX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fc9b108e-a0d1-4e72-8cb9-a0e4744bfb31"",
                    ""path"": ""<Gamepad>/rightStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""LookX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6553e874-e6f5-47ef-b4d6-1a7ccf5830e0"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""LookY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b980d9b5-29c9-44ad-80d6-a040023429e8"",
                    ""path"": ""<Gamepad>/rightStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""LookY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""897b4cbd-1de3-4286-bc2d-5eb352dfed67"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a9fe2520-3aa3-4c1f-83f9-115b2dd88c6a"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Gunplay"",
            ""id"": ""8b71bd01-e5dd-4307-be8d-a798d422a0ed"",
            ""actions"": [
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""2e3e91eb-a296-4a33-8ed1-49ad3be11262"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""110309bc-61ef-47e6-9062-d423b4ebb50d"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard And Mouse"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""46c70c31-44b2-4e1f-8252-efdeb63b67c7"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f671fbe3-dee6-4c2a-9e8d-6d0c68d2d77f"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard And Mouse"",
            ""bindingGroup"": ""Keyboard And Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Controller"",
            ""bindingGroup"": ""Controller"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_GroundMovement = m_Movement.FindAction("GroundMovement", throwIfNotFound: true);
        m_Movement_Jump = m_Movement.FindAction("Jump", throwIfNotFound: true);
        m_Movement_LookX = m_Movement.FindAction("LookX", throwIfNotFound: true);
        m_Movement_LookY = m_Movement.FindAction("LookY", throwIfNotFound: true);
        m_Movement_Sprint = m_Movement.FindAction("Sprint", throwIfNotFound: true);
        // Gunplay
        m_Gunplay = asset.FindActionMap("Gunplay", throwIfNotFound: true);
        m_Gunplay_Shoot = m_Gunplay.FindAction("Shoot", throwIfNotFound: true);
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

    // Movement
    private readonly InputActionMap m_Movement;
    private IMovementActions m_MovementActionsCallbackInterface;
    private readonly InputAction m_Movement_GroundMovement;
    private readonly InputAction m_Movement_Jump;
    private readonly InputAction m_Movement_LookX;
    private readonly InputAction m_Movement_LookY;
    private readonly InputAction m_Movement_Sprint;
    public struct MovementActions
    {
        private @PlayerMovement m_Wrapper;
        public MovementActions(@PlayerMovement wrapper) { m_Wrapper = wrapper; }
        public InputAction @GroundMovement => m_Wrapper.m_Movement_GroundMovement;
        public InputAction @Jump => m_Wrapper.m_Movement_Jump;
        public InputAction @LookX => m_Wrapper.m_Movement_LookX;
        public InputAction @LookY => m_Wrapper.m_Movement_LookY;
        public InputAction @Sprint => m_Wrapper.m_Movement_Sprint;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void SetCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterface != null)
            {
                @GroundMovement.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnGroundMovement;
                @GroundMovement.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnGroundMovement;
                @GroundMovement.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnGroundMovement;
                @Jump.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnJump;
                @LookX.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnLookX;
                @LookX.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnLookX;
                @LookX.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnLookX;
                @LookY.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnLookY;
                @LookY.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnLookY;
                @LookY.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnLookY;
                @Sprint.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnSprint;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @GroundMovement.started += instance.OnGroundMovement;
                @GroundMovement.performed += instance.OnGroundMovement;
                @GroundMovement.canceled += instance.OnGroundMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @LookX.started += instance.OnLookX;
                @LookX.performed += instance.OnLookX;
                @LookX.canceled += instance.OnLookX;
                @LookY.started += instance.OnLookY;
                @LookY.performed += instance.OnLookY;
                @LookY.canceled += instance.OnLookY;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
            }
        }
    }
    public MovementActions @Movement => new MovementActions(this);

    // Gunplay
    private readonly InputActionMap m_Gunplay;
    private IGunplayActions m_GunplayActionsCallbackInterface;
    private readonly InputAction m_Gunplay_Shoot;
    public struct GunplayActions
    {
        private @PlayerMovement m_Wrapper;
        public GunplayActions(@PlayerMovement wrapper) { m_Wrapper = wrapper; }
        public InputAction @Shoot => m_Wrapper.m_Gunplay_Shoot;
        public InputActionMap Get() { return m_Wrapper.m_Gunplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GunplayActions set) { return set.Get(); }
        public void SetCallbacks(IGunplayActions instance)
        {
            if (m_Wrapper.m_GunplayActionsCallbackInterface != null)
            {
                @Shoot.started -= m_Wrapper.m_GunplayActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_GunplayActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_GunplayActionsCallbackInterface.OnShoot;
            }
            m_Wrapper.m_GunplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
            }
        }
    }
    public GunplayActions @Gunplay => new GunplayActions(this);
    private int m_KeyboardAndMouseSchemeIndex = -1;
    public InputControlScheme KeyboardAndMouseScheme
    {
        get
        {
            if (m_KeyboardAndMouseSchemeIndex == -1) m_KeyboardAndMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard And Mouse");
            return asset.controlSchemes[m_KeyboardAndMouseSchemeIndex];
        }
    }
    private int m_ControllerSchemeIndex = -1;
    public InputControlScheme ControllerScheme
    {
        get
        {
            if (m_ControllerSchemeIndex == -1) m_ControllerSchemeIndex = asset.FindControlSchemeIndex("Controller");
            return asset.controlSchemes[m_ControllerSchemeIndex];
        }
    }
    public interface IMovementActions
    {
        void OnGroundMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnLookX(InputAction.CallbackContext context);
        void OnLookY(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
    }
    public interface IGunplayActions
    {
        void OnShoot(InputAction.CallbackContext context);
    }
}
