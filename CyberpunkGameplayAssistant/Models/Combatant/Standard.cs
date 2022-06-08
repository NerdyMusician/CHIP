using CyberpunkGameplayAssistant.Toolbox;
using CyberpunkGameplayAssistant.Toolbox.ExtensionMethods;
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
        public Combatant(string name, string type, string @class, string imagePath, string armor)
        {
            InitializeLists();
            Type = type;
            Name = name;
            ComClass = @class;
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
        private string _Variant;
        public string Variant
        {
            get => _Variant;
            set => SetAndNotify(ref _Variant, value);
        }
        private string _ComClass;
        public string ComClass
        {
            get => _ComClass;
            set => SetAndNotify(ref _ComClass, value);
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
        private bool _IsAlly;
        public bool IsAlly
        {
            get => _IsAlly;
            set => SetAndNotify(ref _IsAlly, value);
        }
        private bool _CanNetrun;
        public bool CanNetrun
        {
            get => _CanNetrun;
            set => SetAndNotify(ref _CanNetrun, value);
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
        private ObservableCollection<Skill> _SkillBases;
        public ObservableCollection<Skill> SkillBases
        {
            get => _SkillBases;
            set => SetAndNotify(ref _SkillBases, value);
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

        private string _ShieldType;
        public string ShieldType
        {
            get => _ShieldType;
            set => SetAndNotify(ref _ShieldType, value);
        }
        private int _ShieldHp;
        public int ShieldHp
        {
            get => _ShieldHp;
            set => SetAndNotify(ref _ShieldHp, value);
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
        private bool _ActiveWeaponMenuOpen;
        public bool ActiveWeaponMenuOpen
        {
            get => _ActiveWeaponMenuOpen;
            set => SetAndNotify(ref _ActiveWeaponMenuOpen, value);
        }
        private bool _ActiveStatSkillMenuOpen;
        public bool ActiveStatSkillMenuOpen
        {
            get => _ActiveStatSkillMenuOpen;
            set => SetAndNotify(ref _ActiveStatSkillMenuOpen, value);
        }
        private bool _ActiveActionMenuOpen;
        public bool ActiveActionMenuOpen
        {
            get => _ActiveActionMenuOpen;
            set => SetAndNotify(ref _ActiveActionMenuOpen, value);
        }
        private bool _ActiveInjuryMenuOpen;
        public bool ActiveInjuryMenuOpen
        {
            get => _ActiveInjuryMenuOpen;
            set => SetAndNotify(ref _ActiveInjuryMenuOpen, value);
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
                int move = CalculatedStats.GetValue(AppData.StatMovement);
                int penalty = 0;
                if (WoundState == AppData.WoundStateMortallyWounded) { penalty += 6; }
                penalty += CriticalInjuries.GetMovePenaltyTotal();
                move -= penalty;
                if (move < 1) { move = 1; }
                return move;
            }
        }
        public int DeathSave
        {
            get
            {
                int death = CalculatedStats.GetValue(AppData.StatBody);
                return death;
            }
        }
        private int _DeathSavePasses;
        public int DeathSavePasses
        {
            get => _DeathSavePasses;
            set => SetAndNotify(ref _DeathSavePasses, value);
        }
        private int _TotalStatPoints;
        public int TotalStatPoints
        {
            get => _TotalStatPoints;
            set => SetAndNotify(ref _TotalStatPoints, value);
        }
        private int _BypassDv;
        public int BypassDv
        {
            get => _BypassDv;
            set => SetAndNotify(ref _BypassDv, value);
        }
        private int _NetActionCount;
        public int NetActionCount
        {
            get => _NetActionCount;
            set => SetAndNotify(ref _NetActionCount, value);
        }
        private string _BlackIceType;
        public string BlackIceType
        {
            get => _BlackIceType;
            set => SetAndNotify(ref _BlackIceType, value);
        }
        private bool _ShowWeapons;
        public bool ShowWeapons
        {
            get => _ShowWeapons;
            set => SetAndNotify(ref _ShowWeapons, value);
        }
        private bool _ShowNotes;
        public bool ShowNotes
        {
            get => _ShowNotes;
            set => SetAndNotify(ref _ShowNotes, value);
        }
        private bool _ShowHitPoints;
        public bool ShowHitPoints
        {
            get => _ShowHitPoints;
            set => SetAndNotify(ref _ShowHitPoints, value);
        }
        private bool _ShowBypassDv;
        public bool ShowBypassDv
        {
            get => _ShowBypassDv;
            set => SetAndNotify(ref _ShowBypassDv, value);
        }
        private bool _ShowNetActionCount;
        public bool ShowNetActionCount
        {
            get => _ShowNetActionCount;
            set => SetAndNotify(ref _ShowNetActionCount, value);
        }
        private bool _ShowBlackIceType;
        public bool ShowBlackIceType
        {
            get => _ShowBlackIceType;
            set => SetAndNotify(ref _ShowBlackIceType, value);
        }

        // Dropdown Sources
        public List<string> ShieldTypes
        {
            get
            {
                return new()
                {
                    AppData.ShieldTypeNone,
                    AppData.ShieldTypeBulletproofShield,
                    AppData.ShieldTypeCorpse,
                    AppData.ShieldTypeHumanShield
                };
            }
        }

        // Commands
        public ICommand DuplicateCombatant => new RelayCommand(DoDuplicateCombatant);
        private void DoDuplicateCombatant(object param)
        {
            Combatant duplicatedCombatant = this.DeepClone();
            duplicatedCombatant.Name += " (Copy)";
            AppData.MainModelRef.CombatantView.Combatants.Add(duplicatedCombatant);
            AppData.MainModelRef.CombatantView.ActiveCombatant = duplicatedCombatant;
            RaiseAlert($"Combatant \"{Name}\" duplicated");
        }
        public ICommand DeleteCombatant => new RelayCommand(DoDeleteCombatant);
        private void DoDeleteCombatant(object param)
        {
            if (!HelperMethods.AskYesNoQuestion($"Delete Combatant \"{Name}\"?")) { return; }
            AppData.MainModelRef.CombatantView.Combatants.Remove(this);
            AppData.MainModelRef.CombatantView.ActiveCombatant = null;
            RaiseAlert($"Combatant \"{Name}\" deleted");
        }
        public ICommand AdjustHitPoints => new RelayCommand(DoAdjustHitPoints);
        private void DoAdjustHitPoints(object param)
        {
            int hitPointChange = Convert.ToInt32(param);
            CurrentHitPoints += hitPointChange;
            if (CurrentHitPoints < 0) { CurrentHitPoints = 0; }
            if (CurrentHitPoints > MaximumHitPoints) { CurrentHitPoints = MaximumHitPoints; }
            UpdateWoundState();
        }
        public ICommand AdjustShieldHp => new RelayCommand(DoAdjustShieldHp);
        private void DoAdjustShieldHp(object param)
        {
            int hitPointChange = Convert.ToInt32(param);
            ShieldHp += hitPointChange;
            if (ShieldHp < 0) { ShieldHp = 0; ShieldType = AppData.ShieldTypeNone; }
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
        public ICommand ToggleAlly => new RelayCommand(DoToggleAlly);
        private void DoToggleAlly(object param)
        {
            IsAlly = !IsAlly;
        }
        public ICommand AddCriticalInjury => new RelayCommand(DoAddCriticalInjury);
        private void DoAddCriticalInjury(object param)
        {
            MultiObjectSelectionDialog selectionDialog = new(AppData.AllCriticalInjuries.ToNamedRecordList(), AppData.MultiModeCriticalInjuries);

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
            AppData.MainModelRef.CampaignView.ActiveCampaign.MarkCombatantsInactiveExcept(this);
            AppData.MainModelRef.CampaignView.ActiveCampaign.UpdateActiveCombatant();
        }
        public ICommand DeletePlayer => new RelayCommand(DoDeletePlayer);
        private void DoDeletePlayer(object param)
        {
            AppData.MainModelRef.CampaignView.ActiveCampaign.Players.Remove(this);
        }
        public ICommand SelectPortraitImage => new RelayCommand(DoSelectPortraitImage);
        private void DoSelectPortraitImage(object param)
        {
            PortraitFilePath = HelperMethods.GetFile(AppData.FilterImageFiles, AppData.PlayerImageDirectory);
        }
        public ICommand RemoveFromFirefight => new RelayCommand(DoRemoveFromFirefight);
        private void DoRemoveFromFirefight(object param)
        {
            AppData.MainModelRef.CampaignView.ActiveCampaign.AllCombatants.Remove(this);
            AppData.MainModelRef.CampaignView.ActiveCampaign.SortCombatants.Execute(null);
        }
        public ICommand SetImage => new RelayCommand(DoSetImage);
        private void DoSetImage(object param)
        {
            if (param == null) { return; }
            string paramClass = "Class";
            string paramCustom = "Custom";
            if (param.ToString() == paramClass)
            {
                SetImageByClass();
            }
            if (param.ToString() == paramCustom)
            {
                SetCustomImage();
            }
        }
        public ICommand AddSkills => new RelayCommand(DoAddSkills);
        private void DoAddSkills(object param)
        {
            MultiObjectSelectionDialog selectionDialog = new(AppData.AllSkills.ToNamedRecordList(), "Skills");

            if (selectionDialog.ShowDialog() == true)
            {
                foreach (NamedRecord selectedRecord in (selectionDialog.DataContext as MultiObjectSelectionViewModel)!.SelectedRecords)
                {
                    Skills.Add(new(selectedRecord.Name));
                }
            }
        }
        public ICommand AddBuilderWeapons => new RelayCommand(DoAddBuilderWeapons);
        private void DoAddBuilderWeapons(object param)
        {
            MultiObjectSelectionDialog selectionDialog = new(AppData.AllWeaponTypes.ToNamedRecordList(), "Skills");

            if (selectionDialog.ShowDialog() == true)
            {
                foreach (NamedRecord selectedRecord in (selectionDialog.DataContext as MultiObjectSelectionViewModel)!.SelectedRecords)
                {
                    Weapons.Add(new(selectedRecord.Name, AppData.WeaponQualityStandard));
                }
            }
        }
        public ICommand AddAmmunition => new RelayCommand(DoAddAmmunition);
        private void DoAddAmmunition(object param)
        {
            AmmoInventory.Add(new());
        }
        public ICommand AddPresetAmmunition => new RelayCommand(DoAddPresetAmmunition);
        private void DoAddPresetAmmunition(object param)
        {
            AddBasicAmmoForAllWeapons(3);
        }
        public ICommand AddBuilderGear => new RelayCommand(DoAddBuilderGear);
        private void DoAddBuilderGear(object param)
        {
            MultiObjectSelectionDialog selectionDialog = new(AppData.MasterGearList.ToNamedRecordList(), "Gear");

            if (selectionDialog.ShowDialog() == true)
            {
                foreach (NamedRecord selectedRecord in (selectionDialog.DataContext as MultiObjectSelectionViewModel)!.SelectedRecords)
                {
                    AddGear(selectedRecord.Name);
                }
            }
        }
        public ICommand AddBuilderCyberware => new RelayCommand(DoAddBuilderCyberware);
        private void DoAddBuilderCyberware(object param)
        {
            MultiObjectSelectionDialog selectionDialog = new(AppData.MasterCyberwareList.ToNamedRecordList(), "Cyberware");

            if (selectionDialog.ShowDialog() == true)
            {
                foreach (NamedRecord selectedRecord in (selectionDialog.DataContext as MultiObjectSelectionViewModel)!.SelectedRecords)
                {
                    AddCyberware(selectedRecord.Name);
                }
            }
        }
        public ICommand AddBuilderPrograms => new RelayCommand(DoAddBuilderPrograms);
        private void DoAddBuilderPrograms(object param)
        {
            MultiObjectSelectionDialog selectionDialog = new(AppData.CyberdeckPrograms.ToNamedRecordList(), "Programs");

            if (selectionDialog.ShowDialog() == true)
            {
                foreach (NamedRecord selectedRecord in (selectionDialog.DataContext as MultiObjectSelectionViewModel)!.SelectedRecords)
                {
                    AddCyberdeckProgram(selectedRecord.Name);
                }
            }
        }
        public ICommand CalculateDerivedStats => new RelayCommand(DoCalculateDerivedStats);
        private void DoCalculateDerivedStats(object param)
        {
            SetCalculatedStats();
            SetHitPoints(false);
            TotalStatPoints = BaseStats.GetTotal();
        }
        public ICommand SortSkills => new RelayCommand(DoSortSkills);
        private void DoSortSkills(object param)
        {
            Skills = (AppData.MainModelRef.SettingsView.SkillsByBase) ? new(Skills.OrderBy(s => s.Name)) : new(Skills.OrderBy(s => s.Level).ThenBy(s => s.Name));
        }

        // Public Methods
        public void InitializeLoadedCombatant()
        {
            SetInitiative();
            SetCalculatedStats();
            SetHitPoints(true);
            SetStoppingPower(true);
            UpdateWoundState();
            UpdateGearDescriptions();
            UpdateCyberwareDescriptions();
            if (AppData.MainModelRef.SettingsView.SkillsByBase) { RecalculateSkillsByBase(); }
            AddRemainingSkills();
            OrganizeSkillsToCategories();
            PrepareWeapons();
            SetStandardActions();
            if (CanNetrun) { SetNetActions(); }
            GetCriticalInjuryDescriptions();
        }
        private void RecalculateSkillsByBase()
        {
            List<Skill> skillsByLevel = Skills.DeepClone().ToList();
            Skills.Clear();
            foreach (Skill skill in skillsByLevel)
            {
                int @base = skill.Level;
                int stat = CalculatedStats.GetValue(AppData.SkillLinks.GetStat(skill.Name));
                int level = @base - stat;
                if (level < 0) { level = 0; }
                Skills.Add(new() { Name = skill.Name, Level = level });
            }
        }
        public void InitializeCustomCombatant()
        {
            PortraitFilePath = AppData.PortraitDefault;
            BaseStats = new();
            if (Type == AppData.ComTypeStandard)
            {
                Name = "New Combatant";
                ArmorType = AppData.ArmorTypeNone;
                ShowWeapons = true;
                BaseStats.Add(new(AppData.StatIntelligence, 0));
                BaseStats.Add(new(AppData.StatReflexes, 0));
                BaseStats.Add(new(AppData.StatDexterity, 0));
                BaseStats.Add(new(AppData.StatTechnique, 0));
                BaseStats.Add(new(AppData.StatCool, 0));
                BaseStats.Add(new(AppData.StatWillpower, 0));
                BaseStats.Add(new(AppData.StatLuck, 0));
                BaseStats.Add(new(AppData.StatMovement, 0));
                BaseStats.Add(new(AppData.StatBody, 0));
                BaseStats.Add(new(AppData.StatEmpathy, 0));
            }
            if (Type == AppData.ComTypeEmplacedDefense)
            {
                Name = "New Emplaced Defense";
                SetNonStandardFields();
                ShowWeapons = true;
                ShowBypassDv = true;
                BaseStats.Add(new(AppData.SkillCombatNumber, 0));
            }
            if (Type == AppData.ComTypeActiveDefense)
            {
                Name = "New Active Defense";
                SetNonStandardFields();
                ShowWeapons = true;
                ShowBypassDv = true;
                BaseStats.Add(new(AppData.StatMovement, 0));
            }
            if (Type == AppData.ComTypeBlackIce)
            {
                Name = "New Black ICE";
                SetNonStandardFields();
                ShowBlackIceType = true;
                BaseStats.Add(new(AppData.NetPerception, 0));
                BaseStats.Add(new(AppData.NetSpeed, 0));
                BaseStats.Add(new(AppData.NetAttack, 0));
                BaseStats.Add(new(AppData.NetDefense, 0));
            }
            if (Type == AppData.ComTypeDemon)
            {
                Name = "New Demon";
                SetNonStandardFields();
                ShowNetActionCount = true;
                BaseStats.Add(new(AppData.SkillInterface, 0));
                BaseStats.Add(new(AppData.SkillCombatNumber, 0));
            }
        }
        private void SetNonStandardFields()
        {
            ShowHitPoints = true;
            ShowNotes = true;
            ComClass = Type;
        }
        public void SetCalculatedStats()
        {
            CalculatedStats = new();
            List<string> statsAffectedByArmorPenalty = new() { AppData.StatReflexes, AppData.StatDexterity, AppData.StatMovement };
            foreach (Stat stat in BaseStats)
            {
                Stat statToAdd = stat.DeepClone();
                if (statsAffectedByArmorPenalty.Contains(stat.Name)) { statToAdd.Value -= AppData.ArmorTable.GetPenalty(ArmorType); }
                CalculatedStats.Add(statToAdd);
            }
        }
        public void SetClassSkills() // TODO - UI replacement for this functionality
        {
            if (string.IsNullOrEmpty(ComClass)) { HelperMethods.WriteToLogFile($"No ComClass set for {Name}"); return; }
            if (ComClass == AppData.ComClassCivilian)
            {
                // Should civies have extra skills?
            }
            if (ComClass.IsIn(AppData.ComClassLightPolice, AppData.ComClassMediumPolice, AppData.ComClassHeavyPolice))
            {
                SetSkillLevels(2, AppData.SkillConcealRevealObject, AppData.SkillTracking, AppData.SkillStealth, AppData.SkillCriminology, AppData.SkillBasicTech, AppData.SkillWeaponstech, AppData.SkillLandVehicleTech);
                SetSkillLevels(3, AppData.SkillAthletics, AppData.SkillResistTortureDrugs, AppData.SkillTactics, AppData.SkillInterrogation, AppData.SkillFirstAid);
                SetSkillLevels(4, AppData.SkillPerception, AppData.SkillEndurance, AppData.SkillDriveLandVehicle);
                SetSkillLevels(5, AppData.SkillBrawling, AppData.SkillEvasion);
                SetSkillLevels(6, AppData.SkillHandgun, AppData.SkillShoulderArms);
            }
            if (ComClass.IsIn(AppData.ComClassLightCorpo, AppData.ComClassMediumCorpo, AppData.ComClassHeavyCorpo))
            {
                // TODO - Corpo Skills and Ganger Skills
            }
        }
        public void AddWeapon(string type, string quality = "", string name = "")
        {
            if (string.IsNullOrEmpty(quality)) { quality = AppData.WeaponQualityStandard; }
            Weapons.Add(new(type, quality, name));
        }
        public void AddBasicAmmoForAllWeapons(int numberOfClips)
        {
            bool ammoAdded = false;
            foreach (CombatantWeapon weapon in Weapons)
            {
                if (!weapon.UsesAmmo) { continue; }
                Weapon weaponData = AppData.WeaponRepository.FirstOrDefault(w => w.Type == weapon.Type)!;
                RangedWeaponClip clipData = AppData.ClipChart.FirstOrDefault(c => c.WeaponType == weapon.Type)!;
                AddAmmo(weaponData.AmmoType, clipData.Standard * numberOfClips);
                ammoAdded = true;
            }
            if (ammoAdded) { RaiseAlert("Ammo added to combatant"); } else { RaiseError("No ammo added"); }
        }
        public void AddAmmo(string type, int quantity, string variant = "")
        {
            if (string.IsNullOrEmpty(variant)) { variant = AppData.AmmoVarBasic; }
            Ammo existingEntry = AmmoInventory.FirstOrDefault(a => a.Type == type && a.Variant == variant);
            if (existingEntry != null) { existingEntry.Quantity += quantity; }
            else
            {
                AmmoInventory.Add(new(type, quantity, variant));
            }
        }
        public void AddShield()
        {
            ShieldType = AppData.ShieldTypeBulletproofShield;
            ShieldHp = 10;
        } // TODO - UI for shields, perhaps just set based on gear in inventory?
        public void SetDisplayName(string letter = "")
        {
            if (!letter.IsNullOrEmpty()) { TrackerIndicator = letter; }
            DisplayName = $"{Name} {TrackerIndicator}";
        }
        public int GetSkillTotal(string skill)
        {
            if (Type == AppData.ComTypeActiveDefense) { return GetDemonCombatNumber(); }
            if (Type == AppData.ComTypeEmplacedDefense) { return BaseStats.GetValue(AppData.SkillCombatNumber); }
            int skillLevel = Skills.FirstOrDefault(s => s.Name == skill).Level;
            int statLevel = CalculatedStats.GetValue(AppData.SkillLinks.First(s => s.SkillName == skill).StatName);
            return skillLevel + statLevel;
        }
        public void UpdateGearDescriptions()
        {
            foreach (Gear gear in GearInventory)
            {
                gear.Description = AppData.MasterGearList[gear.Name];
            }
        }
        public void UpdateCyberwareDescriptions()
        {
            foreach (Cyberware cyberware in InstalledCyberware)
            {
                cyberware.Description = AppData.MasterCyberwareList[cyberware.Name];
            }
        }
        public int GetInitiative()
        {
            if (Type == AppData.ComTypePlayer) { return Initiative; }
            int reflex = CalculatedStats.GetValue(AppData.StatReflexes);
            reflex -= AppData.ArmorTable.GetPenalty(ArmorType);
            return HelperMethods.RollD10() + reflex;
        }
        public void UpdateWoundState()
        {
            if (Type == AppData.ComTypeBlackIce || Type == AppData.ComTypeDemon) { UpdateBlackIceWoundState(); return; }
            if (Type == AppData.ComTypeActiveDefense || Type == AppData.ComTypeEmplacedDefense) { UpdateDefenseWoundState(); return; }
            string woundState = AppData.WoundStateUnharmed;
            if (CurrentHitPoints < MaximumHitPoints) { woundState = AppData.WoundStateLightlyWounded; }
            if (CurrentHitPoints <= (MaximumHitPoints / 2)) { woundState = AppData.WoundStateSeriouslyWounded; }
            if (CurrentHitPoints < 1) { woundState = AppData.WoundStateMortallyWounded; }
            if (IsDead) { woundState = AppData.WoundStateDead; }
            WoundState = woundState;
            NotifyPropertyChanged(nameof(MoveSpeed));
        }
        public void UpdateBlackIceWoundState()
        {
            string woundState = AppData.ProgramStateRezzed;
            if (CurrentHitPoints == 0) { woundState = AppData.ProgramStateDerezzed; }
            WoundState = woundState;
        }
        public void UpdateDefenseWoundState()
        {
            string woundState = AppData.DefenseStateOperational;
            if (CurrentHitPoints == 0) { woundState = AppData.DefenseStateDestroyed; IsDead = true; }
            WoundState = woundState;
        }
        public int GetSkillPenalty(string skillName)
        {
            int penalty = GetAllActionInjuryAndWoundStatePenalty();
            if (skillName == AppData.SkillPerception && CriticalInjuries.Contains(AppData.CriticalInjuryLostEye)) { penalty += 4; }
            if (skillName == AppData.SkillPerception && CriticalInjuries.Contains(AppData.CriticalInjuryDamagedEye)) { penalty += 2; }
            if (skillName == AppData.SkillPersuasion && CriticalInjuries.Contains(AppData.CriticalInjuryBrokenJaw)) { penalty += 4; }
            if (skillName == AppData.SkillBribery && CriticalInjuries.Contains(AppData.CriticalInjuryBrokenJaw)) { penalty += 4; }
            if (skillName == AppData.SkillConversation && CriticalInjuries.Contains(AppData.CriticalInjuryBrokenJaw)) { penalty += 4; }
            if (skillName == AppData.SkillPerception && CriticalInjuries.Contains(AppData.CriticalInjuryLostEar)) { penalty += 4; }
            // TODO - add question for if perception involves sight, smell, or sound
            return penalty;
        }
        public int GetStatPenalty(string statName)
        {
            int penalty = GetAllActionInjuryAndWoundStatePenalty();
            if (statName == AppData.StatMovement && CriticalInjuries.Contains(AppData.CriticalInjuryCollapsedLung)) { penalty += 2; }
            if (statName == AppData.StatMovement && CriticalInjuries.Contains(AppData.CriticalInjuryBrokenLeg)) { penalty += 4; }
            if (statName == AppData.StatMovement && CriticalInjuries.Contains(AppData.CriticalInjuryDismemberedLeg)) { penalty += 6; }
            return penalty;
        }
        public int GetAttackInjuryPenalty(string weaponType)
        {
            int penalty = GetAllActionInjuryAndWoundStatePenalty();
            if (weaponType.Contains("Melee")) { penalty += GetMeleeWeaponInjuryPenalty(); }
            else { penalty += GetRangedWeaponInjuryPenalty(); }
            return penalty;
        }
        private int GetMeleeWeaponInjuryPenalty()
        {
            int penalty = 0;
            if (CriticalInjuries.Contains(AppData.CriticalInjuryTornMuscle)) { penalty += 2; }
            return penalty;
        }
        private int GetRangedWeaponInjuryPenalty()
        {
            int penalty = 0;
            if (CriticalInjuries.Contains(AppData.CriticalInjuryLostEye)) { penalty += 4; }
            if (CriticalInjuries.Contains(AppData.CriticalInjuryDamagedEye)) { penalty += 2; }
            return penalty;
        }
        private int GetAllActionInjuryAndWoundStatePenalty()
        {
            int penalty = 0; 
            if (CriticalInjuries.Contains(AppData.CriticalInjuryBrainInjury)) { penalty += 2; }
            if (CriticalInjuries.Contains(AppData.CriticalInjuryConcussion)) { penalty += 2; }
            if (WoundState == AppData.WoundStateSeriouslyWounded) { penalty += 2; }
            if (WoundState == AppData.WoundStateMortallyWounded) { penalty += 4; }
            return penalty;
        }
        public void SetNetActions()
        {
            NetActions.Clear();
            NetActions.Add(new(AppData.NetActionInterface));
            NetActions.Add(new(AppData.NetActionJackIn));
            NetActions.Add(new(AppData.NetActionJackOut));
            NetActions.Add(new(AppData.NetActionActivateProgram));
            NetActions.Add(new(AppData.NetActionScanner));
            NetActions.Add(new(AppData.NetActionBackdoor));
            NetActions.Add(new(AppData.NetActionCloak));
            NetActions.Add(new(AppData.NetActionControl));
            NetActions.Add(new(AppData.NetActionEyeDee));
            NetActions.Add(new(AppData.NetActionSlide));
            NetActions.Add(new(AppData.NetActionVirus));
            NetActions.Add(new(AppData.NetActionZap));
        }

        // Private Methods
        private void InitializeLists()
        {
            BaseStats = new();
            CalculatedStats = new();
            Skills = new();
            SkillBases = new();
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
            NetActions = new();
            CriticalInjuries = new();
            CyberdeckPrograms = new();
            ActivePrograms = new();
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
        private void AddCyberdeckProgram(string name)
        {
            CyberdeckProgram matchedProgram = AppData.CyberdeckPrograms.FirstOrDefault(p => p.Name == name)!;
            if (matchedProgram == null) { return; }
            CyberdeckPrograms.Add(matchedProgram.DeepClone());
        }
        private void AddCyberware(string name)
        {
            InstalledCyberware.Add(new(name));
        }
        private void SetStoppingPower(bool setCurrentToMax)
        {
            MaximumHeadStoppingPower = AppData.ArmorTable.GetStoppingPower(ArmorType);
            MaximumBodyStoppingPower = AppData.ArmorTable.GetStoppingPower(ArmorType);
            if (setCurrentToMax)
            {
                CurrentHeadStoppingPower = MaximumHeadStoppingPower;
                CurrentBodyStoppingPower = MaximumBodyStoppingPower;
            }
        }
        private void SetHitPoints(bool setCurrentToMax)
        {
            if (Type == AppData.ComTypeStandard || Type == AppData.ComTypeNPC)
            {
                int body = CalculatedStats.GetValue(AppData.StatBody);
                int willpower = CalculatedStats.GetValue(AppData.StatWillpower);
                MaximumHitPoints = 10 + (5 * ((body + willpower) / 2));
            }
            if (setCurrentToMax)
            {
                CurrentHitPoints = MaximumHitPoints;
            }
        }
        private void PrepareWeapons()
        {
            PauseOutput();
            foreach (CombatantWeapon weapon in Weapons)
            {
                if (string.IsNullOrEmpty(weapon.Name))
                {
                    weapon.Name = weapon.Type;
                }
                weapon.ReloadWeapon.Execute(this);
            }
            ResumeOutput();
        }
        private void OrganizeSkillsToCategories()
        {
            foreach (Skill skill in Skills)
            {
                if (AppData.SkillsToSkipForCombatants.Contains(skill.Name)) { continue; }
                if (skill.Name == AppData.SkillSurgery) { TechniqueSkills.Add(skill); continue; }
                if (skill.Name == AppData.SkillMedicalTech) { TechniqueSkills.Add(skill); continue; }
                switch (AppData.SkillLinks.GetCategory(skill.Name))
                {
                    case AppData.SkillCategoryAwareness:
                        AwarenessSkills.Add(skill);
                        break;
                    case AppData.SkillCategoryBody:
                        BodySkills.Add(skill);
                        break;
                    case AppData.SkillCategoryControl:
                        ControlSkills.Add(skill);
                        break;
                    case AppData.SkillCategoryPerformance:
                        PerformanceSkills.Add(skill);
                        break;
                    case AppData.SkillCategoryEducation:
                        EducationSkills.Add(skill);
                        break;
                    case AppData.SkillCategoryFighting:
                        FightingSkills.Add(skill);
                        break;
                    case AppData.SkillCategoryRangedWeapon:
                        RangedWeaponSkills.Add(skill);
                        break;
                    case AppData.SkillCategorySocial:
                        SocialSkills.Add(skill);
                        break;
                    case AppData.SkillCategoryTechnique:
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
                CriticalInjury bodyInjury = AppData.CriticalInjuriesToBody.FirstOrDefault(i => i.Name == injury.Name)!;
                CriticalInjury headInjury = AppData.CriticalInjuriesToHead.FirstOrDefault(i => i.Name == injury.Name)!;
                if (bodyInjury != null) { injury.Description = bodyInjury.Description; }
                if (headInjury != null) { injury.Description = headInjury.Description; }
            }
        }
        private void SetStandardActions()
        {
            StandardActions.Clear();
            StandardActions.Add(new(AppData.ActionBrawl));
            StandardActions.Add(new(AppData.ActionChoke));
            StandardActions.Add(new(AppData.ActionDeathSave));
            StandardActions.Add(new(AppData.ActionEvade));
            StandardActions.Add(new(AppData.ActionGrab));
            StandardActions.Add(new(AppData.ActionInitiative));
            StandardActions.Add(new(AppData.ActionThrowGrapple));
            StandardActions.Add(new(AppData.ActionThrowObject));
        }
        private int GetDemonCombatNumber()
        {
            Combatant demon = AppData.MainModelRef.CampaignView.ActiveCampaign.AllCombatants.FirstOrDefault(c => c.Type == AppData.ComTypeDemon);
            if (demon == null) { RaiseError(AppData.ErrorNoDemonAvailableForActiveDefense); return 0; }
            else
            {
                return demon.BaseStats.GetValue(AppData.SkillCombatNumber);
            }
        }
        private void SetImageByClass()
        {
            PortraitFilePath = ComClass switch
            {
                _ => AppData.PortraitDefault
            };
        }
        private void SetCustomImage()
        {
            string newFile = HelperMethods.GetFile(AppData.FilterImageFiles, AppData.CombatantImageDirectory);
            if (!string.IsNullOrEmpty(newFile)) { PortraitFilePath = newFile; }
        }
        private void AddRemainingSkills()
        {
            foreach (string skill in AppData.AllSkills)
            {
                Skill existingSkill = Skills.FirstOrDefault(s => s.Name == skill)!;
                if (existingSkill == null) { Skills.Add(new(skill)); }
            }
        }
        private void SetInitiative()
        {
            switch (Type)
            {
                case AppData.ComTypeDemon:
                    Initiative = AppData.InitiativeDemon;
                    break;
                case AppData.ComTypeActiveDefense:
                    Initiative = AppData.InitativeActiveDefense;
                    break;
                case AppData.ComTypeEmplacedDefense:
                    Initiative = AppData.InitiativeEmplacedDefense;
                    break;
                case AppData.ComTypeBlackIce:
                    Initiative = AppData.InitiativeBlackIce;
                    break;
                default:
                    break;
            }
        }

    }
}
