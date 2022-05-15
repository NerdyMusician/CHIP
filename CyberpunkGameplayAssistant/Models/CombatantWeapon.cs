using CyberpunkGameplayAssistant.Toolbox;
using CyberpunkGameplayAssistant.Windows;
using System;
using System.Collections.Generic;
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
        public string Name
        {
            get => _Name;
            set => SetAndNotify(ref _Name, value);
        }
        private string _Type;
        public string Type
        {
            get => _Type;
            set => SetAndNotify(ref _Type, value);
        }
        private string _Quality;
        public string Quality
        {
            get => _Quality;
            set => SetAndNotify(ref _Quality, value);
        }
        private int _CurrentClipQuantity;
        public int CurrentClipQuantity
        {
            get => _CurrentClipQuantity;
            set => SetAndNotify(ref _CurrentClipQuantity, value);
        }
        private string _AmmoType;
        public string AmmoType
        {
            get => _AmmoType;
            set => SetAndNotify(ref _AmmoType, value);
        }
        private string _AmmoVariant;
        public string AmmoVariant
        {
            get => _AmmoVariant;
            set => SetAndNotify(ref _AmmoVariant, value);
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
                RangedWeaponClip clip = ReferenceData.ClipChart.FirstOrDefault(w => w.WeaponType == Type);
                return (clip != null) ? clip.Standard : 0;
            }
        }

        // Commands
        public ICommand RollBasicAttack => new RelayCommand(DoRollBasicAttack);
        private void DoRollBasicAttack(object param)
        {
            Combatant combatant = (Combatant)param;
            int attackRoll = HelperMethods.RollD10(true);
            if (DidWeaponMalfunction(attackRoll, combatant.Name)) { return; }
            if (!CheckAndUseAmmo(1)) { return; }
            int damageDice = ReferenceData.WeaponRepository.GetDamage(Type);
            int attackBonus = combatant.GetSkillTotal(ReferenceData.WeaponRepository.GetSkill(Type));
            int attackPenalty = combatant.GetAttackInjuryPenalty(Type);
            int damage = HelperMethods.RollDamage(damageDice, out bool criticalInjury);
            string output = GenerateWeaponOutput(combatant, attackRoll, attackBonus, attackPenalty, damage, criticalInjury);
            HelperMethods.AddToGameplayLog(output, ReferenceData.MessageWeaponAttack);
            HelperMethods.PlayWeaponSound(Type);
        }
        public ICommand RollAutofire => new RelayCommand(DoRollAutofire);
        private void DoRollAutofire(object param)
        {
            if (!ReferenceData.AutofireTable.ContainsKey(Type)) { RaiseError(ReferenceData.ErrorNotAnAutofireWeapon); return; }
            Combatant combatant = (Combatant)param;
            int attackRoll = HelperMethods.RollD10(true);
            if (DidWeaponMalfunction(attackRoll, combatant.Name)) { return; }
            if (!CheckAndUseAmmo(10)) { return; }
            int attackBonus = combatant.GetSkillTotal(ReferenceData.SkillAutofire);
            int attackPenalty = combatant.GetAttackInjuryPenalty(Type);
            int damage = HelperMethods.RollDamage(2, out bool criticalInjury);
            string output = GenerateWeaponOutput(combatant, attackRoll, attackBonus, attackPenalty, damage, criticalInjury);
            for (int i = 0; i < ReferenceData.AutofireTable[Type]; i++)
            {
                output += $"\nDamage x{(i + 1)}: {(damage * (i + 1))}";
                if (i == 0 && criticalInjury) { output += " CRIT"; }
            }
            HelperMethods.AddToGameplayLog(output, ReferenceData.MessageWeaponAttack);
            HelperMethods.PlayAutofireSound();
        }
        public ICommand RollAimedShot => new RelayCommand(DoRollAimedShot);
        private void DoRollAimedShot(object param)
        {
            Combatant combatant = (Combatant)param;
            int attackRoll = HelperMethods.RollD10(true);
            if (DidWeaponMalfunction(attackRoll, combatant.Name)) { return; }
            if (!CheckAndUseAmmo(1)) { return; }
            int damageDice = ReferenceData.WeaponRepository.GetDamage(Type);
            int attackBonus = combatant.GetSkillTotal(ReferenceData.WeaponRepository.GetSkill(Type));
            int attackPenalty = combatant.GetAttackInjuryPenalty(Type) + 8; // pg 170
            int damage = HelperMethods.RollDamage(damageDice, out bool criticalInjury);
            string output = GenerateWeaponOutput(combatant, attackRoll, attackBonus, attackPenalty, damage, criticalInjury);
            HelperMethods.AddToGameplayLog(output, ReferenceData.MessageWeaponAttack);
            HelperMethods.PlayWeaponSound(Type);
        }
        public ICommand ReloadWeapon => new RelayCommand(DoReloadWeapon);
        public void DoReloadWeapon(object param)
        {
            if (!UsesAmmo) { return; }
            Combatant combatant = (Combatant)param;
            int clipCapacity = ReferenceData.ClipChart.GetStandardClipSize(Type);
            Ammo ammoTypeNeeded = GetAmmoTypeNeeded(combatant);
            Ammo ammoTypeInUse = GetAmmoTypeInUse(combatant);
            if (ammoTypeNeeded == null) { return; }
            bool isSameAmmo = AreSameAmmo(ammoTypeNeeded, ammoTypeInUse);
            int ammoNeeded = isSameAmmo ? clipCapacity - CurrentClipQuantity : clipCapacity;
            if (ammoNeeded == 0) { RaiseError("Gun clip is already full of that ammo type"); return; }
            int ammoReturned = isSameAmmo ? 0 : CurrentClipQuantity;
            int ammoTaken = (ammoTypeNeeded.Quantity <= ammoNeeded) ? ammoTypeNeeded.Quantity : ammoNeeded;
            CurrentClipQuantity -= ammoReturned;
            CurrentClipQuantity += ammoTaken;
            ammoTypeNeeded.Quantity -= ammoTaken;
            if (ammoTypeInUse != null) { ammoTypeInUse.Quantity += ammoReturned; }
            AmmoType = ammoTypeNeeded.Type;
            AmmoVariant = ammoTypeNeeded.Variant;
            if (ammoTaken == 0) { RaiseError("Not enough ammo to reload"); return; }
            HelperMethods.AddToGameplayLog($"{combatant.DisplayName}{(ammoNeeded > ammoTaken ? "partially" : "")} reloaded their {Name}.", ReferenceData.MessageReload);
            HelperMethods.PlayReloadSound();
        }

        // Private Methods
        private bool AreSameAmmo(Ammo ammoTypeNeeded, Ammo ammoTypeInUse)
        {
            if (ammoTypeInUse == null) { return false; } // unloaded gun
            return ammoTypeNeeded.Type == ammoTypeInUse.Type && ammoTypeNeeded.Variant == ammoTypeInUse.Variant;
        }
        private Ammo GetAmmoTypeNeeded(Combatant combatant)
        {
            List<string> acceptableAmmoTypes = ReferenceData.RangedWeaponAmmoCompatibilities.FirstOrDefault(w => w.WeaponType == Type).AmmoTypes;
            List<Ammo> matchedAmmoListings = combatant.AmmoInventory.Where(a => acceptableAmmoTypes.Contains(a.Type) && a.Quantity > 0).ToList();
            if (matchedAmmoListings.Count == 0) { RaiseError(ReferenceData.ErrorNoAcceptableAmmoTypeInInventory); return null; }
            if (matchedAmmoListings.Count == 1) { return matchedAmmoListings[0]; }
            else
            {
                if (!ReferenceData.IsLoaded) { return matchedAmmoListings[0]; }
                ObjectSelectionDialog objectSelectionDialog = new(matchedAmmoListings.ToNamedRecordList(), "Ammo Types");
                if (objectSelectionDialog.ShowDialog() == true)
                {
                    NamedRecord selectedRecord = objectSelectionDialog.SelectedObject as NamedRecord;
                    return matchedAmmoListings.First(a => a.Type == selectedRecord.Name && a.Variant == selectedRecord.Description);
                }
                else { return null; }
            }
        }
        private Ammo GetAmmoTypeInUse(Combatant combatant)
        {
            return combatant.AmmoInventory.FirstOrDefault(a => a.Type == AmmoType && a.Variant == AmmoVariant);
        }
        private bool CheckAndUseAmmo(int ammoRequired)
        {
            if (!UsesAmmo) { return true; }
            if (!HasEnoughAmmo(ammoRequired)) { return false; }
            CurrentClipQuantity -= ammoRequired;
            return true;
        }
        private bool HasEnoughAmmo(int ammoRequired)
        {
            bool hasEnoughAmmo = ammoRequired <= CurrentClipQuantity;
            if (!hasEnoughAmmo) { RaiseError("Not enough ammo in clip"); }
            return hasEnoughAmmo;
        }
        private bool DidWeaponMalfunction(int attackRoll, string combatantName)
        {
            if (Quality == ReferenceData.WeaponQualityPoor && attackRoll <= 1) 
            { 
                HelperMethods.AddToGameplayLog($"{combatantName}'s {Name} malfunctioned!", ReferenceData.MessageWeaponAttack);
                HelperMethods.PlayMalfunctionSound();
                return true; 
            }
            return false;
        }
        private string GenerateWeaponOutput(Combatant combatant, int attackRoll, int attackBonus, int attackPenalty, int damage, bool criticalInjury)
        {
            int attackResult = attackRoll + attackBonus - combatant.GetAttackInjuryPenalty(Type);
            string output = $"{combatant.DisplayName} attacks with {Name}\nAttack: {attackResult}\nDamage: {damage} {(criticalInjury ? "CRIT" : "")}";
            if (ReferenceData.DebugMode) { output += $"\nDEBUG: ROLL:{attackRoll}, SKILL+STAT:{attackBonus}, PENALTY:{attackPenalty}"; }
            return output;
        }

    }
}
