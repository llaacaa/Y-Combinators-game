//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.14.0
//     from Assets/Scripts/Random/ObjectControll.inputactions
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

/// <summary>
/// Provides programmatic access to <see cref="InputActionAsset" />, <see cref="InputActionMap" />, <see cref="InputAction" /> and <see cref="InputControlScheme" /> instances defined in asset "Assets/Scripts/Random/ObjectControll.inputactions".
/// </summary>
/// <remarks>
/// This class is source generated and any manual edits will be discarded if the associated asset is reimported or modified.
/// </remarks>
/// <example>
/// <code>
/// using namespace UnityEngine;
/// using UnityEngine.InputSystem;
///
/// // Example of using an InputActionMap named "Player" from a UnityEngine.MonoBehaviour implementing callback interface.
/// public class Example : MonoBehaviour, MyActions.IPlayerActions
/// {
///     private MyActions_Actions m_Actions;                  // Source code representation of asset.
///     private MyActions_Actions.PlayerActions m_Player;     // Source code representation of action map.
///
///     void Awake()
///     {
///         m_Actions = new MyActions_Actions();              // Create asset object.
///         m_Player = m_Actions.Player;                      // Extract action map object.
///         m_Player.AddCallbacks(this);                      // Register callback interface IPlayerActions.
///     }
///
///     void OnDestroy()
///     {
///         m_Actions.Dispose();                              // Destroy asset object.
///     }
///
///     void OnEnable()
///     {
///         m_Player.Enable();                                // Enable all actions within map.
///     }
///
///     void OnDisable()
///     {
///         m_Player.Disable();                               // Disable all actions within map.
///     }
///
///     #region Interface implementation of MyActions.IPlayerActions
///
///     // Invoked when "Move" action is either started, performed or canceled.
///     public void OnMove(InputAction.CallbackContext context)
///     {
///         Debug.Log($"OnMove: {context.ReadValue&lt;Vector2&gt;()}");
///     }
///
///     // Invoked when "Attack" action is either started, performed or canceled.
///     public void OnAttack(InputAction.CallbackContext context)
///     {
///         Debug.Log($"OnAttack: {context.ReadValue&lt;float&gt;()}");
///     }
///
///     #endregion
/// }
/// </code>
/// </example>
public partial class @ObjectControll: IInputActionCollection2, IDisposable
{
    /// <summary>
    /// Provides access to the underlying asset instance.
    /// </summary>
    public InputActionAsset asset { get; }

