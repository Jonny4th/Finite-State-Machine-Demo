using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

// namespace StateMachineDemo
// {
    public class StateMachine : MonoBehaviour
    {
        public State currentState;
        public void Initialize(State startingState)
        {
            currentState = startingState;
            startingState.Enter();
        }
        public void ChangeState(State newState)
        {
            currentState.Exit();
            currentState = newState;
            OnStateChange?.Invoke();
            newState.Enter();
        }
        public event Action OnStateChange;
    }
// }
