// GENERATED AUTOMATICALLY FROM 'Assets/Settings/GyroControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @GyroControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @GyroControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GyroControls"",
    ""maps"": [
        {
            ""name"": ""Gyro"",
            ""id"": ""129977a4-2c26-4c1f-b245-772918952817"",
            ""actions"": [
                {
                    ""name"": ""Attitude"",
                    ""type"": ""PassThrough"",
                    ""id"": ""38e322ed-17cf-4231-a256-3f91764ff011"",
                    ""expectedControlType"": ""Quaternion"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6936ed08-5903-4926-8ef3-5690f12c6913"",
                    ""path"": ""<AttitudeSensor>/attitude"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attitude"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gyro
        m_Gyro = asset.FindActionMap("Gyro", throwIfNotFound: true);
        m_Gyro_Attitude = m_Gyro.FindAction("Attitude", throwIfNotFound: true);
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

    // Gyro
    private readonly InputActionMap m_Gyro;
    private IGyroActions m_GyroActionsCallbackInterface;
    private readonly InputAction m_Gyro_Attitude;
    public struct GyroActions
    {
        private @GyroControls m_Wrapper;
        public GyroActions(@GyroControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Attitude => m_Wrapper.m_Gyro_Attitude;
        public InputActionMap Get() { return m_Wrapper.m_Gyro; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GyroActions set) { return set.Get(); }
        public void SetCallbacks(IGyroActions instance)
        {
            if (m_Wrapper.m_GyroActionsCallbackInterface != null)
            {
                @Attitude.started -= m_Wrapper.m_GyroActionsCallbackInterface.OnAttitude;
                @Attitude.performed -= m_Wrapper.m_GyroActionsCallbackInterface.OnAttitude;
                @Attitude.canceled -= m_Wrapper.m_GyroActionsCallbackInterface.OnAttitude;
            }
            m_Wrapper.m_GyroActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Attitude.started += instance.OnAttitude;
                @Attitude.performed += instance.OnAttitude;
                @Attitude.canceled += instance.OnAttitude;
            }
        }
    }
    public GyroActions @Gyro => new GyroActions(this);
    public interface IGyroActions
    {
        void OnAttitude(InputAction.CallbackContext context);
    }
}
