﻿using CyberpunkGameplayAssistant.Toolbox;
using System;
using System.Linq;
using System.Windows.Input;

namespace CyberpunkGameplayAssistant.Models
{
    [Serializable]
    public class CombatantWeapon : BaseModel
    {
        public CombatantWeapon()
        {

        }
        public CombatantWeapon(string weaponType, string weaponQuality, string weaponName)
        {
            Type = weaponType;
            Quality = weaponQuality;
            Name = string.IsNullOrEmpty(weaponName) ? weaponType : weaponName;
        }

        private string _Name;
        [XmlSaveMode(XSME.Single)]
        public string Name
        {
            get => _Name;
            set => SetAndNotify(ref _Name, value);
        }
        private string _Type;
        [XmlSaveMode(XSME.Single)]
        public string Type
        {
            get => _Type;
            set => SetAndNotify(ref _Type, value);
        }
        private string _Quality;
        [XmlSaveMode(XSME.Single)]
        public string Quality
        {
            get => _Quality;
            set => SetAndNotify(ref _Quality, value);
        }
        private int _CurrentClipQuantity;
        [XmlSaveMode(XSME.Single)]
        public int CurrentClipQuantity
        {
            get => _CurrentClipQuantity;
            set => SetAndNotify(ref _CurrentClipQuantity, value);
        }

        // Properties
        public bool UsesAmmo
        {
            get
            {
                return ReferenceData.WeaponRepository.FirstOrDefault(w => w.Type == Type).AmmoType != ReferenceData.AmmoTypeNone;
            }
        }
        public int MaxClipQuantity
        {
            get
            {
                return ReferenceData.ClipChart.FirstOrDefault(w => w.WeaponType == Type).Standard;
            }
        }

        // Commands
        public ICommand RollBasicAttack => new RelayCommand(DoRollBasicAttack);
        private void DoRollBasicAttack(object param)
        {
            Combatant combatant = (Combatant)param;
            if (UsesAmmo)
            {
                if (!HasEnoughAmmo(1)) { return; }
                CurrentClipQuantity--;
            }
            int damageDice = ReferenceData.WeaponRepository.GetDamage(Type);
            string relevantSkill = ReferenceData.WeaponRepository.GetSkill(Type);
            int attackBonus = combatant.GetSkillTotal(relevantSkill);
            int attackResult = HelperMethods.RollD10(true) + attackBonus;
            int damage = HelperMethods.RollDamage(6, out bool criticalInjury);
            HelperMethods.AddToGameplayLog($"{combatant.DisplayName} autofires with {Name}\nAttack: {attackResult}\nDamage: {damage} {(criticalInjury ? "CRIT" : "")}");
        }
        public ICommand RollAutofire => new RelayCommand(DoRollAutofire);
        private void DoRollAutofire(object param)
        {
            if (!ReferenceData.AutofireTable.ContainsKey(Type)) { HelperMethods.NotifyUser("This weapon does not have Autofire"); return; }
            Combatant combatant = (Combatant)param;
            if (!HasEnoughAmmo(10)) { return; }
            CurrentClipQuantity -= 10;
            int attackBonus = combatant.GetSkillTotal(ReferenceData.SkillAutofire);
            int attackResult = HelperMethods.RollD10(true) + attackBonus;
            int damage = HelperMethods.RollDamage(2, out bool criticalInjury);
            string output = $"{combatant.DisplayName} uses {Name}\nAttack: {attackResult}";
            for (int i = 0; i < ReferenceData.AutofireTable[Type]; i++)
            {
                output += $"\nDamage x{(i + 1)}: {(damage * (i + 1))}";
            }
            HelperMethods.AddToGameplayLog(output);
        }
        public ICommand RollAimedShot => new RelayCommand(DoRollAimedShot);
        private void DoRollAimedShot(object param)
        {
            Combatant combatant = (Combatant)param;
            if (UsesAmmo)
            {
                if (!HasEnoughAmmo(1)) { return; }
                CurrentClipQuantity--;
            }
            int damageDice = ReferenceData.WeaponRepository.GetDamage(Type);
            string relevantSkill = ReferenceData.WeaponRepository.GetSkill(Type);
            int attackBonus = combatant.GetSkillTotal(relevantSkill);
            int attackResult = HelperMethods.RollD10(true) + attackBonus - 8; //pg170
            int damage = HelperMethods.RollDamage(6, out bool criticalInjury);
            HelperMethods.AddToGameplayLog($"{combatant.DisplayName} aims {Name}\nAttack: {attackResult}\nDamage: {damage} {(criticalInjury ? "CRIT" : "")}");
        }
        public ICommand ReloadWeapon => new RelayCommand(DoReloadWeapon);
        private void DoReloadWeapon(object param)
        {
            Combatant combatant = (Combatant)param;
            int clipCapacity = ReferenceData.ClipChart.GetStandardClipSize(Type);
            int ammoNeeded = clipCapacity - CurrentClipQuantity;
            Ammo matchedAmmo = combatant.AmmoInventory.FirstOrDefault(a => a.Type == ReferenceData.WeaponRepository.FirstOrDefault(w => w.Type == Type).AmmoType);
            int ammoTaken = (matchedAmmo.Quantity <= ammoNeeded) ? matchedAmmo.Quantity : ammoNeeded;
            CurrentClipQuantity += ammoTaken;
            matchedAmmo.Quantity -= ammoTaken;
        }

        // Private Methods
        private bool HasEnoughAmmo(int ammoRequired)
        {
            bool hasEnoughAmmo = ammoRequired <= CurrentClipQuantity;
            if (!hasEnoughAmmo) { HelperMethods.NotifyUser("Not enough ammo in clip"); }
            return hasEnoughAmmo;
        }

    }
}