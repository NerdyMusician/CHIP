using CyberpunkGameplayAssistant.Toolbox;
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
            if (!ReferenceData.AutofireTable.ContainsKey(Type)) { HelperMethods.NotifyUser("This weapon does not have Autofire"); return; }
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
        private void DoReloadWeapon(object param)
        {
            Combatant combatant = (Combatant)param;
            int clipCapacity = ReferenceData.ClipChart.GetStandardClipSize(Type);
            int ammoNeeded = clipCapacity - CurrentClipQuantity;
            Ammo matchedAmmo = combatant.AmmoInventory.FirstOrDefault(a => a.Type == ReferenceData.WeaponRepository.FirstOrDefault(w => w.Type == Type).AmmoType);
            int ammoTaken = (matchedAmmo.Quantity <= ammoNeeded) ? matchedAmmo.Quantity : ammoNeeded;
            CurrentClipQuantity += ammoTaken;
            matchedAmmo.Quantity -= ammoTaken;
            if (ammoTaken == 0) { ThrowError("Not enough ammo to reload"); return; }
            HelperMethods.AddToGameplayLog($"{combatant.DisplayName}{(ammoNeeded > ammoTaken ? "partially" : "")} reloaded their {Name}.", ReferenceData.MessageReload);
            HelperMethods.PlayReloadSound();
        }

        // Private Methods
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
            if (!hasEnoughAmmo) { ThrowError("Not enough ammo in clip"); }
            return hasEnoughAmmo;
        }
        private bool DidWeaponMalfunction(int attackRoll, string combatantName)
        {
            if (Quality == ReferenceData.WeaponQualityPoor && attackRoll <= 1) 
            { 
                HelperMethods.AddToGameplayLog($"{combatantName}'s {Name} malfunctioned!", ReferenceData.MessageWeaponAttack); 
                return true; 
            }
            return false;
        }
        private string GenerateWeaponOutput(Combatant combatant, int attackRoll, int attackBonus, int attackPenalty, int damage, bool criticalInjury)
        {
            int attackResult = attackRoll + attackBonus - combatant.GetAttackInjuryPenalty(Type);
            string output = $"{combatant.DisplayName} attacks with {Name}\nAttack: {attackResult}\nDamage: {damage} {(criticalInjury ? "CRIT" : "")}";
            if (ReferenceData.DebugMode) { output += $"\nATK DBG: ROLL:{attackRoll}, SKILL+STAT:{attackBonus}, PENALTY:{attackPenalty}"; }
            return output;
        }

    }
}
