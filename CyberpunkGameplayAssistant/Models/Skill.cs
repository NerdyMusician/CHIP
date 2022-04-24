using CyberpunkGameplayAssistant.Toolbox;
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
        private int _Level;
        [XmlSaveMode(XSME.Single)]
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
            // how get combatant name
        }

    }
}
