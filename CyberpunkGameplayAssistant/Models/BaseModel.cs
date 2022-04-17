using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CyberpunkGameplayAssistant.Models
{
    [Serializable]
    public class BaseModel
    {
        // Constructors
        public BaseModel()
        {

        }

        // Public Properties
        [field: NonSerialized()]
        public event PropertyChangedEventHandler PropertyChanged;

        // Public Methods
        public void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        protected bool SetAndNotify<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) { return false; }

            if (string.IsNullOrEmpty(propertyName))
            {
                throw new ArgumentException($"'{nameof(propertyName)}' cannot be null or empty.", nameof(propertyName));
            }
            field = value;
            NotifyPropertyChanged(propertyName);
            return true;
        }
    }
}
