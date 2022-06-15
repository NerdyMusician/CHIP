using CyberpunkGameplayAssistant.Models;
using CyberpunkGameplayAssistant.Toolbox;
using CyberpunkGameplayAssistant.Toolbox.ExtensionMethods;
using CyberpunkGameplayAssistant.Windows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Timers;
using System.Windows.Input;
using System.Xml.Serialization;

namespace CyberpunkGameplayAssistant.ViewModels
{
    public class MainViewModel : BaseModel
    {
        // Constructors
        public MainViewModel()
        {
            ApplicationVersion = "CHIP Next";
            UserAlerts = new();
            HelperMethods.CreateDirectories(AppData.Directories);
            LoadData();
            MaintainData();
            UserAlertTimer = new Timer(TimeSpan.FromSeconds(1).TotalMilliseconds);
            UserAlertTimer.Elapsed += UserAlertTimer_Elapsed;
            UserAlertTimer.Enabled = true;
            AppData.MainModelRef = this;
        }

        // Databound Properties
        private string _ApplicationVersion;
        public string ApplicationVersion
        {
            get => _ApplicationVersion;
            set => SetAndNotify(ref _ApplicationVersion, value);
        }
        private CampaignViewModel _CampaignView;
        public CampaignViewModel CampaignView
        {
            get => _CampaignView;
            set => SetAndNotify(ref _CampaignView, value);
        }
        private CombatantBuilderViewModel _CombatantView;
        public CombatantBuilderViewModel CombatantView
        {
            get => _CombatantView;
            set => SetAndNotify(ref _CombatantView, value);
        }
        private EncounterBuilder _EncounterView;
        public EncounterBuilder EncounterView
        {
            get => _EncounterView;
            set => SetAndNotify(ref _EncounterView, value);
        }
        private SettingsViewModel _SettingsView;
        public SettingsViewModel SettingsView
        {
            get => _SettingsView;
            set => SetAndNotify(ref _SettingsView, value);
        }
        private Uri _SfxSource;
        public Uri SfxSource
        {
            get => _SfxSource;
            set => SetAndNotify(ref _SfxSource, value);
        }
        private ObservableCollection<UserAlert> _UserAlerts;
        public ObservableCollection<UserAlert> UserAlerts
        {
            get => _UserAlerts;
            set => SetAndNotify(ref _UserAlerts, value);
        }
        public List<string> CombatantTypes
        {
            get
            {
                return new()
                {
                    AppData.ComTypeStandard,
                    AppData.ComTypeActiveDefense, AppData.ComTypeEmplacedDefense,
                    AppData.ComTypeBlackIce, AppData.ComTypeDemon
                };
            }
        }
        public List<string> CombatantClasses
        {
            get
            {
                return new() 
                { 
                    AppData.ComClassCivilian,
                    AppData.ComClassLightGanger, AppData.ComClassMediumGanger, AppData.ComClassHeavyGanger,
                    AppData.ComClassLightCorpo, AppData.ComClassMediumCorpo, AppData.ComClassHeavyCorpo,
                    AppData.ComClassLightPolice, AppData.ComClassMediumPolice, AppData.ComClassHeavyPolice
                };
            }
        }
        public List<string> ArmorTypes
        {
            get
            {
                return new()
                {
                    AppData.ArmorTypeNone,
                    AppData.ArmorTypeLeather,
                    AppData.ArmorTypeKevlar,
                    AppData.ArmorTypeSubdermal,
                    AppData.ArmorTypeLightArmorjack,
                    AppData.ArmorTypeMediumArmorjack,
                    AppData.ArmorTypeHeavyArmorjack,
                    AppData.ArmorTypeBodyweightSuit,
                    AppData.ArmorTypeFlak,
                    AppData.ArmorTypeMetalgear
                };
            }
        }
        public List<string> BlackIceTypes
        {
            get
            {
                return new()
                {
                    AppData.AntiPersonnelBlackIce,
                    AppData.AntiProgramBlackIce
                };
            }
        }
        public List<string> EncounterTypes
        {
            get
            {
                return new()
                {
                    AppData.EnTypeCorp,
                    AppData.EnTypeGang,
                    AppData.EnTypeLaw,
                    AppData.EnTypeOther
                };
            }
        }
        public List<string> ThreatLevels
        {
            get
            {
                return new()
                {
                    AppData.EnThreatLow,
                    AppData.EnThreatMedium,
                    AppData.EnThreatHigh,
                    AppData.EnThreatLethal
                };
            }
        }

