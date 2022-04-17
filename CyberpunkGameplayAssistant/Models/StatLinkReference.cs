namespace CyberpunkGameplayAssistant.Models
{
    public class StatLinkReference : BaseModel
    {
        // Constructors
        public StatLinkReference(string category, string stat, string abbreviation)
        {
            Category = category;
            StatName = stat;
            Abbreviation = abbreviation;
        }

        // Properties
        public string Category { get; set; }
        public string StatName { get; set; }
        public string Abbreviation { get; set; }
    }
}
