using CyberpunkGameplayAssistant.Toolbox;
using CyberpunkGameplayAssistant.Windows;
using System.Collections.Generic;
using System.Linq;

namespace CyberpunkGameplayAssistant.Models
{
    public partial class Combatant : BaseModel
    {
        public List<WeaponOption> WeaponOptions { get; set; }
        public int WeaponOptionsAllowed { get; set; }
        public bool ManualWeaponOptionSelection { get; set; }

        public void AddWeaponOption(string weaponType, string weaponQuality, string ammoType, int ammoQuantity, string ammoVar = "")
        {
            if (string.IsNullOrEmpty(ammoVar)) { ammoVar = ReferenceData.AmmoVarBasic; }
            WeaponOptions.Add(new(weaponType, weaponQuality, ammoType, ammoQuantity));
        }
        public void AddWeaponOptionsToWeapons()
        {
            if (WeaponOptions.Count == 0) { return; } // Assumes defense only has and uses one weapon
            if (WeaponOptions.Count < WeaponOptionsAllowed) { RaiseError(ReferenceData.ErrorNotEnoughWeaponOptions); }
            List<WeaponOption> options = new(WeaponOptions);
            for (int i = 0; i < WeaponOptionsAllowed; i++)
            {
                WeaponOption weaponOption = ManualWeaponOptionSelection ? SelectManualWeaponOption(options) : options[ReferenceData.RNG.Next(0, options.Count)];
                if (weaponOption == null) { i--; continue; }
                AddWeapon(weaponOption.WeaponType, weaponOption.WeaponQuality);
                AddAmmo(weaponOption.AmmoType, weaponOption.AmmoQuantity);
                options.Remove(weaponOption);
            }
            ReloadAllWeapons();
        }
        private WeaponOption SelectManualWeaponOption(List<WeaponOption> options)
        {
            ObjectSelectionDialog selectionDialog = new(options.ToNamedRecordList(), "Weapon Options");
            if (selectionDialog.ShowDialog() == true)
            {
                return options.First(o => o.WeaponType == (selectionDialog.SelectedObject as NamedRecord)!.Name);
            }
            return null;
        }
    }
}
