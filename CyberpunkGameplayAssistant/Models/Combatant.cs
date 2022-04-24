using CyberpunkGameplayAssistant.Toolbox;
using System.Collections.ObjectModel;
using System.Linq;

namespace CyberpunkGameplayAssistant.Models
{
    public class Combatant : Entity
    {
        // Constructors
        public Combatant()
        {
            Stats = new();
        }
        public Combatant(string name, string imagePath, string armor)
        {
            Name = name;
            PortraitFilepath = imagePath;
            ArmorType = armor;
        }

        // Databound Properties
        private string _Name;
        [XmlSaveMode(XSME.Single)]
        public string Name
        {
            get => _Name;
            set => SetAndNotify(ref _Name, value);
        }
        private string _PortraitFilepath;
        public string PortraitFilepath
        {
            get => _PortraitFilepath;
            set => SetAndNotify(ref _PortraitFilepath, value);
        }
        private ObservableCollection<Stat> _Stats;
        [XmlSaveMode(XSME.Enumerable)]
        public ObservableCollection<Stat> Stats
        {
            get => _Stats;
            set => SetAndNotify(ref _Stats, value);
        }
        private ObservableCollection<Skill> _Skills;
        [XmlSaveMode(XSME.Enumerable)]
        public ObservableCollection<Skill> Skills
        {
            get => _Skills;
            set => SetAndNotify(ref _Skills, value);
        }

        private int _MaximumHitPoints;
        public int MaximumHitPoints
        {
            get => _MaximumHitPoints;
            set => SetAndNotify(ref _MaximumHitPoints, value);
        }
        private int _CurrentHitPoints;
        [XmlSaveMode(XSME.Single)]
        public int CurrentHitPoints
        {
            get => _CurrentHitPoints;
            set => SetAndNotify(ref _CurrentHitPoints, value);
        }
        private int _SeriouslyWoundedThreshold;
        public int SeriouslyWoundedThreshold
        {
            get => _SeriouslyWoundedThreshold;
            set => SetAndNotify(ref _SeriouslyWoundedThreshold, value);
        }
        private int _DeathSave;
        public int DeathSave
        {
            get => _DeathSave;
            set => SetAndNotify(ref _DeathSave, value);
        }
        private int _QuantityToAdd;
        public int QuantityToAdd
        {
            get => _QuantityToAdd;
            set => SetAndNotify(ref _QuantityToAdd, value);
        }
        private string _ArmorType;
        public string ArmorType
        {
            get => _ArmorType;
            set => SetAndNotify(ref _ArmorType, value);
        }

        // Public Methods
        public void SetStats(int INT, int REF, int DEX, int TECH, int COOL, int WILL, int LUCK, int MOVE, int BODY, int EMP)
        {
            Stats = new();
            Stats.Add(new(ReferenceData.StatIntelligence, INT));
            Stats.Add(new(ReferenceData.StatReflexes, REF));
            Stats.Add(new(ReferenceData.StatDexterity, DEX));
            Stats.Add(new(ReferenceData.StatTechnique, TECH));
            Stats.Add(new(ReferenceData.StatCool, COOL));
            Stats.Add(new(ReferenceData.StatWillpower, INT));
            Stats.Add(new(ReferenceData.StatLuck, INT));
            Stats.Add(new(ReferenceData.StatMovement, INT));
            Stats.Add(new(ReferenceData.StatBody, INT));
            Stats.Add(new(ReferenceData.StatEmpathy, INT));
        }
        public void SetDerivedStats()
        {
            MaximumHitPoints = 5 * ((Stats.GetValue(ReferenceData.StatBody) + Stats.GetValue(ReferenceData.StatWillpower)) / 2);
        }
        public void SetBaseSkills()
        {
            Skills = new();
            foreach (SkillLinkReference skill in ReferenceData.SkillLinks)
            {
                if (skill.SkillName == ReferenceData.SkillLanguage) { continue; }
                if (skill.SkillName == ReferenceData.SkillLocalExpert) { continue; }
                if (skill.SkillName == ReferenceData.SkillScience) { continue; }
                if (skill.SkillName == ReferenceData.SkillPlayInstrument) { continue; }
                Skills.Add(new(skill.SkillName));
            }
        }
        public void AddSkill(string name, int value, string variant = "")
        {
            Skill skill = Skills.FirstOrDefault(s => s.Name == name && s.Variant == variant);
            if (skill == null)
            {
                int level = value - Stats.GetValue(ReferenceData.SkillLinks.First(s => s.SkillName == name).StatName);
                Skills.Add(new(name, variant, level));
            }
            else
            {
                skill.Level = value - Stats.GetValue(ReferenceData.SkillLinks.First(s => s.SkillName== name).StatName);
            }
        }

    }
}
