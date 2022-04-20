namespace CyberpunkGameplayAssistant.Models
{
    public class SkillLinkReference
    {
        // Constructors
        public SkillLinkReference(string category, string skillName, string statName, int costPerLevel = 1)
        {
            Category = category;
            SkillName = skillName;
            StatName = statName;
            CostPerLevel = costPerLevel;
        }

        // Properties
        public string Category { get; set; }
        public string SkillName { get; set; }
        public string VariantName { get; set; }
        public string StatName { get; set; }
        public int CostPerLevel { get; set; }

    }
}
