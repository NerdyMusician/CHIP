using CyberpunkGameplayAssistant.Toolbox;
using System;

namespace CyberpunkGameplayAssistant.Models
{
    [Serializable]
    public class Gear : BaseModel
    {
        // Constructors
        public Gear()
        {

        }
        public Gear(string name)
        {
            Name = name;
            Description = string.Empty;
            Quantity = 1;
        }
        public Gear(string name, string description, int quantity = 1)
        {
            Name = name;
            Description = description;
            Quantity = quantity;
        }

        // Databound Properties
        private string _Name;
        public string Name
        {
            get => _Name;
            set => SetAndNotify(ref _Name, value);
        }
        private string _Description;
        public string Description
        {
            get => _Description;
            set => SetAndNotify(ref _Description, value);
        }
        private int _Quantity;
        public int Quantity
        {
            get => _Quantity;
            set => SetAndNotify(ref _Quantity, value);
        }

    }
}
