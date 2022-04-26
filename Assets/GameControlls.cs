//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/GameControlls.inputactions
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

public partial class @GameControlls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameControlls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameControlls"",
    ""maps"": [
        {
            ""name"": ""Player1"",
            ""id"": ""7e14347c-7bd8-4913-bc5f-de034a313ed9"",
            ""actions"": [
                {
                    ""name"": ""Action"",
                    ""type"": ""Button"",
                    ""id"": ""8caa6343-5701-4bd7-956d-3ff9eb3b4706"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Blue"",
                    ""type"": ""Button"",
                    ""id"": ""b95ae793-ced6-4fbb-8953-705cc83cd506"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Orange"",
                    ""type"": ""Button"",
                    ""id"": ""5f5b203e-74c0-4658-bccf-0a6711318716"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Green"",
                    ""type"": ""Button"",
                    ""id"": ""410c37a9-7987-4a00-9e0f-56868fc8197f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Yellow"",
                    ""type"": ""Button"",
                    ""id"": ""a3aaeefe-612b-4a84-afed-0d422d918e66"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""17d0f656-83c6-4cfd-8f34-148e4202c225"",
                    ""path"": ""<HID::Logitech Logitech Buzz(tm) Controller V1>/button5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Buzz"",
                    ""action"": ""Blue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""03ebf975-8eea-4375-bbc9-1e95b4fefc12"",
                    ""path"": ""<HID::Logitech Logitech Buzz(tm) Controller V1>/button4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Buzz"",
                    ""action"": ""Orange"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b3de2d48-f355-4a3d-a8b7-c46d40f99429"",
                    ""path"": ""<HID::Logitech Logitech Buzz(tm) Controller V1>/button3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Buzz"",
                    ""action"": ""Green"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7394ee82-269d-4b82-9101-d79927e2caee"",
                    ""path"": ""<HID::Logitech Logitech Buzz(tm) Controller V1>/button2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Buzz"",
                    ""action"": ""Yellow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d49bbd46-b3a8-4f07-9691-6ad9c0b941dc"",
                    ""path"": ""<HID::Logitech Logitech Buzz(tm) Controller V1>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Buzz"",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player2"",
            ""id"": ""bacf5935-06e6-4f5c-bb92-4b384e341d4b"",
            ""actions"": [
                {
                    ""name"": ""Action"",
                    ""type"": ""Button"",
                    ""id"": ""2c1642ff-dd5a-4cf2-9b87-9599b0c1a03a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Blue"",
                    ""type"": ""Button"",
                    ""id"": ""efec8055-4351-4132-a5fb-24eed05d1cfb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Orange"",
                    ""type"": ""Button"",
                    ""id"": ""d07a3936-26ee-46f2-ba24-5699f9bd2fb3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Green"",
                    ""type"": ""Button"",
                    ""id"": ""9d52e2c5-5ffa-4def-b373-ae8c1a48721b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Yellow"",
                    ""type"": ""Button"",
                    ""id"": ""303b4548-3607-4425-8cf5-45a7ae38bef0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b20b5cd6-977d-439f-be7d-d35bdebd22a4"",
                    ""path"": ""<HID::Logitech Logitech Buzz(tm) Controller V1>/button10"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Buzz"",
                    ""action"": ""Blue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a0b74991-3ee7-47da-af82-854627c7adea"",
                    ""path"": ""<HID::Logitech Logitech Buzz(tm) Controller V1>/button9"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Buzz"",
                    ""action"": ""Orange"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7fb6d488-7272-4c5b-b5b3-502ba8e1db63"",
                    ""path"": ""<HID::Logitech Logitech Buzz(tm) Controller V1>/button8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Buzz"",
                    ""action"": ""Green"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1f44d415-5a34-4013-817b-2b13138951fc"",
                    ""path"": ""<HID::Logitech Logitech Buzz(tm) Controller V1>/button7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Buzz"",
                    ""action"": ""Yellow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d57837f7-c16d-404a-80c6-193d0626a166"",
                    ""path"": ""<HID::Logitech Logitech Buzz(tm) Controller V1>/button6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Buzz"",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player3"",
            ""id"": ""ef5dc0d8-61f5-42de-87f3-40d90b6a36e4"",
            ""actions"": [
                {
                    ""name"": ""Action"",
                    ""type"": ""Button"",
                    ""id"": ""f52bb513-1214-4dd6-8528-05356c8ff422"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Blue"",
                    ""type"": ""Button"",
                    ""id"": ""639788c8-3c47-40a6-bda2-7a5125b5ac79"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Orange"",
                    ""type"": ""Button"",
                    ""id"": ""bbb557ec-8a9b-4ec3-ab64-cff47bb706d3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Green"",
                    ""type"": ""Button"",
                    ""id"": ""52a719f8-4e54-4732-97e9-34596f78ee66"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Yellow"",
                    ""type"": ""Button"",
                    ""id"": ""f98cebe5-7289-4f5f-b08e-45479a01cd1d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""15347023-cc6e-476c-9bd9-31d670409c59"",
                    ""path"": ""<HID::Logitech Logitech Buzz(tm) Controller V1>/button15"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Buzz"",
                    ""action"": ""Blue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8cf6463d-2d7c-4d9c-89d2-5df35abd7d5d"",
                    ""path"": ""<HID::Logitech Logitech Buzz(tm) Controller V1>/button14"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Buzz"",
                    ""action"": ""Orange"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1bbb866a-7ea3-4e84-a617-58cc0b5c170a"",
                    ""path"": ""<HID::Logitech Logitech Buzz(tm) Controller V1>/button13"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Buzz"",
                    ""action"": ""Green"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bb44edf2-3b73-4937-b76f-0a75649cd834"",
                    ""path"": ""<HID::Logitech Logitech Buzz(tm) Controller V1>/button12"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Buzz"",
                    ""action"": ""Yellow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""08860dd8-68cd-49f5-9629-5a13827ad909"",
                    ""path"": ""<HID::Logitech Logitech Buzz(tm) Controller V1>/button11"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Buzz"",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player4"",
            ""id"": ""da37a3cf-29fb-4d27-b724-19f55ce7265e"",
            ""actions"": [
                {
                    ""name"": ""Action"",
                    ""type"": ""Button"",
                    ""id"": ""7ff4f085-befe-40d6-baef-3032fd87d387"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Blue"",
                    ""type"": ""Button"",
                    ""id"": ""bb129d0c-e5a4-4721-bbdd-d1aad598af4f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Orange"",
                    ""type"": ""Button"",
                    ""id"": ""d1342647-5fa5-4612-ad9c-7aa3d41c0c4b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Green"",
                    ""type"": ""Button"",
                    ""id"": ""a6f256db-04fa-49c8-aeb7-cbad3b9a04b3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Yellow"",
                    ""type"": ""Button"",
                    ""id"": ""af773f4c-500f-48c8-a7b2-39df056a7880"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""fec8abe3-97b0-405c-8f55-f0a441833e9f"",
                    ""path"": ""<HID::Logitech Logitech Buzz(tm) Controller V1>/button20"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Buzz"",
                    ""action"": ""Blue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7ef6d312-5e33-44cf-8ee1-92c131e4611e"",
                    ""path"": ""<HID::Logitech Logitech Buzz(tm) Controller V1>/button19"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Buzz"",
                    ""action"": ""Orange"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fc1344d7-2b29-4073-8992-2184453130d8"",
                    ""path"": ""<HID::Logitech Logitech Buzz(tm) Controller V1>/button18"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Buzz"",
                    ""action"": ""Green"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a31011f6-5f33-41e9-be73-a1c2d1935eed"",
                    ""path"": ""<HID::Logitech Logitech Buzz(tm) Controller V1>/button17"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Buzz"",
                    ""action"": ""Yellow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""61e22d7c-d456-49cd-a8fb-44d690321a79"",
                    ""path"": ""<HID::Logitech Logitech Buzz(tm) Controller V1>/button16"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Buzz"",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Buzz"",
            ""bindingGroup"": ""Buzz"",
            ""devices"": [
                {
                    ""devicePath"": ""<HID::Logitech Logitech Buzz(tm) Controller V1>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player1
        m_Player1 = asset.FindActionMap("Player1", throwIfNotFound: true);
        m_Player1_Action = m_Player1.FindAction("Action", throwIfNotFound: true);
        m_Player1_Blue = m_Player1.FindAction("Blue", throwIfNotFound: true);
        m_Player1_Orange = m_Player1.FindAction("Orange", throwIfNotFound: true);
        m_Player1_Green = m_Player1.FindAction("Green", throwIfNotFound: true);
        m_Player1_Yellow = m_Player1.FindAction("Yellow", throwIfNotFound: true);
        // Player2
        m_Player2 = asset.FindActionMap("Player2", throwIfNotFound: true);
        m_Player2_Action = m_Player2.FindAction("Action", throwIfNotFound: true);
        m_Player2_Blue = m_Player2.FindAction("Blue", throwIfNotFound: true);
        m_Player2_Orange = m_Player2.FindAction("Orange", throwIfNotFound: true);
        m_Player2_Green = m_Player2.FindAction("Green", throwIfNotFound: true);
        m_Player2_Yellow = m_Player2.FindAction("Yellow", throwIfNotFound: true);
        // Player3
        m_Player3 = asset.FindActionMap("Player3", throwIfNotFound: true);
        m_Player3_Action = m_Player3.FindAction("Action", throwIfNotFound: true);
        m_Player3_Blue = m_Player3.FindAction("Blue", throwIfNotFound: true);
        m_Player3_Orange = m_Player3.FindAction("Orange", throwIfNotFound: true);
        m_Player3_Green = m_Player3.FindAction("Green", throwIfNotFound: true);
        m_Player3_Yellow = m_Player3.FindAction("Yellow", throwIfNotFound: true);
        // Player4
        m_Player4 = asset.FindActionMap("Player4", throwIfNotFound: true);
        m_Player4_Action = m_Player4.FindAction("Action", throwIfNotFound: true);
        m_Player4_Blue = m_Player4.FindAction("Blue", throwIfNotFound: true);
        m_Player4_Orange = m_Player4.FindAction("Orange", throwIfNotFound: true);
        m_Player4_Green = m_Player4.FindAction("Green", throwIfNotFound: true);
        m_Player4_Yellow = m_Player4.FindAction("Yellow", throwIfNotFound: true);
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

    // Player1
    private readonly InputActionMap m_Player1;
    private IPlayer1Actions m_Player1ActionsCallbackInterface;
    private readonly InputAction m_Player1_Action;
    private readonly InputAction m_Player1_Blue;
    private readonly InputAction m_Player1_Orange;
    private readonly InputAction m_Player1_Green;
    private readonly InputAction m_Player1_Yellow;
    public struct Player1Actions
    {
        private @GameControlls m_Wrapper;
        public Player1Actions(@GameControlls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Action => m_Wrapper.m_Player1_Action;
        public InputAction @Blue => m_Wrapper.m_Player1_Blue;
        public InputAction @Orange => m_Wrapper.m_Player1_Orange;
        public InputAction @Green => m_Wrapper.m_Player1_Green;
        public InputAction @Yellow => m_Wrapper.m_Player1_Yellow;
        public InputActionMap Get() { return m_Wrapper.m_Player1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player1Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer1Actions instance)
        {
            if (m_Wrapper.m_Player1ActionsCallbackInterface != null)
            {
                @Action.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnAction;
                @Action.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnAction;
                @Action.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnAction;
                @Blue.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnBlue;
                @Blue.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnBlue;
                @Blue.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnBlue;
                @Orange.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnOrange;
                @Orange.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnOrange;
                @Orange.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnOrange;
                @Green.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnGreen;
                @Green.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnGreen;
                @Green.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnGreen;
                @Yellow.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnYellow;
                @Yellow.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnYellow;
                @Yellow.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnYellow;
            }
            m_Wrapper.m_Player1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Action.started += instance.OnAction;
                @Action.performed += instance.OnAction;
                @Action.canceled += instance.OnAction;
                @Blue.started += instance.OnBlue;
                @Blue.performed += instance.OnBlue;
                @Blue.canceled += instance.OnBlue;
                @Orange.started += instance.OnOrange;
                @Orange.performed += instance.OnOrange;
                @Orange.canceled += instance.OnOrange;
                @Green.started += instance.OnGreen;
                @Green.performed += instance.OnGreen;
                @Green.canceled += instance.OnGreen;
                @Yellow.started += instance.OnYellow;
                @Yellow.performed += instance.OnYellow;
                @Yellow.canceled += instance.OnYellow;
            }
        }
    }
    public Player1Actions @Player1 => new Player1Actions(this);

    // Player2
    private readonly InputActionMap m_Player2;
    private IPlayer2Actions m_Player2ActionsCallbackInterface;
    private readonly InputAction m_Player2_Action;
    private readonly InputAction m_Player2_Blue;
    private readonly InputAction m_Player2_Orange;
    private readonly InputAction m_Player2_Green;
    private readonly InputAction m_Player2_Yellow;
    public struct Player2Actions
    {
        private @GameControlls m_Wrapper;
        public Player2Actions(@GameControlls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Action => m_Wrapper.m_Player2_Action;
        public InputAction @Blue => m_Wrapper.m_Player2_Blue;
        public InputAction @Orange => m_Wrapper.m_Player2_Orange;
        public InputAction @Green => m_Wrapper.m_Player2_Green;
        public InputAction @Yellow => m_Wrapper.m_Player2_Yellow;
        public InputActionMap Get() { return m_Wrapper.m_Player2; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player2Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer2Actions instance)
        {
            if (m_Wrapper.m_Player2ActionsCallbackInterface != null)
            {
                @Action.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnAction;
                @Action.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnAction;
                @Action.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnAction;
                @Blue.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnBlue;
                @Blue.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnBlue;
                @Blue.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnBlue;
                @Orange.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnOrange;
                @Orange.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnOrange;
                @Orange.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnOrange;
                @Green.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnGreen;
                @Green.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnGreen;
                @Green.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnGreen;
                @Yellow.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnYellow;
                @Yellow.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnYellow;
                @Yellow.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnYellow;
            }
            m_Wrapper.m_Player2ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Action.started += instance.OnAction;
                @Action.performed += instance.OnAction;
                @Action.canceled += instance.OnAction;
                @Blue.started += instance.OnBlue;
                @Blue.performed += instance.OnBlue;
                @Blue.canceled += instance.OnBlue;
                @Orange.started += instance.OnOrange;
                @Orange.performed += instance.OnOrange;
                @Orange.canceled += instance.OnOrange;
                @Green.started += instance.OnGreen;
                @Green.performed += instance.OnGreen;
                @Green.canceled += instance.OnGreen;
                @Yellow.started += instance.OnYellow;
                @Yellow.performed += instance.OnYellow;
                @Yellow.canceled += instance.OnYellow;
            }
        }
    }
    public Player2Actions @Player2 => new Player2Actions(this);

    // Player3
    private readonly InputActionMap m_Player3;
    private IPlayer3Actions m_Player3ActionsCallbackInterface;
    private readonly InputAction m_Player3_Action;
    private readonly InputAction m_Player3_Blue;
    private readonly InputAction m_Player3_Orange;
    private readonly InputAction m_Player3_Green;
    private readonly InputAction m_Player3_Yellow;
    public struct Player3Actions
    {
        private @GameControlls m_Wrapper;
        public Player3Actions(@GameControlls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Action => m_Wrapper.m_Player3_Action;
        public InputAction @Blue => m_Wrapper.m_Player3_Blue;
        public InputAction @Orange => m_Wrapper.m_Player3_Orange;
        public InputAction @Green => m_Wrapper.m_Player3_Green;
        public InputAction @Yellow => m_Wrapper.m_Player3_Yellow;
        public InputActionMap Get() { return m_Wrapper.m_Player3; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player3Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer3Actions instance)
        {
            if (m_Wrapper.m_Player3ActionsCallbackInterface != null)
            {
                @Action.started -= m_Wrapper.m_Player3ActionsCallbackInterface.OnAction;
                @Action.performed -= m_Wrapper.m_Player3ActionsCallbackInterface.OnAction;
                @Action.canceled -= m_Wrapper.m_Player3ActionsCallbackInterface.OnAction;
                @Blue.started -= m_Wrapper.m_Player3ActionsCallbackInterface.OnBlue;
                @Blue.performed -= m_Wrapper.m_Player3ActionsCallbackInterface.OnBlue;
                @Blue.canceled -= m_Wrapper.m_Player3ActionsCallbackInterface.OnBlue;
                @Orange.started -= m_Wrapper.m_Player3ActionsCallbackInterface.OnOrange;
                @Orange.performed -= m_Wrapper.m_Player3ActionsCallbackInterface.OnOrange;
                @Orange.canceled -= m_Wrapper.m_Player3ActionsCallbackInterface.OnOrange;
                @Green.started -= m_Wrapper.m_Player3ActionsCallbackInterface.OnGreen;
                @Green.performed -= m_Wrapper.m_Player3ActionsCallbackInterface.OnGreen;
                @Green.canceled -= m_Wrapper.m_Player3ActionsCallbackInterface.OnGreen;
                @Yellow.started -= m_Wrapper.m_Player3ActionsCallbackInterface.OnYellow;
                @Yellow.performed -= m_Wrapper.m_Player3ActionsCallbackInterface.OnYellow;
                @Yellow.canceled -= m_Wrapper.m_Player3ActionsCallbackInterface.OnYellow;
            }
            m_Wrapper.m_Player3ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Action.started += instance.OnAction;
                @Action.performed += instance.OnAction;
                @Action.canceled += instance.OnAction;
                @Blue.started += instance.OnBlue;
                @Blue.performed += instance.OnBlue;
                @Blue.canceled += instance.OnBlue;
                @Orange.started += instance.OnOrange;
                @Orange.performed += instance.OnOrange;
                @Orange.canceled += instance.OnOrange;
                @Green.started += instance.OnGreen;
                @Green.performed += instance.OnGreen;
                @Green.canceled += instance.OnGreen;
                @Yellow.started += instance.OnYellow;
                @Yellow.performed += instance.OnYellow;
                @Yellow.canceled += instance.OnYellow;
            }
        }
    }
    public Player3Actions @Player3 => new Player3Actions(this);

    // Player4
    private readonly InputActionMap m_Player4;
    private IPlayer4Actions m_Player4ActionsCallbackInterface;
    private readonly InputAction m_Player4_Action;
    private readonly InputAction m_Player4_Blue;
    private readonly InputAction m_Player4_Orange;
    private readonly InputAction m_Player4_Green;
    private readonly InputAction m_Player4_Yellow;
    public struct Player4Actions
    {
        private @GameControlls m_Wrapper;
        public Player4Actions(@GameControlls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Action => m_Wrapper.m_Player4_Action;
        public InputAction @Blue => m_Wrapper.m_Player4_Blue;
        public InputAction @Orange => m_Wrapper.m_Player4_Orange;
        public InputAction @Green => m_Wrapper.m_Player4_Green;
        public InputAction @Yellow => m_Wrapper.m_Player4_Yellow;
        public InputActionMap Get() { return m_Wrapper.m_Player4; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player4Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer4Actions instance)
        {
            if (m_Wrapper.m_Player4ActionsCallbackInterface != null)
            {
                @Action.started -= m_Wrapper.m_Player4ActionsCallbackInterface.OnAction;
                @Action.performed -= m_Wrapper.m_Player4ActionsCallbackInterface.OnAction;
                @Action.canceled -= m_Wrapper.m_Player4ActionsCallbackInterface.OnAction;
                @Blue.started -= m_Wrapper.m_Player4ActionsCallbackInterface.OnBlue;
                @Blue.performed -= m_Wrapper.m_Player4ActionsCallbackInterface.OnBlue;
                @Blue.canceled -= m_Wrapper.m_Player4ActionsCallbackInterface.OnBlue;
                @Orange.started -= m_Wrapper.m_Player4ActionsCallbackInterface.OnOrange;
                @Orange.performed -= m_Wrapper.m_Player4ActionsCallbackInterface.OnOrange;
                @Orange.canceled -= m_Wrapper.m_Player4ActionsCallbackInterface.OnOrange;
                @Green.started -= m_Wrapper.m_Player4ActionsCallbackInterface.OnGreen;
                @Green.performed -= m_Wrapper.m_Player4ActionsCallbackInterface.OnGreen;
                @Green.canceled -= m_Wrapper.m_Player4ActionsCallbackInterface.OnGreen;
                @Yellow.started -= m_Wrapper.m_Player4ActionsCallbackInterface.OnYellow;
                @Yellow.performed -= m_Wrapper.m_Player4ActionsCallbackInterface.OnYellow;
                @Yellow.canceled -= m_Wrapper.m_Player4ActionsCallbackInterface.OnYellow;
            }
            m_Wrapper.m_Player4ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Action.started += instance.OnAction;
                @Action.performed += instance.OnAction;
                @Action.canceled += instance.OnAction;
                @Blue.started += instance.OnBlue;
                @Blue.performed += instance.OnBlue;
                @Blue.canceled += instance.OnBlue;
                @Orange.started += instance.OnOrange;
                @Orange.performed += instance.OnOrange;
                @Orange.canceled += instance.OnOrange;
                @Green.started += instance.OnGreen;
                @Green.performed += instance.OnGreen;
                @Green.canceled += instance.OnGreen;
                @Yellow.started += instance.OnYellow;
                @Yellow.performed += instance.OnYellow;
                @Yellow.canceled += instance.OnYellow;
            }
        }
    }
    public Player4Actions @Player4 => new Player4Actions(this);
    private int m_BuzzSchemeIndex = -1;
    public InputControlScheme BuzzScheme
    {
        get
        {
            if (m_BuzzSchemeIndex == -1) m_BuzzSchemeIndex = asset.FindControlSchemeIndex("Buzz");
            return asset.controlSchemes[m_BuzzSchemeIndex];
        }
    }
    public interface IPlayer1Actions
    {
        void OnAction(InputAction.CallbackContext context);
        void OnBlue(InputAction.CallbackContext context);
        void OnOrange(InputAction.CallbackContext context);
        void OnGreen(InputAction.CallbackContext context);
        void OnYellow(InputAction.CallbackContext context);
    }
    public interface IPlayer2Actions
    {
        void OnAction(InputAction.CallbackContext context);
        void OnBlue(InputAction.CallbackContext context);
        void OnOrange(InputAction.CallbackContext context);
        void OnGreen(InputAction.CallbackContext context);
        void OnYellow(InputAction.CallbackContext context);
    }
    public interface IPlayer3Actions
    {
        void OnAction(InputAction.CallbackContext context);
        void OnBlue(InputAction.CallbackContext context);
        void OnOrange(InputAction.CallbackContext context);
        void OnGreen(InputAction.CallbackContext context);
        void OnYellow(InputAction.CallbackContext context);
    }
    public interface IPlayer4Actions
    {
        void OnAction(InputAction.CallbackContext context);
        void OnBlue(InputAction.CallbackContext context);
        void OnOrange(InputAction.CallbackContext context);
        void OnGreen(InputAction.CallbackContext context);
        void OnYellow(InputAction.CallbackContext context);
    }
}