        // Private Properties
        private Timer UserAlertTimer;
        private int AlertDisplayTime = 3;

        // Dropdown Sources
        public List<string> NetArchitectureDifficultyOptions 
        { 
            get
            {
                return new()
                {
                    AppData.NetArchitectureDifficultyBasic,
                    AppData.NetArchitectureDifficultyStandard,
                    AppData.NetArchitectureDifficultyUncommon,
                    AppData.NetArchitectureDifficultyAdvanced
                };
            } 
        }
        public List<string> NoteTypes
        {
            get
            {
                return new()
                {
                    AppData.NoteCorp,
                    AppData.NoteEncounter,
                    AppData.NoteFaction,
                    AppData.NoteLocation,
                    AppData.NoteNPC,
                    AppData.NoteOther,
                };
            }
        }

        // Commands
        public ICommand ProcessKeyboardShortcut => new RelayCommand(DoProcessKeyboardShortcut);
        private void DoProcessKeyboardShortcut(object key)
        {
            switch (key.ToString())
            {
                case "CtrlS":
                    CampaignView.SaveCampaigns.Execute(null);
                    break;
                case "CtrlN":
                    CampaignView.AddCampaign.Execute(null);
                    break;
                default:
                    break;
            }
        }
        public ICommand ImportCombatants => new RelayCommand(DoImportCombatants);
        private void DoImportCombatants(object param)
        {
            string file = HelperMethods.GetFile(AppData.FilterXmlFiles);
            CombatantBuilderViewModel importedData = new();
            List<Combatant> combatantsToAdd = new();
            List<CombatantComparer> combatantsToCompare = new();
            try
            {
                XmlSerializer xmlSerializer = new(typeof(CombatantBuilderViewModel));
                using FileStream fs = new(file, FileMode.Open);
                importedData = (CombatantBuilderViewModel)xmlSerializer.Deserialize(fs)!;
            }
            catch
            {
                RaiseError("Invalid XML file, no combatant data detected");
            }
            foreach (Combatant combatant in importedData.Combatants)
            {
                if (!CombatantExistsInCurrentData(combatant)) { combatantsToAdd.Add(combatant.DeepClone()); }
                else
                {
                    combatantsToCompare.Add(new(CombatantView.Combatants.FirstOrDefault(c => c.Name == combatant.Name).DeepClone(), combatant.DeepClone()));
                }
            }
            combatantsToCompare.SetInfoDumps();
            if (combatantsToCompare.Count > 0)
            {
                ImportSelector importer = new(AppData.ImporterModeCombatants, combatantsToCompare);
                if (importer.ShowDialog() == true)
                {
                    foreach (CombatantComparer comparer in (importer.DataContext as ImporterViewModel).ComparedCombatants)
                    {
                        if (comparer.CombatantASelected) { continue; } // since that data already exists
                        if (comparer.CombatantBSelected) { comparer.CombatantB.Name += " (new)"; combatantsToAdd.Add(comparer.CombatantB); }
                    }
                }
            }
            combatantsToCompare.ClearInfoDumps();
            foreach (Combatant combatantToAdd in combatantsToAdd)
            {
                CombatantView.Combatants.Add(combatantToAdd);
            }
            CombatantView.SortCombatants.Execute(null);
            RaiseAlert($"{combatantsToAdd.Count} combatant(s) imported");

        }

        // Public Methods
        public void AddUserAlert(string type, string message)
        {
            UserAlerts.Add(new(type, message));
        }

