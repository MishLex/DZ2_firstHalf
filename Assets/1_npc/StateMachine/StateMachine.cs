using System;
using System.Collections.Generic;


namespace Infrastructure
{
    public class StateMachine : IStateMachine
    {
        public IState CurrentState { get; private set;}
        protected readonly Dictionary<Type, IState> StateMap = new();
        public IStateMachine RegisterState(IState state)
        {
            StateMap[state.GetType()] = state;

            return this;
        }
        public void SetState<T>() where T : IState
        {
            if(StateMap.TryGetValue(typeof(T), out IState state))
            {
                CurrentState?.Exit();

                CurrentState = state;

                CurrentState.Enter();
            }
        }
        public virtual void Update(float deltaTime) 
            => CurrentState?.Update(deltaTime);
    }
}
