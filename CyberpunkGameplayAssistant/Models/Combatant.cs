using CyberpunkGameplayAssistant.Toolbox;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace CyberpunkGameplayAssistant.Models
{
    [Serializable]
    public class Combatant : Entity
    {
        // Constructors
        public Combatant()
        {
            InitializeLists();
        }
        public Combatant(string name, string imagePath, string armor)
        {
            InitializeLists();
            Name = name;
            PortraitFilePath = imagePath;
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
        private string _TrackerIndicator;
        [XmlSaveMode(XSME.Single)]
        public string TrackerIndicator
        {
            get => _TrackerIndicator;
            set => SetAndNotify(ref _TrackerIndicator, value);
        }
        private string _DisplayName;
        [XmlSaveMode(XSME.Single)]
        public string DisplayName
        {
            get => _DisplayName;
            set => SetAndNotify(ref _DisplayName, value);
        }
        private string _PortraitFilePath;
        public string PortraitFilePath
        {
            get => _PortraitFilePath;
            set => SetAndNotify(ref _PortraitFilePath, value);
        }
        private int _Initiative;
        [XmlSaveMode(XSME.Single)]
        public int Initiative
        {
            get => _Initiative;
            set => SetAndNotify(ref _Initiative, value);
        }
        private bool _IsPlayer;
        [XmlSaveMode(XSME.Single)]
        public bool IsPlayer
        {
            get => _IsPlayer;
            set => SetAndNotify(ref _IsPlayer, value);
        }
        private bool _IsNpc;
        [XmlSaveMode(XSME.Single)]
        public bool IsNpc
        {
            get => _IsNpc;
            set => SetAndNotify(ref _IsNpc, value);
        }
        private bool _IsActive;
        [XmlSaveMode(XSME.Single)]
        public bool IsActive
        {
            get => _IsActive;
            set => SetAndNotify(ref _IsActive, value);
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
        private ObservableCollection<Skill> _AwarenessSkills;
        [XmlSaveMode(XSME.Enumerable)]
        public ObservableCollection<Skill> AwarenessSkills
        {
            get => _AwarenessSkills;
            set => SetAndNotify(ref _AwarenessSkills, value);
        }
        private ObservableCollection<Skill> _BodySkills;
        [XmlSaveMode(XSME.Enumerable)]
        public ObservableCollection<Skill> BodySkills
        {
            get => _BodySkills;
            set => SetAndNotify(ref _BodySkills, value);
        }
        private ObservableCollection<Skill> _ControlSkills;
        [XmlSaveMode(XSME.Enumerable)]
        public ObservableCollection<Skill> ControlSkills
        {
            get => _ControlSkills;
            set => SetAndNotify(ref _ControlSkills, value);
        }
        private ObservableCollection<Skill> _PerformanceSkills;
        [XmlSaveMode(XSME.Enumerable)]
        public ObservableCollection<Skill> PerformanceSkills
        {
            get => _PerformanceSkills;
            set => SetAndNotify(ref _PerformanceSkills, value);
        }
        private ObservableCollection<Skill> _EducationSkills;
        [XmlSaveMode(XSME.Enumerable)]
        public ObservableCollection<Skill> EducationSkills
        {
            get => _EducationSkills;
            set => SetAndNotify(ref _EducationSkills, value);
        }
        private ObservableCollection<Skill> _FightingSkills;
        [XmlSaveMode(XSME.Enumerable)]
        public ObservableCollection<Skill> FightingSkills
        {
            get => _FightingSkills;
            set => SetAndNotify(ref _FightingSkills, value);
        }
        private ObservableCollection<Skill> _RangedWeaponSkills;
        [XmlSaveMode(XSME.Enumerable)]
        public ObservableCollection<Skill> RangedWeaponSkills
        {
            get => _RangedWeaponSkills;
            set => SetAndNotify(ref _RangedWeaponSkills, value);
        }
        private ObservableCollection<Skill> _SocialSkills;
        [XmlSaveMode(XSME.Enumerable)]
        public ObservableCollection<Skill> SocialSkills
        {
            get => _SocialSkills;
            set => SetAndNotify(ref _SocialSkills, value);
        }
        private ObservableCollection<Skill> _TechniqueSkills;
        [XmlSaveMode(XSME.Enumerable)]
        public ObservableCollection<Skill> TechniqueSkills
        {
            get => _TechniqueSkills;
            set => SetAndNotify(ref _TechniqueSkills, value);
        }
        private string _WoundState;
        public string WoundState
        {
            get => _WoundState;
            set => SetAndNotify(ref _WoundState, value);
        }

        private ObservableCollection<CombatantWeapon> _Weapons;
        [XmlSaveMode(XSME.Enumerable)]
        public ObservableCollection<CombatantWeapon> Weapons
        {
            get => _Weapons;
            set => SetAndNotify(ref _Weapons, value);
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
        private int _MaximumHeadStoppingPower;
        [XmlSaveMode(XSME.Single)]
        public int MaximumHeadStoppingPower
        {
            get => _MaximumHeadStoppingPower;
            set => SetAndNotify(ref _MaximumHeadStoppingPower, value);
        }
        private int _MaximumBodyStoppingPower;
        [XmlSaveMode(XSME.Single)]
        public int MaximumBodyStoppingPower
        {
            get => _MaximumBodyStoppingPower;
            set => SetAndNotify(ref _MaximumBodyStoppingPower, value);
        }
        private int _CurrentHeadStoppingPower;
        [XmlSaveMode(XSME.Single)]
        public int CurrentHeadStoppingPower
        {
            get => _CurrentHeadStoppingPower;
            set => SetAndNotify(ref _CurrentHeadStoppingPower, value);
        }
        private int _CurrentBodyStoppingPower;
        [XmlSaveMode(XSME.Single)]
        public int CurrentBodyStoppingPower
        {
            get => _CurrentBodyStoppingPower;
            set => SetAndNotify(ref _CurrentBodyStoppingPower, value);
        }
        private bool _WeaponMenuOpen;
        public bool WeaponMenuOpen
        {
            get => _WeaponMenuOpen;
            set => SetAndNotify(ref _WeaponMenuOpen, value);
        }
        private bool _StatSkillMenuOpen;
        public bool StatSkillMenuOpen
        {
            get => _StatSkillMenuOpen;
            set => SetAndNotify(ref _StatSkillMenuOpen, value);
        }
        private ObservableCollection<Ammo> _AmmoInventory;
        [XmlSaveMode(XSME.Enumerable)]
        public ObservableCollection<Ammo> AmmoInventory
        {
            get => _AmmoInventory;
            set => SetAndNotify(ref _AmmoInventory, value);
        }
        private bool _IsDead;
        [XmlSaveMode(XSME.Single)]
        public bool IsDead
        {
            get => _IsDead;
            set => SetAndNotify(ref _IsDead, value);
        }

        // Commands
        public ICommand AdjustHitPoints => new RelayCommand(DoAdjustHitPoints);
        private void DoAdjustHitPoints(object param)
        {
            int hitPointChange = Convert.ToInt32(param);
            CurrentHitPoints += hitPointChange;
            if (CurrentHitPoints < 0) { CurrentHitPoints = 0; }
            if (CurrentHitPoints > MaximumHitPoints) { CurrentHitPoints = MaximumHitPoints; }
            UpdateWoundState();
        }
        public ICommand AdjustStoppingPower => new RelayCommand(DoAdjustStoppingPower);
        private void DoAdjustStoppingPower(object param)
        {
            string[] parts = param.ToString().Split(',');
            string area = parts[0];
            int amount = Convert.ToInt32(parts[1]);
            if (area == "Head")
            {
                CurrentHeadStoppingPower += amount;
                if (CurrentHeadStoppingPower < 0) { CurrentHeadStoppingPower = 0; }
                if (CurrentHeadStoppingPower > MaximumHeadStoppingPower) { CurrentHeadStoppingPower = MaximumHeadStoppingPower; }
            }
            if (area == "Body")
            {
                CurrentBodyStoppingPower += amount;
                if (CurrentBodyStoppingPower < 0) { CurrentBodyStoppingPower = 0; }
                if (CurrentBodyStoppingPower > MaximumBodyStoppingPower) { CurrentBodyStoppingPower = MaximumBodyStoppingPower; }
            }
        }

        // Public Methods
        public void InitializeLoadedCombatant()
        {
            UpdateWoundState();
        }
        public void SetStoppingPower()
        {
            MaximumHeadStoppingPower = ReferenceData.ArmorTable.GetStoppingPower(ArmorType);
            MaximumBodyStoppingPower = ReferenceData.ArmorTable.GetStoppingPower(ArmorType);
            CurrentHeadStoppingPower = MaximumHeadStoppingPower;
            CurrentBodyStoppingPower = MaximumBodyStoppingPower;
        }
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
            CurrentHitPoints = MaximumHitPoints;
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
        public void AddWeapon(string type, string quality, string name = "")
        {
            Weapons.Add(new(type, quality, name));
        }
        public void AddAmmo(string type, int quantity)
        {
            AmmoInventory.Add(new(type, quantity));
        }
        public void SetClipQuantities()
        {
            foreach (CombatantWeapon weapon in Weapons)
            {
                weapon.CurrentClipQuantity = ReferenceData.ClipChart.GetStandardClipSize(weapon.Type);
            }
        }
        public void ReloadAllWeapons()
        {
            foreach (CombatantWeapon weapon in Weapons)
            {
                string ammoTypeNeededForThisWeapon = ReferenceData.WeaponRepository.FirstOrDefault(w => w.Type == weapon.Type).AmmoType;
                Ammo ammoInInventory = AmmoInventory.FirstOrDefault(a => a.Type == ammoTypeNeededForThisWeapon);
                if (ammoInInventory != null)
                {
                    int clipSize = ReferenceData.ClipChart.GetStandardClipSize(weapon.Type);
                    int quantityNeededToFillClip = clipSize - weapon.CurrentClipQuantity;
                    int ammoToAddToClip = ammoInInventory.Quantity < quantityNeededToFillClip ? ammoInInventory.Quantity : quantityNeededToFillClip;
                    ammoInInventory.Quantity -= ammoToAddToClip;
                    weapon.CurrentClipQuantity += ammoToAddToClip;
                }
            }
        }
        public void SetDisplayName(string letter = "")
        {
            if (!letter.IsNullOrEmpty()) { TrackerIndicator = letter; }
            DisplayName = $"{Name} {TrackerIndicator}";
        }
        public void OrganizeSkillsToCategories()
        {
            foreach (Skill skill in Skills)
            {
                switch (ReferenceData.SkillLinks.GetCategory(skill.Name))
                {
                    case ReferenceData.SkillCategoryAwareness:
                        AwarenessSkills.Add(skill);
                        break;
                    case ReferenceData.SkillCategoryBody:
                        BodySkills.Add(skill);
                        break;
                    case ReferenceData.SkillCategoryControl:
                        ControlSkills.Add(skill);
                        break;
                    case ReferenceData.SkillCategoryPerformance:
                        PerformanceSkills.Add(skill);
                        break;
                    case ReferenceData.SkillCategoryEducation:
                        EducationSkills.Add(skill);
                        break;
                    case ReferenceData.SkillCategoryFighting:
                        FightingSkills.Add(skill);
                        break;
                    case ReferenceData.SkillCategoryRangedWeapon:
                        RangedWeaponSkills.Add(skill);
                        break;
                    case ReferenceData.SkillCategorySocial:
                        SocialSkills.Add(skill);
                        break;
                    case ReferenceData.SkillCategoryTechnique:
                        TechniqueSkills.Add(skill);
                        break;
                    default:break;
                }
            }
        }
        public int GetSkillTotal(string skill)
        {
            int skillLevel = Skills.FirstOrDefault(s => s.Name == skill).Level;
            int statLevel = Stats.GetValue(ReferenceData.SkillLinks.First(s => s.SkillName == skill).StatName);
            return skillLevel + statLevel;
        }

        // Private Methods
        private void InitializeLists()
        {
            Stats = new();
            Skills = new();
            Weapons = new();
            AwarenessSkills = new();
            BodySkills = new();
            ControlSkills = new();
            PerformanceSkills = new();
            EducationSkills = new();
            FightingSkills = new();
            RangedWeaponSkills = new();
            SocialSkills = new();
            TechniqueSkills = new();
            AmmoInventory = new();
        }
        private void UpdateWoundState()
        {
            string woundState = ReferenceData.WoundStateUnharmed;
            if (CurrentHitPoints < MaximumHitPoints) { woundState = ReferenceData.WoundStateLightlyWounded; }
            if (CurrentHitPoints <= (MaximumHitPoints / 2)) { woundState = ReferenceData.WoundStateSeriouslyWounded; }
            if (CurrentHitPoints < 1) { woundState = ReferenceData.WoundStateMortallyWounded; }
            if (IsDead) { woundState = ReferenceData.WoundStateDead; }
            WoundState = woundState;
        }

    }
}
