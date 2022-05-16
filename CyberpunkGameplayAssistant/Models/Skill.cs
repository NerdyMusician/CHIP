using CyberpunkGameplayAssistant.Toolbox;
using CyberpunkGameplayAssistant.Toolbox.ExtensionMethods;
using System.Collections.Generic;
using System.Windows.Input;

namespace CyberpunkGameplayAssistant.Models
{
    public class Skill : BaseModel
    {
        // Constructors
        public Skill()
        {

        }
        public Skill(string name, string variant = "")
        {
            Name = name;
            Variant = variant;
        }
        public Skill(string name, string variant, int level)
        {
            Name = name;
            Variant = variant;
            Level = level;
        }

        // Databound Properties
        private string _Name;
        
        public string Name
        {
            get => _Name;
            set => SetAndNotify(ref _Name, value);
        }
        private string _Variant;
        
        public string Variant
        {
            get => _Variant;
            set => SetAndNotify(ref _Variant, value);
        }
        private int _Level;
        
        public int Level
        {
            get => _Level;
            set => SetAndNotify(ref _Level, value);
        }

        // Properties
        public string DisplayName
        {
            get 
            { 
                return Name + 
                    (!Variant.IsNullOrEmpty() ? $" ({Variant})" : "") + 
                    ((ReferenceData.SkillLinks.GetCost(Name) > 1) ? $" (x{ReferenceData.SkillLinks.GetCost(Name)})" : ""); 
            }
        }

        // Commands
        public ICommand RollSkill => new RelayCommand(DoRollSkill);
        private void DoRollSkill(object param)
        {
            Combatant combatant = param as Combatant;
            string output = $"{combatant.DisplayName} made a {Name} check";
            int result = HelperMethods.RollD10();
            // TODO penalty for critical injuries
            string statName = ReferenceData.SkillLinks.GetStat(Name);
            int stat = combatant.CalculatedStats.GetValue(statName);
            output += $"\nResult: {result + stat + Level}";
            if (Name == ReferenceData.SkillBrawling) { output += GetBrawlingDamage(combatant); }
            if (ReferenceData.DebugMode) { output += $"\nDEBUG: {result} + {stat} + {Level}"; }
            HelperMethods.AddToGameplayLog(output, ReferenceData.MessageSkillCheck);
        }

        // Private Methods
        private string GetBrawlingDamage(Combatant combatant)
        {
            int body = combatant.CalculatedStats.GetValue(ReferenceData.StatBody);
            bool hasCyberarm = combatant.InstalledCyberware.Contains(ReferenceData.CyberwareCyberarm);
            int damage = body switch
            {
                <= 4 => 1,
                5 => 2,
                6 => 3,
                7 => 3,
                8 => 3,
                9 => 3,
                10 => 3,
                _ => 4
            };
            if (hasCyberarm && damage < 2) { damage = 2; }
            return $"\nDamage: {HelperMethods.RollDamage(damage, out bool criticalInjury)} {(criticalInjury ? "CRIT" : "")}";
        }

    }
}
