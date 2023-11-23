using System;

namespace Infrastructure
{
    public interface IStateMachine
    {
        IState CurrentState { get; }
        IStateMachine RegisterState(IState state);
        void SetState<T>() where T : IState;
        void Update(float deltaTime);
    }
}