        // Private Methods
        private void LoadData()
        {
            LoadCampaignsData();
            LoadCombatantsData();
            LoadEncountersData();
            LoadSettingsData();
        }
        private void LoadCampaignsData()
        {
            try
            {
                XmlSerializer xmlSerializer = new(typeof(CampaignViewModel));
                using FileStream fs = new(AppData.File_CampaignData, FileMode.Open);
                CampaignView = (CampaignViewModel)xmlSerializer.Deserialize(fs);
                CampaignView!.ResetActiveItems();
            }
            catch
            {
                CampaignView = new();
            }
            foreach (GameCampaign campaign in CampaignView.Campaigns)
            {
                campaign.SortCombatants.Execute(null);
            }
        }
        private void LoadCombatantsData()
        {
            try
            {
                XmlSerializer xmlSerializer = new(typeof(CombatantBuilderViewModel));
                using FileStream fs = new(AppData.File_CombatantData, FileMode.Open);
                CombatantView = (CombatantBuilderViewModel)xmlSerializer.Deserialize(fs);
                CombatantView!.ResetActiveItems();
            }
            catch
            {
                CombatantView = new();
            }
        }
        private void LoadEncountersData()
        {
            try
            {
                XmlSerializer xmlSerializer = new(typeof(EncounterBuilder));
                using FileStream fs = new(AppData.File_EncounterData, FileMode.Open);
                EncounterView = (EncounterBuilder)xmlSerializer.Deserialize(fs);
                EncounterView!.ResetActiveItems();
            }
            catch
            {
                EncounterView = new();
            }
        }
        private void LoadSettingsData()
        {
            try
            {
                XmlSerializer xmlSerializer = new(typeof(SettingsViewModel));
                using FileStream fs = new(AppData.File_SettingData, FileMode.Open);
                SettingsView = (SettingsViewModel)xmlSerializer.Deserialize(fs);
            }
            catch
            {
                SettingsView = new();
            }
        }
        private void MaintainData()
        {
            MaintainImagePaths();
        }
        private void MaintainImagePaths()
        {
            foreach (GameCampaign campaign in CampaignView.Campaigns)
            {
                foreach (Combatant combatant in campaign.AllCombatants)
                {
                    if (combatant.Type == AppData.ComTypePlayer)
                    {
                        if (CheckAndUpdateFilePath(combatant.PortraitFilePath, AppData.PlayerImageDirectory, out string filepath))
                        {
                            combatant.PortraitFilePath = filepath;
                        }
                        continue;
                    }
                    if (combatant.Type == AppData.ComTypeNPC)
                    {
                        if (CheckAndUpdateFilePath(combatant.PortraitFilePath, AppData.NpcImageDirectory, out string filepath2))
                        {
                            combatant.PortraitFilePath = filepath2;
                        }
                        continue;
                    }
                    if (CheckAndUpdateFilePath(combatant.PortraitFilePath, AppData.CombatantImageDirectory, out string filepath3))
                    {
                        combatant.PortraitFilePath = filepath3;
                    }
                }
                foreach (Combatant player in campaign.Players)
                {
                    if (CheckAndUpdateFilePath(player.PortraitFilePath, AppData.PlayerImageDirectory, out string filepath))
                    {
                        player.PortraitFilePath = filepath;
                    }
                }
                foreach (NPC npc in campaign.Npcs)
                {
                    if (CheckAndUpdateFilePath(npc.PortraitFilePath, AppData.NpcImageDirectory, out string filepath))
                    {
                        npc.PortraitFilePath = filepath;
                    }
                }
            }
            foreach (Combatant combatant in CombatantView.Combatants)
            {
                if (CheckAndUpdateFilePath(combatant.PortraitFilePath, AppData.CombatantImageDirectory, out string filepath3))
                {
                    combatant.PortraitFilePath = filepath3;
                }
            }
        }
        private bool CheckAndUpdateFilePath(string originalFilePath, string directory, out string updatedFilePath)
        {
            if (File.Exists(originalFilePath)) { updatedFilePath = string.Empty; return false; }
            else
            {
                updatedFilePath = directory += Path.GetFileName(originalFilePath);
                if (!File.Exists(updatedFilePath)) { updatedFilePath = AppData.PortraitDefault; }
                return true;
            }
        }
        private void UserAlertTimer_Elapsed(object? sender, ElapsedEventArgs e)
        {
            if (UserAlerts.Count == 0) { return; }
            DateTime currentDateTime = DateTime.Now;
            List<UserAlert> keptAlerts = new();
            foreach (UserAlert alert in UserAlerts)
            {
                TimeSpan timeElapsed = currentDateTime - alert.CreationDateTime;
                if (timeElapsed.Seconds <= AlertDisplayTime) { keptAlerts.Add(alert); }
            }
            UserAlerts = new(keptAlerts);
        }
        private bool CombatantExistsInCurrentData(Combatant combatant)
        {
            return (CombatantView.Combatants.FirstOrDefault(c => c.Name == combatant.Name) != null);
        }

    }
}
