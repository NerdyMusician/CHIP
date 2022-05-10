using CyberpunkGameplayAssistant.Toolbox;
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
            string output = $"{combatant.DisplayName} made a {Name} check\n";
            int result = HelperMethods.RollD10();
            string statName = ReferenceData.SkillLinks.GetStat(Name);
            int stat = combatant.CalculatedStats.GetValue(statName);
            if (new List<string> { ReferenceData.StatReflexes, ReferenceData.StatDexterity, ReferenceData.StatMovement}.Contains(statName))
            {
                stat -= ReferenceData.ArmorTable.GetPenalty(combatant.ArmorType);
            }
            output += $"Result: {result + stat + Level}\n";
            output += $"Roll: {result} + {stat} + {Level}";
            HelperMethods.AddToGameplayLog(output, ReferenceData.MessageSkillCheck);
        }

    }
}
