// GENERATED AUTOMATICALLY FROM 'Assets/InputController.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputController : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputController"",
    ""maps"": [
        {
            ""name"": ""BasicGamePad"",
            ""id"": ""845dabc9-fda6-4dec-a6d1-4601dca99576"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""b22c3815-84e0-4ab6-9b9b-c1d40b9700f2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DPadDown"",
                    ""type"": ""Button"",
                    ""id"": ""13ba8871-bc90-4d00-874a-a41f5e6a8dbf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DPadUp"",
                    ""type"": ""Button"",
                    ""id"": ""8197d4fd-a743-4e33-b108-c82b200abd32"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DPadRight"",
                    ""type"": ""Button"",
                    ""id"": ""d771ad80-05f2-40e5-bf2a-e42044a26089"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DPadLeft"",
                    ""type"": ""Button"",
                    ""id"": ""a87edf8b-ee6f-4f4d-979a-5795f5ddb32a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Start"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ccb518e1-cd51-4b5d-9e4e-ff2967d53cb8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""PassThrough"",
                    ""id"": ""7f1f3a3c-1738-431e-b477-3437600ebcf9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightStickPress"",
                    ""type"": ""PassThrough"",
                    ""id"": ""3a3dd17b-1ee6-45d7-a9c9-a6daa907af63"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftStickPress"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c518be3a-16b0-49e4-b0a2-d755be4b6c5c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightTrigger"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a6a369e4-3beb-4f6b-8a78-f92bd432ee81"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftTrigger"",
                    ""type"": ""PassThrough"",
                    ""id"": ""1eead6a3-2587-4b2f-a1e7-144e3773f108"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightShoulder"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c0cd0215-8167-4ec1-b699-5499f7ef6637"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftShoulder"",
                    ""type"": ""PassThrough"",
                    ""id"": ""27b17b7b-c8c4-4ad6-b5bb-fe6a03c73b5b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""West"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d667a8a8-7bc1-41f1-97b5-769673764b0d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""East"",
                    ""type"": ""PassThrough"",
                    ""id"": ""dbd58edb-4270-4ca6-9bdc-f5cc4bf86e1e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""South"",
                    ""type"": ""PassThrough"",
                    ""id"": ""01ce38b1-04f8-4b83-b525-486687d9adff"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""North"",
                    ""type"": ""PassThrough"",
                    ""id"": ""712312af-b90c-4023-ac75-e32f355f5657"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""PassThrough"",
                    ""id"": ""08b81385-2879-4add-ba13-b2b39d858574"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""ea22e6b8-ab88-4478-97fe-bda7e6a306cf"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ee9a2649-ab43-436c-a0c3-58c37d580bdc"",
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
                    ""id"": ""5bf1f1fa-cfaf-4c04-9895-1bb384788615"",
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
                    ""id"": ""61d3070f-1a8f-4a9f-b4a6-3974f7b422ee"",
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
                    ""id"": ""e9c23ba2-d411-47a0-a8c1-d686fb06404d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""5e0d9fba-43f7-42bf-b0a3-b2dc5ea4f18a"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f44a1e15-adca-4cb3-a626-a01352855953"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""403b1488-adeb-4b1f-b479-6d24b0f305eb"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""db2e24a3-fd1b-42c8-a6c2-b1e0385c5cdd"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""North"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""10d0da2a-59de-48b0-931c-39bcb2b93c45"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""South"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3b71b29b-7694-4b2b-a7d1-eb2390eda814"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""South"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bee6dd13-9971-4389-98a1-2916682e6045"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""East"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6f531e9c-7a9e-4787-9130-3c664f91c70c"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""East"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""602fefed-3aee-4e15-9c28-d8b5f81610ac"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""West"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2e3c3621-1cb7-40ed-aef0-6c8164faee20"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftShoulder"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""afca3661-cd01-42d3-b35c-1af95ed29083"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightShoulder"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f600b8cc-9720-4fda-ac64-fda173659d4d"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftTrigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3587ae7e-0601-4d2c-bdbb-1ade5db482a8"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightTrigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3aa6c90a-6853-457f-a0d6-596557f0dd07"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftStickPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""236c238e-6689-4e8c-93eb-56a6e578fe4f"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightStickPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b4f2e3ee-6c18-4ed9-8f02-12f1b28351ce"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""874a10a7-335c-41fd-bae0-6380391467af"",
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
                    ""id"": ""a5cb176a-20e8-4fb3-bd39-bdb38ddac6bb"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DPadLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e09567ca-86f0-4684-94ab-9d979924ebf4"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DPadRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2ebac257-b221-4f61-8d60-90c99304cdd2"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DPadUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8de3cf5a-a7ad-434d-93ac-56a474ddd150"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DPadDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // BasicGamePad
        m_BasicGamePad = asset.FindActionMap("BasicGamePad", throwIfNotFound: true);
        m_BasicGamePad_Move = m_BasicGamePad.FindAction("Move", throwIfNotFound: true);
        m_BasicGamePad_DPadDown = m_BasicGamePad.FindAction("DPadDown", throwIfNotFound: true);
        m_BasicGamePad_DPadUp = m_BasicGamePad.FindAction("DPadUp", throwIfNotFound: true);
        m_BasicGamePad_DPadRight = m_BasicGamePad.FindAction("DPadRight", throwIfNotFound: true);
        m_BasicGamePad_DPadLeft = m_BasicGamePad.FindAction("DPadLeft", throwIfNotFound: true);
        m_BasicGamePad_Start = m_BasicGamePad.FindAction("Start", throwIfNotFound: true);
        m_BasicGamePad_Select = m_BasicGamePad.FindAction("Select", throwIfNotFound: true);
        m_BasicGamePad_RightStickPress = m_BasicGamePad.FindAction("RightStickPress", throwIfNotFound: true);
        m_BasicGamePad_LeftStickPress = m_BasicGamePad.FindAction("LeftStickPress", throwIfNotFound: true);
        m_BasicGamePad_RightTrigger = m_BasicGamePad.FindAction("RightTrigger", throwIfNotFound: true);
        m_BasicGamePad_LeftTrigger = m_BasicGamePad.FindAction("LeftTrigger", throwIfNotFound: true);
        m_BasicGamePad_RightShoulder = m_BasicGamePad.FindAction("RightShoulder", throwIfNotFound: true);
        m_BasicGamePad_LeftShoulder = m_BasicGamePad.FindAction("LeftShoulder", throwIfNotFound: true);
        m_BasicGamePad_West = m_BasicGamePad.FindAction("West", throwIfNotFound: true);
        m_BasicGamePad_East = m_BasicGamePad.FindAction("East", throwIfNotFound: true);
        m_BasicGamePad_South = m_BasicGamePad.FindAction("South", throwIfNotFound: true);
        m_BasicGamePad_North = m_BasicGamePad.FindAction("North", throwIfNotFound: true);
        m_BasicGamePad_Rotate = m_BasicGamePad.FindAction("Rotate", throwIfNotFound: true);
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

    // BasicGamePad
    private readonly InputActionMap m_BasicGamePad;
    private IBasicGamePadActions m_BasicGamePadActionsCallbackInterface;
    private readonly InputAction m_BasicGamePad_Move;
    private readonly InputAction m_BasicGamePad_DPadDown;
    private readonly InputAction m_BasicGamePad_DPadUp;
    private readonly InputAction m_BasicGamePad_DPadRight;
    private readonly InputAction m_BasicGamePad_DPadLeft;
    private readonly InputAction m_BasicGamePad_Start;
    private readonly InputAction m_BasicGamePad_Select;
    private readonly InputAction m_BasicGamePad_RightStickPress;
    private readonly InputAction m_BasicGamePad_LeftStickPress;
    private readonly InputAction m_BasicGamePad_RightTrigger;
    private readonly InputAction m_BasicGamePad_LeftTrigger;
    private readonly InputAction m_BasicGamePad_RightShoulder;
    private readonly InputAction m_BasicGamePad_LeftShoulder;
    private readonly InputAction m_BasicGamePad_West;
    private readonly InputAction m_BasicGamePad_East;
    private readonly InputAction m_BasicGamePad_South;
    private readonly InputAction m_BasicGamePad_North;
    private readonly InputAction m_BasicGamePad_Rotate;
    public struct BasicGamePadActions
    {
        private @InputController m_Wrapper;
        public BasicGamePadActions(@InputController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_BasicGamePad_Move;
        public InputAction @DPadDown => m_Wrapper.m_BasicGamePad_DPadDown;
        public InputAction @DPadUp => m_Wrapper.m_BasicGamePad_DPadUp;
        public InputAction @DPadRight => m_Wrapper.m_BasicGamePad_DPadRight;
        public InputAction @DPadLeft => m_Wrapper.m_BasicGamePad_DPadLeft;
        public InputAction @Start => m_Wrapper.m_BasicGamePad_Start;
        public InputAction @Select => m_Wrapper.m_BasicGamePad_Select;
        public InputAction @RightStickPress => m_Wrapper.m_BasicGamePad_RightStickPress;
        public InputAction @LeftStickPress => m_Wrapper.m_BasicGamePad_LeftStickPress;
        public InputAction @RightTrigger => m_Wrapper.m_BasicGamePad_RightTrigger;
        public InputAction @LeftTrigger => m_Wrapper.m_BasicGamePad_LeftTrigger;
        public InputAction @RightShoulder => m_Wrapper.m_BasicGamePad_RightShoulder;
        public InputAction @LeftShoulder => m_Wrapper.m_BasicGamePad_LeftShoulder;
        public InputAction @West => m_Wrapper.m_BasicGamePad_West;
        public InputAction @East => m_Wrapper.m_BasicGamePad_East;
        public InputAction @South => m_Wrapper.m_BasicGamePad_South;
        public InputAction @North => m_Wrapper.m_BasicGamePad_North;
        public InputAction @Rotate => m_Wrapper.m_BasicGamePad_Rotate;
        public InputActionMap Get() { return m_Wrapper.m_BasicGamePad; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BasicGamePadActions set) { return set.Get(); }
        public void SetCallbacks(IBasicGamePadActions instance)
        {
            if (m_Wrapper.m_BasicGamePadActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnMove;
                @DPadDown.started -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnDPadDown;
                @DPadDown.performed -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnDPadDown;
                @DPadDown.canceled -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnDPadDown;
                @DPadUp.started -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnDPadUp;
                @DPadUp.performed -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnDPadUp;
                @DPadUp.canceled -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnDPadUp;
                @DPadRight.started -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnDPadRight;
                @DPadRight.performed -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnDPadRight;
                @DPadRight.canceled -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnDPadRight;
                @DPadLeft.started -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnDPadLeft;
                @DPadLeft.performed -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnDPadLeft;
                @DPadLeft.canceled -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnDPadLeft;
                @Start.started -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnStart;
                @Start.performed -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnStart;
                @Start.canceled -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnStart;
                @Select.started -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnSelect;
                @RightStickPress.started -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnRightStickPress;
                @RightStickPress.performed -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnRightStickPress;
                @RightStickPress.canceled -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnRightStickPress;
                @LeftStickPress.started -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnLeftStickPress;
                @LeftStickPress.performed -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnLeftStickPress;
                @LeftStickPress.canceled -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnLeftStickPress;
                @RightTrigger.started -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnRightTrigger;
                @RightTrigger.performed -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnRightTrigger;
                @RightTrigger.canceled -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnRightTrigger;
                @LeftTrigger.started -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnLeftTrigger;
                @LeftTrigger.performed -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnLeftTrigger;
                @LeftTrigger.canceled -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnLeftTrigger;
                @RightShoulder.started -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnRightShoulder;
                @RightShoulder.performed -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnRightShoulder;
                @RightShoulder.canceled -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnRightShoulder;
                @LeftShoulder.started -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnLeftShoulder;
                @LeftShoulder.performed -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnLeftShoulder;
                @LeftShoulder.canceled -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnLeftShoulder;
                @West.started -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnWest;
                @West.performed -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnWest;
                @West.canceled -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnWest;
                @East.started -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnEast;
                @East.performed -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnEast;
                @East.canceled -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnEast;
                @South.started -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnSouth;
                @South.performed -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnSouth;
                @South.canceled -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnSouth;
                @North.started -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnNorth;
                @North.performed -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnNorth;
                @North.canceled -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnNorth;
                @Rotate.started -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_BasicGamePadActionsCallbackInterface.OnRotate;
            }
            m_Wrapper.m_BasicGamePadActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @DPadDown.started += instance.OnDPadDown;
                @DPadDown.performed += instance.OnDPadDown;
                @DPadDown.canceled += instance.OnDPadDown;
                @DPadUp.started += instance.OnDPadUp;
                @DPadUp.performed += instance.OnDPadUp;
                @DPadUp.canceled += instance.OnDPadUp;
                @DPadRight.started += instance.OnDPadRight;
                @DPadRight.performed += instance.OnDPadRight;
                @DPadRight.canceled += instance.OnDPadRight;
                @DPadLeft.started += instance.OnDPadLeft;
                @DPadLeft.performed += instance.OnDPadLeft;
                @DPadLeft.canceled += instance.OnDPadLeft;
                @Start.started += instance.OnStart;
                @Start.performed += instance.OnStart;
                @Start.canceled += instance.OnStart;
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
                @RightStickPress.started += instance.OnRightStickPress;
                @RightStickPress.performed += instance.OnRightStickPress;
                @RightStickPress.canceled += instance.OnRightStickPress;
                @LeftStickPress.started += instance.OnLeftStickPress;
                @LeftStickPress.performed += instance.OnLeftStickPress;
                @LeftStickPress.canceled += instance.OnLeftStickPress;
                @RightTrigger.started += instance.OnRightTrigger;
                @RightTrigger.performed += instance.OnRightTrigger;
                @RightTrigger.canceled += instance.OnRightTrigger;
                @LeftTrigger.started += instance.OnLeftTrigger;
                @LeftTrigger.performed += instance.OnLeftTrigger;
                @LeftTrigger.canceled += instance.OnLeftTrigger;
                @RightShoulder.started += instance.OnRightShoulder;
                @RightShoulder.performed += instance.OnRightShoulder;
                @RightShoulder.canceled += instance.OnRightShoulder;
                @LeftShoulder.started += instance.OnLeftShoulder;
                @LeftShoulder.performed += instance.OnLeftShoulder;
                @LeftShoulder.canceled += instance.OnLeftShoulder;
                @West.started += instance.OnWest;
                @West.performed += instance.OnWest;
                @West.canceled += instance.OnWest;
                @East.started += instance.OnEast;
                @East.performed += instance.OnEast;
                @East.canceled += instance.OnEast;
                @South.started += instance.OnSouth;
                @South.performed += instance.OnSouth;
                @South.canceled += instance.OnSouth;
                @North.started += instance.OnNorth;
                @North.performed += instance.OnNorth;
                @North.canceled += instance.OnNorth;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
            }
        }
    }
    public BasicGamePadActions @BasicGamePad => new BasicGamePadActions(this);
    public interface IBasicGamePadActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnDPadDown(InputAction.CallbackContext context);
        void OnDPadUp(InputAction.CallbackContext context);
        void OnDPadRight(InputAction.CallbackContext context);
        void OnDPadLeft(InputAction.CallbackContext context);
        void OnStart(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
        void OnRightStickPress(InputAction.CallbackContext context);
        void OnLeftStickPress(InputAction.CallbackContext context);
        void OnRightTrigger(InputAction.CallbackContext context);
        void OnLeftTrigger(InputAction.CallbackContext context);
        void OnRightShoulder(InputAction.CallbackContext context);
        void OnLeftShoulder(InputAction.CallbackContext context);
        void OnWest(InputAction.CallbackContext context);
        void OnEast(InputAction.CallbackContext context);
        void OnSouth(InputAction.CallbackContext context);
        void OnNorth(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
    }
}