    /// <summary>
    /// Constructs a new instance.
    /// </summary>
    public @ObjectControll()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ObjectControll"",
    ""maps"": [
        {
            ""name"": ""Door"",
            ""id"": ""5325eef2-f463-45cf-b4f5-41e009e03596"",
            ""actions"": [
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""0734a262-6d54-4e42-ab45-9dd79ac858d5"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""14b9e034-4995-4e9e-896c-4a93678f64df"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player Swap"",
            ""id"": ""31c10217-95ca-4aa5-98dd-b557571f5fa2"",
            ""actions"": [
                {
                    ""name"": ""Swap"",
                    ""type"": ""Button"",
                    ""id"": ""0982e4a3-76ab-49bd-89c2-4579ba91b11b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7d8334d2-5e42-4be9-8d56-e26f0e552622"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Swap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Door
        m_Door = asset.FindActionMap("Door", throwIfNotFound: true);
        m_Door_Interact = m_Door.FindAction("Interact", throwIfNotFound: true);
        // Player Swap
        m_PlayerSwap = asset.FindActionMap("Player Swap", throwIfNotFound: true);
        m_PlayerSwap_Swap = m_PlayerSwap.FindAction("Swap", throwIfNotFound: true);
    }

    ~@ObjectControll()
    {
        UnityEngine.Debug.Assert(!m_Door.enabled, "This will cause a leak and performance issues, ObjectControll.Door.Disable() has not been called.");
        UnityEngine.Debug.Assert(!m_PlayerSwap.enabled, "This will cause a leak and performance issues, ObjectControll.PlayerSwap.Disable() has not been called.");
    }

    /// <summary>
    /// Destroys this asset and all associated <see cref="InputAction"/> instances.
    /// </summary>
    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.bindingMask" />
    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.devices" />
    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.controlSchemes" />
    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.Contains(InputAction)" />
    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.GetEnumerator()" />
    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    /// <inheritdoc cref="IEnumerable.GetEnumerator()" />
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.Enable()" />
    public void Enable()
    {
        asset.Enable();
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.Disable()" />
    public void Disable()
    {
        asset.Disable();
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.bindings" />
    public IEnumerable<InputBinding> bindings => asset.bindings;

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.FindAction(string, bool)" />
    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    /// <inheritdoc cref="UnityEngine.InputSystem.InputActionAsset.FindBinding(InputBinding, out InputAction)" />
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Door
    private readonly InputActionMap m_Door;
    private List<IDoorActions> m_DoorActionsCallbackInterfaces = new List<IDoorActions>();
    private readonly InputAction m_Door_Interact;
    /// <summary>
    /// Provides access to input actions defined in input action map "Door".
    /// </summary>
    public struct DoorActions
    {
        private @ObjectControll m_Wrapper;

        /// <summary>
        /// Construct a new instance of the input action map wrapper class.
        /// </summary>
        public DoorActions(@ObjectControll wrapper) { m_Wrapper = wrapper; }
        /// <summary>
        /// Provides access to the underlying input action "Door/Interact".
        /// </summary>
        public InputAction @Interact => m_Wrapper.m_Door_Interact;
        /// <summary>
        /// Provides access to the underlying input action map instance.
        /// </summary>
        public InputActionMap Get() { return m_Wrapper.m_Door; }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.Enable()" />
        public void Enable() { Get().Enable(); }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.Disable()" />
        public void Disable() { Get().Disable(); }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.enabled" />
        public bool enabled => Get().enabled;
        /// <summary>
        /// Implicitly converts an <see ref="DoorActions" /> to an <see ref="InputActionMap" /> instance.
        /// </summary>
        public static implicit operator InputActionMap(DoorActions set) { return set.Get(); }
        /// <summary>
        /// Adds <see cref="InputAction.started"/>, <see cref="InputAction.performed"/> and <see cref="InputAction.canceled"/> callbacks provided via <param cref="instance" /> on all input actions contained in this map.
        /// </summary>
        /// <param name="instance">Callback instance.</param>
        /// <remarks>
        /// If <paramref name="instance" /> is <c>null</c> or <paramref name="instance"/> have already been added this method does nothing.
        /// </remarks>
        /// <seealso cref="DoorActions" />
        public void AddCallbacks(IDoorActions instance)
        {
            if (instance == null || m_Wrapper.m_DoorActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_DoorActionsCallbackInterfaces.Add(instance);
            @Interact.started += instance.OnInteract;
            @Interact.performed += instance.OnInteract;
            @Interact.canceled += instance.OnInteract;
        }

        /// <summary>
        /// Removes <see cref="InputAction.started"/>, <see cref="InputAction.performed"/> and <see cref="InputAction.canceled"/> callbacks provided via <param cref="instance" /> on all input actions contained in this map.
        /// </summary>
        /// <remarks>
        /// Calling this method when <paramref name="instance" /> have not previously been registered has no side-effects.
        /// </remarks>
        /// <seealso cref="DoorActions" />
        private void UnregisterCallbacks(IDoorActions instance)
        {
            @Interact.started -= instance.OnInteract;
            @Interact.performed -= instance.OnInteract;
            @Interact.canceled -= instance.OnInteract;
        }

        /// <summary>
        /// Unregisters <param cref="instance" /> and unregisters all input action callbacks via <see cref="DoorActions.UnregisterCallbacks(IDoorActions)" />.
        /// </summary>
        /// <seealso cref="DoorActions.UnregisterCallbacks(IDoorActions)" />
        public void RemoveCallbacks(IDoorActions instance)
        {
            if (m_Wrapper.m_DoorActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        /// <summary>
        /// Replaces all existing callback instances and previously registered input action callbacks associated with them with callbacks provided via <param cref="instance" />.
        /// </summary>
        /// <remarks>
        /// If <paramref name="instance" /> is <c>null</c>, calling this method will only unregister all existing callbacks but not register any new callbacks.
        /// </remarks>
        /// <seealso cref="DoorActions.AddCallbacks(IDoorActions)" />
        /// <seealso cref="DoorActions.RemoveCallbacks(IDoorActions)" />
        /// <seealso cref="DoorActions.UnregisterCallbacks(IDoorActions)" />
        public void SetCallbacks(IDoorActions instance)
        {
            foreach (var item in m_Wrapper.m_DoorActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_DoorActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    /// <summary>
    /// Provides a new <see cref="DoorActions" /> instance referencing this action map.
    /// </summary>
    public DoorActions @Door => new DoorActions(this);

    // Player Swap
    private readonly InputActionMap m_PlayerSwap;
    private List<IPlayerSwapActions> m_PlayerSwapActionsCallbackInterfaces = new List<IPlayerSwapActions>();
    private readonly InputAction m_PlayerSwap_Swap;
    /// <summary>
    /// Provides access to input actions defined in input action map "Player Swap".
    /// </summary>
    public struct PlayerSwapActions
    {
        private @ObjectControll m_Wrapper;

        /// <summary>
        /// Construct a new instance of the input action map wrapper class.
        /// </summary>
        public PlayerSwapActions(@ObjectControll wrapper) { m_Wrapper = wrapper; }
        /// <summary>
        /// Provides access to the underlying input action "PlayerSwap/Swap".
        /// </summary>
        public InputAction @Swap => m_Wrapper.m_PlayerSwap_Swap;
        /// <summary>
        /// Provides access to the underlying input action map instance.
        /// </summary>
        public InputActionMap Get() { return m_Wrapper.m_PlayerSwap; }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.Enable()" />
        public void Enable() { Get().Enable(); }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.Disable()" />
        public void Disable() { Get().Disable(); }
        /// <inheritdoc cref="UnityEngine.InputSystem.InputActionMap.enabled" />
        public bool enabled => Get().enabled;
        /// <summary>
        /// Implicitly converts an <see ref="PlayerSwapActions" /> to an <see ref="InputActionMap" /> instance.
        /// </summary>
        public static implicit operator InputActionMap(PlayerSwapActions set) { return set.Get(); }
        /// <summary>
        /// Adds <see cref="InputAction.started"/>, <see cref="InputAction.performed"/> and <see cref="InputAction.canceled"/> callbacks provided via <param cref="instance" /> on all input actions contained in this map.
        /// </summary>
        /// <param name="instance">Callback instance.</param>
        /// <remarks>
        /// If <paramref name="instance" /> is <c>null</c> or <paramref name="instance"/> have already been added this method does nothing.
        /// </remarks>
        /// <seealso cref="PlayerSwapActions" />
        public void AddCallbacks(IPlayerSwapActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerSwapActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerSwapActionsCallbackInterfaces.Add(instance);
            @Swap.started += instance.OnSwap;
            @Swap.performed += instance.OnSwap;
            @Swap.canceled += instance.OnSwap;
        }

        /// <summary>
        /// Removes <see cref="InputAction.started"/>, <see cref="InputAction.performed"/> and <see cref="InputAction.canceled"/> callbacks provided via <param cref="instance" /> on all input actions contained in this map.
        /// </summary>
        /// <remarks>
        /// Calling this method when <paramref name="instance" /> have not previously been registered has no side-effects.
        /// </remarks>
        /// <seealso cref="PlayerSwapActions" />
        private void UnregisterCallbacks(IPlayerSwapActions instance)
        {
            @Swap.started -= instance.OnSwap;
            @Swap.performed -= instance.OnSwap;
            @Swap.canceled -= instance.OnSwap;
        }

        /// <summary>
        /// Unregisters <param cref="instance" /> and unregisters all input action callbacks via <see cref="PlayerSwapActions.UnregisterCallbacks(IPlayerSwapActions)" />.
        /// </summary>
        /// <seealso cref="PlayerSwapActions.UnregisterCallbacks(IPlayerSwapActions)" />
        public void RemoveCallbacks(IPlayerSwapActions instance)
        {
            if (m_Wrapper.m_PlayerSwapActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        /// <summary>
        /// Replaces all existing callback instances and previously registered input action callbacks associated with them with callbacks provided via <param cref="instance" />.
        /// </summary>
        /// <remarks>
        /// If <paramref name="instance" /> is <c>null</c>, calling this method will only unregister all existing callbacks but not register any new callbacks.
        /// </remarks>
        /// <seealso cref="PlayerSwapActions.AddCallbacks(IPlayerSwapActions)" />
        /// <seealso cref="PlayerSwapActions.RemoveCallbacks(IPlayerSwapActions)" />
        /// <seealso cref="PlayerSwapActions.UnregisterCallbacks(IPlayerSwapActions)" />
        public void SetCallbacks(IPlayerSwapActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerSwapActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerSwapActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    /// <summary>
    /// Provides a new <see cref="PlayerSwapActions" /> instance referencing this action map.
    /// </summary>
    public PlayerSwapActions @PlayerSwap => new PlayerSwapActions(this);
    /// <summary>
    /// Interface to implement callback methods for all input action callbacks associated with input actions defined by "Door" which allows adding and removing callbacks.
    /// </summary>
    /// <seealso cref="DoorActions.AddCallbacks(IDoorActions)" />
    /// <seealso cref="DoorActions.RemoveCallbacks(IDoorActions)" />
    public interface IDoorActions
    {
        /// <summary>
        /// Method invoked when associated input action "Interact" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnInteract(InputAction.CallbackContext context);
    }
    /// <summary>
    /// Interface to implement callback methods for all input action callbacks associated with input actions defined by "Player Swap" which allows adding and removing callbacks.
    /// </summary>
    /// <seealso cref="PlayerSwapActions.AddCallbacks(IPlayerSwapActions)" />
    /// <seealso cref="PlayerSwapActions.RemoveCallbacks(IPlayerSwapActions)" />
    public interface IPlayerSwapActions
    {
        /// <summary>
        /// Method invoked when associated input action "Swap" is either <see cref="UnityEngine.InputSystem.InputAction.started" />, <see cref="UnityEngine.InputSystem.InputAction.performed" /> or <see cref="UnityEngine.InputSystem.InputAction.canceled" />.
        /// </summary>
        /// <seealso cref="UnityEngine.InputSystem.InputAction.started" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.performed" />
        /// <seealso cref="UnityEngine.InputSystem.InputAction.canceled" />
        void OnSwap(InputAction.CallbackContext context);
    }
}
