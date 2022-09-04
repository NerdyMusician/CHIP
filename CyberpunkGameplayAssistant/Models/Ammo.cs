using CyberpunkGameplayAssistant.Toolbox;
using CyberpunkGameplayAssistant.Toolbox.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            IsThrowable = type == AppData.AmmoTypeGrenade;
        }
        public Ammo(string type, int quantity, string variant)
        {
            Type = type;
            Quantity = quantity;
            Variant = variant;
            IsThrowable = type == AppData.AmmoTypeGrenade;
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
        private bool _IsThrowable;
        public bool IsThrowable
        {
            get => _IsThrowable;
            set => SetAndNotify(ref _IsThrowable, value);
        }

        // Dropdown Sources
        public List<string> AmmoTypes
        {
            get
            {
                return AppData.AllAmmoTypes.DeepClone();
            }
        }
        public List<string> AmmoVariants
        {
            get
            {
                return AppData.AllAmmoVariants.DeepClone();
            }
        }

        // Commands
        public ICommand RestockAmmo => new RelayCommand(DoRestockAmmo);
        private void DoRestockAmmo(object param)
        {
            if (Type == AppData.AmmoTypeGrenade || Type == AppData.AmmoTypeRocket) { Quantity += 1; }
            else { Quantity += 10; }
            HelperMethods.PlayReloadSound();
        }
        public ICommand ThrowGrenade => new RelayCommand(DoThrowGrenade);
        private void DoThrowGrenade(object param)
        {
            // TODO - alternate grenade outcomes (pg345+)
            if (!HasGrenades()) { return; }
            Combatant combatant = (param as Combatant)!;
            int roll = HelperMethods.RollD10(true);
            int dex = combatant.CalculatedStats.GetValue(AppData.StatDexterity);
            int athletics = combatant.Skills.GetLevel(AppData.SkillAthletics);
            int[] damage = HelperMethods.RollDamage(6, out bool crit);
            string output = $"{combatant.DisplayName} threw a grenade up to 25m/yds\nResult: {(roll + dex + athletics)}";
            if (AppData.MainModelRef.SettingsView.DebugMode) { output += $"\nDEBUG: ROLL:{roll} DEX:{dex} ATHL:{athletics}"; }
            output += HelperMethods.ProcessAmmoEffect(damage, crit, Variant);
            HelperMethods.AddToGameplayLog(output, AppData.MessageWeaponAttack);
            HelperMethods.PlayExplosionSound();
            Quantity--;
        }
        public ICommand RemoveAmmo => new RelayCommand(DoRemoveAmmo);
        private void DoRemoveAmmo(object param)
        {
            (param as ObservableCollection<Ammo>)!.Remove(this);
        }

        // Private Methods
        private bool HasGrenades()
        {
            if (Quantity > 0) { return true; }
            else
            {
                RaiseError("Grenade Quantity is Zero");
                return false;
            }
        }

    }
}
