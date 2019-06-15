// GENERATED AUTOMATICALLY FROM 'Assets/Player_input.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class NewControls : IInputActionCollection
{
    private InputActionAsset asset;
    public NewControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""New Controls"",
    ""maps"": [
        {
            ""name"": ""player"",
            ""id"": ""02a04ffe-dabe-4bc5-a008-1760fc7eefa7"",
            ""actions"": [
                {
                    ""name"": ""movimentacao"",
                    ""id"": ""d8b0c2fd-8f54-4c11-b94c-89712211db61"",
                    ""expectedControlLayout"": """",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Dpad"",
                    ""id"": ""df5fa4e8-b105-4d63-81ad-05a0c4a78b5d"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movimentacao"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c60bea7f-ce67-45ae-82f5-536c8899a709"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movimentacao"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true,
                    ""modifiers"": """"
                },
                {
                    ""name"": ""down"",
                    ""id"": ""79ea70a1-44ce-481e-b086-95b29091617f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movimentacao"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true,
                    ""modifiers"": """"
                },
                {
                    ""name"": ""left"",
                    ""id"": ""983a0784-1889-4abc-97cd-c485fa5228d3"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movimentacao"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true,
                    ""modifiers"": """"
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c09b019c-ea98-4f9d-876b-3676c482237e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movimentacao"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true,
                    ""modifiers"": """"
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // player
        m_player = asset.GetActionMap("player");
        m_player_movimentacao = m_player.GetAction("movimentacao");
    }

    ~NewControls()
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

    public ReadOnlyArray<InputControlScheme> controlSchemes
    {
        get => asset.controlSchemes;
    }

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

    // player
    private InputActionMap m_player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private InputAction m_player_movimentacao;
    public struct PlayerActions
    {
        private NewControls m_Wrapper;
        public PlayerActions(NewControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @movimentacao { get { return m_Wrapper.m_player_movimentacao; } }
        public InputActionMap Get() { return m_Wrapper.m_player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled { get { return Get().enabled; } }
        public InputActionMap Clone() { return Get().Clone(); }
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                movimentacao.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovimentacao;
                movimentacao.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovimentacao;
                movimentacao.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovimentacao;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                movimentacao.started += instance.OnMovimentacao;
                movimentacao.performed += instance.OnMovimentacao;
                movimentacao.canceled += instance.OnMovimentacao;
            }
        }
    }
    public PlayerActions @player
    {
        get
        {
            return new PlayerActions(this);
        }
    }
    public interface IPlayerActions
    {
        void OnMovimentacao(InputAction.CallbackContext context);
    }
}
