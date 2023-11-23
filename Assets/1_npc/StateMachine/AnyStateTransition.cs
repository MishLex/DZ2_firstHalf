using System;

namespace Infrastructure
{
    public class AnyStateTransition
    {
        public IState To { get; private set; }
        public Func<bool> Condition { get; private set; }

        public AnyStateTransition(IState to, Func<bool> condition)
        {
            To = to;
            Condition = condition;
        }
    }
}
