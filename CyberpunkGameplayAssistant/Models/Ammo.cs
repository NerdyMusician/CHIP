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

    }
}
