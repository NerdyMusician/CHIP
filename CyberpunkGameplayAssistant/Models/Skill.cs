using CyberpunkGameplayAssistant.Toolbox;

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

        // Databound Properties
        private string _Name;
        [XmlSaveMode(XSME.Single)]
        public string Name
        {
            get => _Name;
            set => SetAndNotify(ref _Name, value);
        }
        private string _Variant;
        [XmlSaveMode(XSME.Single)]
        public string Variant
        {
            get => _Variant;
            set => SetAndNotify(ref _Variant, value);
        }
        private int _Value;
        [XmlSaveMode(XSME.Single)]
        public int Value
        {
            get => _Value;
            set => SetAndNotify(ref _Value, value);
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

    }
}
