using System;

namespace Mediator.Infrastructure
{
    public class ReactiveProperty<T> : IReadOnlyReactiveProperty<T>
    {
        public event Action<T> OnChanged;

        public T Value
        {
            get => _value;
            set
            {
                _value = value;
                OnChanged?.Invoke(_value);
            }
        }

        private T _value;
    }
}
