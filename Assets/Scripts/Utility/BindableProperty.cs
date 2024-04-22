using System;
using System.Collections.Generic;

namespace Hskim.Utility
{
    public sealed class BindableProperty<T>
    {
        public Action<T> OnValueChanged { get; set; }

        private T _value;

        public T Value
        {
            get => _value;
            set
            {
                if (EqualityComparer<T>.Default.Equals(_value, value)) return;
                _value = value;
                OnValueChanged?.Invoke(_value);
            }
        }

        public BindableProperty(T initialValue = default)
        {
            _value = initialValue;
        }
    }
}