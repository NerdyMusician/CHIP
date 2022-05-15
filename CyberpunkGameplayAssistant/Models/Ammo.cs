using System;

namespace CyberpunkGameplayAssistant.Models
{
    [Serializable]
    public class Ammo : BaseModel
    {
        public Ammo()
        {

        }
        public Ammo(string type, int quantity)
        {
            Type = type;
            Quantity = quantity;
        }
        public Ammo(string type, int quantity, string variant)
        {
            Type = type;
            Quantity = quantity;
            Variant = variant;
        }

        private string _Type;
        public string Type
        {
            get => _Type;
            set => SetAndNotify(ref _Type, value);
        }
        private int _Quantity;
        public int Quantity
        {
            get => _Quantity;
            set => SetAndNotify(ref _Quantity, value);
        }
        private string _Variant;
        public string Variant
        {
            get => _Variant;
            set => SetAndNotify(ref _Variant, value);
        }

    }
}
