using CyberpunkGameplayAssistant.Toolbox;
using CyberpunkGameplayAssistant.ViewModels;
using CyberpunkGameplayAssistant.Windows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace CyberpunkGameplayAssistant.Models
{
    [Serializable]
    public partial class Combatant : BaseModel
    {
        // Constructors
        public Combatant()
        {
            InitializeLists();
        }
        /// <summary>
        /// BLACK ICE PROGRAM
        /// </summary>
        /// <param name="name">Name of the program</param>
        /// <param name="imagePath">Image path for the program</param>
        public Combatant(string name, string imagePath)
        {
            InitializeLists();
            Name = name;
            PortraitFilePath = imagePath;
            Type = ReferenceData.BlackIce;
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
        public string Name
        {
            get => _Name;
            set => SetAndNotify(ref _Name, value);
        }
        private string _TrackerIndicator;
        public string TrackerIndicator
        {
            get => _TrackerIndicator;
            set => SetAndNotify(ref _TrackerIndicator, value);
        }
        private string _DisplayName;
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
        public int Initiative
        {
            get => _Initiative;
            set => SetAndNotify(ref _Initiative, value);
        }
        private string _Type;
        public string Type
        {
            get => _Type;
            set => SetAndNotify(ref _Type, value);
        }
        private bool _IsActive;
        public bool IsActive
        {
            get => _IsActive;
            set => SetAndNotify(ref _IsActive, value);
        }
        private ObservableCollection<Stat> _BaseStats;
        public ObservableCollection<Stat> BaseStats
        {
            get => _BaseStats;
            set => SetAndNotify(ref _BaseStats, value);
        }
        private ObservableCollection<Stat> _CalculatedStats;
        public ObservableCollection<Stat> CalculatedStats
        {
            get => _CalculatedStats;
            set => SetAndNotify(ref _CalculatedStats, value);
        }
        private ObservableCollection<Skill> _Skills;
        public ObservableCollection<Skill> Skills
        {
            get => _Skills;
            set => SetAndNotify(ref _Skills, value);
        }
        private ObservableCollection<Skill> _AwarenessSkills;
        public ObservableCollection<Skill> AwarenessSkills
        {
            get => _AwarenessSkills;
            set => SetAndNotify(ref _AwarenessSkills, value);
        }
        private ObservableCollection<Skill> _BodySkills;
        public ObservableCollection<Skill> BodySkills
        {
            get => _BodySkills;
            set => SetAndNotify(ref _BodySkills, value);
        }
        private ObservableCollection<Skill> _ControlSkills;
        public ObservableCollection<Skill> ControlSkills
        {
            get => _ControlSkills;
            set => SetAndNotify(ref _ControlSkills, value);
        }
        private ObservableCollection<Skill> _PerformanceSkills;
        public ObservableCollection<Skill> PerformanceSkills
        {
            get => _PerformanceSkills;
            set => SetAndNotify(ref _PerformanceSkills, value);
        }
        private ObservableCollection<Skill> _EducationSkills;
        public ObservableCollection<Skill> EducationSkills
        {
            get => _EducationSkills;
            set => SetAndNotify(ref _EducationSkills, value);
        }
        private ObservableCollection<Skill> _FightingSkills;
        public ObservableCollection<Skill> FightingSkills
        {
            get => _FightingSkills;
            set => SetAndNotify(ref _FightingSkills, value);
        }
        private ObservableCollection<Skill> _RangedWeaponSkills;
        public ObservableCollection<Skill> RangedWeaponSkills
        {
            get => _RangedWeaponSkills;
            set => SetAndNotify(ref _RangedWeaponSkills, value);
        }
        private ObservableCollection<Skill> _SocialSkills;
        public ObservableCollection<Skill> SocialSkills
        {
            get => _SocialSkills;
            set => SetAndNotify(ref _SocialSkills, value);
        }
        private ObservableCollection<Skill> _TechniqueSkills;
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
        public int MaximumHeadStoppingPower
        {
            get => _MaximumHeadStoppingPower;
            set => SetAndNotify(ref _MaximumHeadStoppingPower, value);
        }
        private int _MaximumBodyStoppingPower;
        public int MaximumBodyStoppingPower
        {
            get => _MaximumBodyStoppingPower;
            set => SetAndNotify(ref _MaximumBodyStoppingPower, value);
        }
        private int _CurrentHeadStoppingPower;
        public int CurrentHeadStoppingPower
        {
            get => _CurrentHeadStoppingPower;
            set => SetAndNotify(ref _CurrentHeadStoppingPower, value);
        }
        private int _CurrentBodyStoppingPower;
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
        private bool _ActionMenuOpen;
        public bool ActionMenuOpen
        {
            get => _ActionMenuOpen;
            set => SetAndNotify(ref _ActionMenuOpen, value);
        }
        private bool _InjuryMenuOpen;
        public bool InjuryMenuOpen
        {
            get => _InjuryMenuOpen;
            set => SetAndNotify(ref _InjuryMenuOpen, value);
        }
        private ObservableCollection<Ammo> _AmmoInventory;
        public ObservableCollection<Ammo> AmmoInventory
        {
            get => _AmmoInventory;
            set => SetAndNotify(ref _AmmoInventory, value);
        }
        private ObservableCollection<Gear> _GearInventory;
        public ObservableCollection<Gear> GearInventory
        {
            get => _GearInventory;
            set => SetAndNotify(ref _GearInventory, value);
        }
        private ObservableCollection<Cyberware> _InstalledCyberware;
        public ObservableCollection<Cyberware> InstalledCyberware
        {
            get => _InstalledCyberware;
            set => SetAndNotify(ref _InstalledCyberware, value);
        }
        private ObservableCollection<CyberdeckProgram> _CyberdeckPrograms;
        public ObservableCollection<CyberdeckProgram> CyberdeckPrograms
        {
            get => _CyberdeckPrograms;
            set => SetAndNotify(ref _CyberdeckPrograms, value);
        }
        private bool _IsDead;
        public bool IsDead
        {
            get => _IsDead;
            set => SetAndNotify(ref _IsDead, value);
        }
        private ObservableCollection<Action> _StandardActions;
        public ObservableCollection<Action> StandardActions
        {
            get => _StandardActions;
            set => SetAndNotify(ref _StandardActions, value);
        }
        private ObservableCollection<CriticalInjury> _CriticalInjuries;
        public ObservableCollection<CriticalInjury> CriticalInjuries
        {
            get => _CriticalInjuries;
            set => SetAndNotify(ref _CriticalInjuries, value);
        }
        public int MoveSpeed
        {
            get
            {
                int move = CalculatedStats.GetValue(ReferenceData.StatMovement);
                int penalty = ReferenceData.ArmorTable.GetPenalty(ArmorType);
                penalty += CriticalInjuries.GetMovePenaltyTotal();
                penalty += ReferenceData.ArmorTable.GetPenalty(ArmorType);
                move -= penalty;
                if (move < 1) { move = 1; }
                return move;
            }
        }
        public int DeathSave
        {
            get
            {
                int death = CalculatedStats.GetValue(ReferenceData.StatBody);
                return death;
            }
        }
        private int _DeathSavePasses;
        public int DeathSavePasses
        {
            get => _DeathSavePasses;
            set => SetAndNotify(ref _DeathSavePasses, value);
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
        public ICommand ToggleDeath => new RelayCommand(DoToggleDeath);
        private void DoToggleDeath(object param)
        {
            IsDead = !IsDead;
            UpdateWoundState();
        }
        public ICommand AddCriticalInjury => new RelayCommand(DoAddCriticalInjury);
        private void DoAddCriticalInjury(object param)
        {
            MultiObjectSelectionDialog selectionDialog = new(ReferenceData.AllCriticalInjuries.ToNamedRecordList(), ReferenceData.MultiModeCriticalInjuries);

            if (selectionDialog.ShowDialog() == true)
            {
                foreach (NamedRecord record in (selectionDialog.DataContext as MultiObjectSelectionViewModel).SelectedRecords)
                {
                    if (CriticalInjuries.FirstOrDefault(c => c.Name == record.Name) != null) { continue; }
                    else
                    {
                        CriticalInjuries.Add(record.ToCriticalInjury());
                    }
                }
                NotifyPropertyChanged(nameof(MoveSpeed));
            }
        }
        public ICommand MakeActive => new RelayCommand(DoMakeActive);
        private void DoMakeActive(object param)
        {
            IsActive = true;
            ReferenceData.MainModelRef.CampaignView.ActiveCampaign.MarkCombatantsInactiveExcept(this);
            ReferenceData.MainModelRef.CampaignView.ActiveCampaign.UpdateActiveCombatant();
        }
        public ICommand DeletePlayer => new RelayCommand(DoDeletePlayer);
        private void DoDeletePlayer(object param)
        {
            ReferenceData.MainModelRef.CampaignView.ActiveCampaign.Players.Remove(this);
        }
        public ICommand SelectPortraitImage => new RelayCommand(DoSelectPortraitImage);
        private void DoSelectPortraitImage(object param)
        {
            PortraitFilePath = HelperMethods.GetFile(ReferenceData.FilterImageFiles, ReferenceData.PlayerImageDirectory);
        }
        public ICommand RemoveFromFirefight => new RelayCommand(DoRemoveFromFirefight);
        private void DoRemoveFromFirefight(object param)
        {
            ReferenceData.MainModelRef.CampaignView.ActiveCampaign.AllCombatants.Remove(this);
            ReferenceData.MainModelRef.CampaignView.ActiveCampaign.SortCombatants.Execute(null);
        }

        // Public Methods
        public void InitializeLoadedCombatant()
        {
            SetCalculatedStats();
            SetHitPoints(false);
            SetStoppingPower(false);
            UpdateWoundState();
            UpdateGearDescriptions();
            UpdateCyberwareDescriptions();
            OrganizeSkillsToCategories();
            SetStandardActions();
            GetCriticalInjuryDescriptions();
        }
        public void InitializeNewCombatant()
        {
            SetHitPoints(true);
            SetStoppingPower(true);
            ReloadAllWeapons();
            SetStandardActions();
        }
        public void SetStats(int INT, int REF, int DEX, int TECH, int COOL, int WILL, int LUCK, int MOVE, int BODY, int EMP)
        {
            BaseStats = new();
            BaseStats.Add(new(ReferenceData.StatIntelligence, INT));
            BaseStats.Add(new(ReferenceData.StatReflexes, REF));
            BaseStats.Add(new(ReferenceData.StatDexterity, DEX));
            BaseStats.Add(new(ReferenceData.StatTechnique, TECH));
            BaseStats.Add(new(ReferenceData.StatCool, COOL));
            BaseStats.Add(new(ReferenceData.StatWillpower, WILL));
            BaseStats.Add(new(ReferenceData.StatLuck, LUCK));
            BaseStats.Add(new(ReferenceData.StatMovement, MOVE));
            BaseStats.Add(new(ReferenceData.StatBody, BODY));
            BaseStats.Add(new(ReferenceData.StatEmpathy, EMP));
        }
        public void SetBlackIceStats(string role, int PER, int SPD, int ATK, int DEF, int REZ, string effect)
        {
            PlayerRole = role;
            BaseStats = new();
            BaseStats.Add(new(ReferenceData.NetPerception, PER));
            BaseStats.Add(new(ReferenceData.NetSpeed, SPD));
            BaseStats.Add(new(ReferenceData.NetAttack, ATK));
            BaseStats.Add(new(ReferenceData.NetDefense, DEF));
            MaximumHitPoints = REZ;
            CurrentHitPoints = REZ;
            Notes = effect;
        }
        public void SetDemonStats(int REZ, int INT, int netActions, int combatNumber)
        {
            Type = ReferenceData.Demon;
            PlayerRole = ReferenceData.Demon;
            Notes = netActions.ToString();
            BaseStats = new();
            BaseStats.Add(new(ReferenceData.SkillInterface, INT));
            BaseStats.Add(new(ReferenceData.SkillCombatNumber, combatNumber));
            MaximumHitPoints = REZ;
            CurrentHitPoints = REZ;
        }
        public void SetActiveDefenseStats(int MOVE, int HP, int DV)
        {
            Type = ReferenceData.ActiveDefense;
            Notes = MOVE.ToString();
            PlayerRole = DV.ToString();
            MaximumHitPoints = HP;
            CurrentHitPoints = HP;
        }
        public void SetEmplacedDefenseStats(int combatNumber, int HP, int DV, string note = "")
        {
            Type = ReferenceData.EmplacedDefense;
            PlayerRole = DV.ToString();
            Notes = note;
            BaseStats = new();
            BaseStats.Add(new(ReferenceData.SkillCombatNumber, combatNumber));
            MaximumHitPoints = HP;
            CurrentHitPoints = HP;
        }
        public void SetCalculatedStats()
        {
            CalculatedStats = new();
            List<string> statsAffectedByArmorPenalty = new() { ReferenceData.StatReflexes, ReferenceData.StatDexterity, ReferenceData.StatMovement };
            foreach (Stat stat in BaseStats)
            {
                Stat statToAdd = stat.DeepClone();
                if (statsAffectedByArmorPenalty.Contains(stat.Name)) { statToAdd.Value -= ReferenceData.ArmorTable.GetPenalty(ArmorType); }
                CalculatedStats.Add(statToAdd);
            }
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
                int level = value - CalculatedStats.GetValue(ReferenceData.SkillLinks.First(s => s.SkillName == name).StatName);
                Skills.Add(new(name, variant, level));
            }
            else
            {
                skill.Level = value - CalculatedStats.GetValue(ReferenceData.SkillLinks.First(s => s.SkillName== name).StatName);
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
        public void AddGearSet(params string[] names)
        {
            foreach (string name in names)
            {
                AddGear(name);
            }
        }
        public void AddCyberwareSet(params string[] names)
        {
            foreach (string name in names)
            {
                AddCyberware(name);
            }
        }
        public void SetClipQuantities()
        {
            foreach (CombatantWeapon weapon in Weapons)
            {
                weapon.CurrentClipQuantity = ReferenceData.ClipChart.GetStandardClipSize(weapon.Type);
            }
        }
        
        public void SetDisplayName(string letter = "")
        {
            if (!letter.IsNullOrEmpty()) { TrackerIndicator = letter; }
            DisplayName = $"{Name} {TrackerIndicator}";
        }
        
        public int GetSkillTotal(string skill)
        {
            if (Type == ReferenceData.ActiveDefense) { return GetDemonCombatNumber(); }
            if (Type == ReferenceData.EmplacedDefense) { return GetDemonCombatNumber(); }
            int skillLevel = Skills.FirstOrDefault(s => s.Name == skill).Level;
            int statLevel = CalculatedStats.GetValue(ReferenceData.SkillLinks.First(s => s.SkillName == skill).StatName);
            return skillLevel + statLevel;
        }
        public void UpdateGearDescriptions()
        {
            foreach (Gear gear in GearInventory)
            {
                gear.Description = ReferenceData.MasterGearList[gear.Name];
            }
        }
        public void UpdateCyberwareDescriptions()
        {
            foreach (Cyberware cyberware in InstalledCyberware)
            {
                cyberware.Description = ReferenceData.MasterCyberwareList[cyberware.Name];
            }
        }
        public int GetInitiative()
        {
            if (Type == ReferenceData.Player) { return Initiative; }
            int reflex = CalculatedStats.GetValue(ReferenceData.StatReflexes);
            reflex -= ReferenceData.ArmorTable.GetPenalty(ArmorType);
            return HelperMethods.RollD10() + reflex;
        }
        public void UpdateWoundState()
        {
            if (Type == ReferenceData.BlackIce || Type == ReferenceData.Demon) { UpdateBlackIceWoundState(); return; }
            if (Type == ReferenceData.ActiveDefense || Type == ReferenceData.EmplacedDefense) { UpdateDefenseWoundState(); return; }
            string woundState = ReferenceData.WoundStateUnharmed;
            if (CurrentHitPoints < MaximumHitPoints) { woundState = ReferenceData.WoundStateLightlyWounded; }
            if (CurrentHitPoints <= (MaximumHitPoints / 2)) { woundState = ReferenceData.WoundStateSeriouslyWounded; }
            if (CurrentHitPoints < 1) { woundState = ReferenceData.WoundStateMortallyWounded; }
            if (IsDead) { woundState = ReferenceData.WoundStateDead; }
            WoundState = woundState;
        }
        public void UpdateBlackIceWoundState()
        {
            string woundState = ReferenceData.ProgramStateRezzed;
            if (CurrentHitPoints == 0) { woundState = ReferenceData.ProgramStateDerezzed; }
            WoundState = woundState;
        }
        public void UpdateDefenseWoundState()
        {
            string woundState = ReferenceData.DefenseStateOperational;
            if (CurrentHitPoints == 0) { woundState = ReferenceData.DefenseStateDestroyed; }
            WoundState = woundState;
        }
        public void ReadyUpActiveDefense(int count)
        {
            SetDisplayName(HelperMethods.GetAlphabetLetter(count));
            Initiative = 60; // Top(er) of the order force
            UpdateWoundState();
            ReloadAllWeapons();
        }

        // Private Methods
        private void InitializeLists()
        {
            BaseStats = new();
            CalculatedStats = new();
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
            GearInventory = new();
            InstalledCyberware = new();
            StandardActions = new();
            CriticalInjuries = new();
        }
        private void AddGear(string name)
        {
            if (GearInventory.FirstOrDefault(g => g.Name == name) != null)
            {
                GearInventory.First(g => g.Name == name).Quantity++;
                return;
            }
            GearInventory.Add(new(name));
        }
        private void AddCyberware(string name)
        {
            InstalledCyberware.Add(new(name));
        }
        private void SetStoppingPower(bool setCurrentToMax)
        {
            MaximumHeadStoppingPower = ReferenceData.ArmorTable.GetStoppingPower(ArmorType);
            MaximumBodyStoppingPower = ReferenceData.ArmorTable.GetStoppingPower(ArmorType);
            if (setCurrentToMax)
            {
                CurrentHeadStoppingPower = MaximumHeadStoppingPower;
                CurrentBodyStoppingPower = MaximumBodyStoppingPower;
            }
        }
        private void ReloadAllWeapons()
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
        private void SetHitPoints(bool setCurrentToMax)
        {
            int body = CalculatedStats.GetValue(ReferenceData.StatBody);
            int willpower = CalculatedStats.GetValue(ReferenceData.StatWillpower);
            MaximumHitPoints = 10 + (5 * ((body + willpower) / 2));
            if (setCurrentToMax)
            {
                CurrentHitPoints = MaximumHitPoints;
            }
        }
        private void OrganizeSkillsToCategories()
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
                    default: break;
                }
            }
        }
        private void GetCriticalInjuryDescriptions()
        {
            foreach (CriticalInjury injury in CriticalInjuries)
            {
                CriticalInjury bodyInjury = ReferenceData.CriticalInjuriesToBody.FirstOrDefault(i => i.Name == injury.Name)!;
                CriticalInjury headInjury = ReferenceData.CriticalInjuriesToHead.FirstOrDefault(i => i.Name == injury.Name)!;
                if (bodyInjury != null) { injury.Description = bodyInjury.Description; }
                if (headInjury != null) { injury.Description = headInjury.Description; }
            }
        }
        private void SetStandardActions()
        {
            StandardActions.Clear();
            StandardActions.Add(new(ReferenceData.ActionBrawl));
            StandardActions.Add(new(ReferenceData.ActionChoke));
            StandardActions.Add(new(ReferenceData.ActionDeathSave));
            StandardActions.Add(new(ReferenceData.ActionEvade));
            StandardActions.Add(new(ReferenceData.ActionGrab));
            StandardActions.Add(new(ReferenceData.ActionInitiative));
            StandardActions.Add(new(ReferenceData.ActionThrowGrapple));
            StandardActions.Add(new(ReferenceData.ActionThrowObject));
        }
        private int GetDemonCombatNumber()
        {
            Combatant demon = ReferenceData.MainModelRef.CampaignView.ActiveCampaign.AllCombatants.FirstOrDefault(c => c.Type == ReferenceData.Demon);
            if (demon == null) { HelperMethods.NotifyUser(ReferenceData.ErrorNoDemonAvailableForActiveDefense); return 0; }
            else
            {
                return demon.BaseStats.GetValue(ReferenceData.SkillCombatNumber);
            }
        }

    }
}
