using CyberpunkGameplayAssistant.Toolbox;
using System;
using System.Windows.Input;

namespace CyberpunkGameplayAssistant.Models
{
    [Serializable]
    public class Ammo : BaseModel
    {
        // Constructors
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

        // Properties
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

        // Commands
        public ICommand RestockAmmo => new RelayCommand(DoRestockAmmo);
        private void DoRestockAmmo(object param)
        {
            if (Type == ReferenceData.AmmoTypeGrenade || Type == ReferenceData.AmmoTypeRocket) { Quantity += 1; }
            else { Quantity += 10; }
            HelperMethods.PlayReloadSound();
        }

    }
}
