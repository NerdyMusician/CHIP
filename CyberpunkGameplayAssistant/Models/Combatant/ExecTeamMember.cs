using CyberpunkGameplayAssistant.Toolbox;
using System.Collections.Generic;

namespace CyberpunkGameplayAssistant.Models
{
    public partial class Combatant : BaseModel
    {
        // Constructors
        public Combatant(string name, string type, string portrait, string armor)
        {
            Name = name;
            Type = type;
            PortraitFilePath = portrait;
            ArmorType = armor;
            if (Type == ReferenceData.ExecTeamMember) { InitializeExecTeamCollections(); }
        }

        // Properties
        public Dictionary<int, List<int>> StatTable { get; set; }
        public List<string> SkillsAtPlus2 { get; set; }
        public List<string> SkillsAtPlus4 { get; set; }
        public List<string> SkillsAtPlus6 { get; set; }

        // Public Methods
        public void InitializeExecTeamCollections()
        {
            StatTable = new();
            SkillsAtPlus2 = new();
            SkillsAtPlus4 = new();
            SkillsAtPlus6 = new();
        }


    }
}
