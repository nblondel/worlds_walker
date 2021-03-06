// GENERATED AUTOMATICALLY FROM 'Assets/Player/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Player movement"",
            ""id"": ""5dbe823c-7fd1-4e8a-9c04-4f49ac1188a1"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""443a235a-3a27-447e-85ab-d900b88ff467"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""62fd9a2a-549d-4402-bb9f-aea35bf3ac1d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ab03d913-8964-44ee-b291-3933ee11b321"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e596b06f-b219-4e32-8c42-49e9f48051d7"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox player controls"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ba700e55-073e-4bbd-a37f-9158e10a9115"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard player controls"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Movement keyboard"",
                    ""id"": ""931ea464-5572-4f9e-bf71-b12865998cd6"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d05be216-1bde-4806-87f7-cbfea91d3f4f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d62b1daa-9486-4c17-acd0-49a5220f01eb"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""35519a0d-82c4-43eb-a3e5-6d38c993f5bc"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""bd6bc63d-2131-40f8-9b3a-acb9a53ef796"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Movement"",
                    ""id"": ""3726c3ff-578c-4324-bfe7-450ca4a0e8be"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e25d007f-286b-4079-85c1-2f6dc8e33265"",
                    ""path"": ""<XInputController>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""20b8e96b-f5be-4327-93b7-b7d9101f395a"",
                    ""path"": ""<XInputController>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e0a44227-d30f-44ad-8ea3-106ff3b1916d"",
                    ""path"": ""<XInputController>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""eabb043b-2bba-49a1-b6cd-65a1c8f7ade0"",
                    ""path"": ""<XInputController>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Rotation keyboard"",
                    ""id"": ""f74a907a-6717-4aef-9e15-41ea38759e1b"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""91d92f5d-ba90-45d4-a41d-c0538d649828"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""4689a77f-02bf-40bb-94df-25ea73fa03f7"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""75027853-f4d4-4c75-aea8-57f9d79215be"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""93a03755-e85b-4e95-8695-bc4b2a7d06f8"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Rotation"",
                    ""id"": ""d8862f81-b832-42d5-9dc5-e3cc24c38fa5"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a5b15544-300e-45c7-9f05-bc4e2856abdd"",
                    ""path"": ""<XInputController>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a361816b-0d92-4801-b813-5d91ae2ba95d"",
                    ""path"": ""<XInputController>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7c524f2c-f628-489a-94cf-10c0537f2d98"",
                    ""path"": ""<XInputController>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""98a6a183-aca7-462c-99a6-c154924b39ef"",
                    ""path"": ""<XInputController>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Xbox player controls"",
            ""bindingGroup"": ""Xbox player controls"",
            ""devices"": [
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Keyboard player controls"",
            ""bindingGroup"": ""Keyboard player controls"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player movement
        m_Playermovement = asset.FindActionMap("Player movement", throwIfNotFound: true);
        m_Playermovement_Jump = m_Playermovement.FindAction("Jump", throwIfNotFound: true);
        m_Playermovement_Move = m_Playermovement.FindAction("Move", throwIfNotFound: true);
        m_Playermovement_Rotate = m_Playermovement.FindAction("Rotate", throwIfNotFound: true);
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

    // Player movement
    private readonly InputActionMap m_Playermovement;
    private IPlayermovementActions m_PlayermovementActionsCallbackInterface;
    private readonly InputAction m_Playermovement_Jump;
    private readonly InputAction m_Playermovement_Move;
    private readonly InputAction m_Playermovement_Rotate;
    public struct PlayermovementActions
    {
        private @PlayerControls m_Wrapper;
        public PlayermovementActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_Playermovement_Jump;
        public InputAction @Move => m_Wrapper.m_Playermovement_Move;
        public InputAction @Rotate => m_Wrapper.m_Playermovement_Rotate;
        public InputActionMap Get() { return m_Wrapper.m_Playermovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayermovementActions set) { return set.Get(); }
        public void SetCallbacks(IPlayermovementActions instance)
        {
            if (m_Wrapper.m_PlayermovementActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_PlayermovementActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayermovementActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayermovementActionsCallbackInterface.OnJump;
                @Move.started -= m_Wrapper.m_PlayermovementActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayermovementActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayermovementActionsCallbackInterface.OnMove;
                @Rotate.started -= m_Wrapper.m_PlayermovementActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_PlayermovementActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_PlayermovementActionsCallbackInterface.OnRotate;
            }
            m_Wrapper.m_PlayermovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
            }
        }
    }
    public PlayermovementActions @Playermovement => new PlayermovementActions(this);
    private int m_XboxplayercontrolsSchemeIndex = -1;
    public InputControlScheme XboxplayercontrolsScheme
    {
        get
        {
            if (m_XboxplayercontrolsSchemeIndex == -1) m_XboxplayercontrolsSchemeIndex = asset.FindControlSchemeIndex("Xbox player controls");
            return asset.controlSchemes[m_XboxplayercontrolsSchemeIndex];
        }
    }
    private int m_KeyboardplayercontrolsSchemeIndex = -1;
    public InputControlScheme KeyboardplayercontrolsScheme
    {
        get
        {
            if (m_KeyboardplayercontrolsSchemeIndex == -1) m_KeyboardplayercontrolsSchemeIndex = asset.FindControlSchemeIndex("Keyboard player controls");
            return asset.controlSchemes[m_KeyboardplayercontrolsSchemeIndex];
        }
    }
    public interface IPlayermovementActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
    }
}
