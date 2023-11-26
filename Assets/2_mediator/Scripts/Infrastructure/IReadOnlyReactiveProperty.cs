using System;

namespace Mediator.Infrastructure
{
    public interface IReadOnlyReactiveProperty<T>
    {
        public event Action<T> OnChanged;

        public T Value { get; }      
    }
}
