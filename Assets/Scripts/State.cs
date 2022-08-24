using UnityEngine;
using System;

// namespace StateMachineDemo
// {
    public class State : MonoBehaviour
    {
        public virtual void Enter(){}
        public virtual void HandleInput(){}
        public virtual void LogicUpdate(){}
        public virtual void PhysicsUpdate(){}
        public virtual void Exit(){}
    }
// }