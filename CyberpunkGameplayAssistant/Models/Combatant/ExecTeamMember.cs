using CyberpunkGameplayAssistant.Toolbox;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CyberpunkGameplayAssistant.Models
{
    public partial class Combatant : BaseModel
    {
        // Constructors
        public Combatant(string name, string type, string portrait, string armor)
        {
            InitializeLists();
            Name = name;
            Type = type;
            PortraitFilePath = portrait;
            ArmorType = armor;
        }

        // Properties

        // Public Methods
        public void SetSkillLevels(int level, params string[] skills)
        {
            foreach (string skill in skills)
            {
                Skill matchedSkill = Skills.FirstOrDefault(s => s.Name == skill);
                if (matchedSkill != null) { matchedSkill.Level = level; }
                else { Skills.Add(new(skill, string.Empty, level)); }
            }
        }


    }
}
