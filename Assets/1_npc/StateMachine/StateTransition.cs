using System;

namespace Infrastructure
{
    public class StateTransition : AnyStateTransition
    {
        public IState From { get; private set; }

        public StateTransition(IState from, IState to, Func<bool> condition) : base(to, condition)
        {
            From = from;
        }      
    }
}
