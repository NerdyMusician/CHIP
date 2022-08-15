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
using System.Windows.Forms;
using System.Windows.Input;
using System.Xml.Serialization;

namespace CyberpunkGameplayAssistant.ViewModels
{
    public class MainViewModel : BaseModel
    {
        // Constructors
        public MainViewModel()
        {
            ApplicationVersion = "CHIP 1.04.00 beta";
            UserAlerts = new();
            HelperMethods.CreateDirectories(AppData.Directories);
            LoadData();
            MaintainData();
            UserAlertTimer = new System.Timers.Timer(TimeSpan.FromSeconds(1).TotalMilliseconds);
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

        private bool _ViewingCampaigns;
        public bool ViewingCampaigns
        {
            get => _ViewingCampaigns;
            set => SetAndNotify(ref _ViewingCampaigns, value);
        }
        private bool _ViewingCombatants;
        public bool ViewingCombatants
        {
            get => _ViewingCombatants;
            set => SetAndNotify(ref _ViewingCombatants, value);
        }
        private bool _ViewingEncounters;
        public bool ViewingEncounters
        {
            get => _ViewingEncounters;
            set => SetAndNotify(ref _ViewingEncounters, value);
        }
        private bool _ViewingSettings;
        public bool ViewingSettings
        {
            get => _ViewingSettings;
            set => SetAndNotify(ref _ViewingSettings, value);
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
        private System.Timers.Timer UserAlertTimer;
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
                case "F1":
                    ViewingCampaigns = true;
                    break;
                case "F2":
                    ViewingCombatants = true;
                    break;
                case "F3":
                    ViewingEncounters = true;
                    break;
                case "F4":
                    ViewingSettings = true;
                    break;
                case "CtrlS":
                    if (ViewingCampaigns) { CampaignView.SaveCampaigns.Execute(null); }
                    if (ViewingCombatants) { CombatantView.SaveCombatants.Execute(null); }
                    if (ViewingEncounters) { EncounterView.SaveEncounters.Execute(null); }
                    break;
                case "CtrlN":
                    if (ViewingCampaigns) { CampaignView.AddCampaign.Execute(null); }
                    if (ViewingCombatants) { CombatantView.AddCombatant.Execute(AppData.ComTypeStandard); }
                    if (ViewingEncounters) { EncounterView.AddEncounter.Execute(null); }
                    break;
                default:
                    break;
            }
        }
        public ICommand PerformDataCheckup => new RelayCommand(DoPerformDataCheckup);
        private void DoPerformDataCheckup(object param)
        {
            List<string> messages = new();

            foreach (GameCampaign campaign in CampaignView.Campaigns)
            {
                foreach (NPC npc in campaign.Npcs)
                {
                    if (string.IsNullOrEmpty(npc.BaseCombatant)) { messages.Add($"CAMPAIGN:{campaign.Name}>NPC:{npc.Name}>Missing Base Combatant"); }
                    if (CombatantView.Combatants.FirstOrDefault(c => c.Name == npc.BaseCombatant) == null) { messages.Add($"CAMPAIGN:{campaign.Name}>NPC:{npc.Name}>Base Combatant not found in Combatants data"); }
                }
            }
            foreach (Encounter encounter in EncounterView.Encounters)
            {
                foreach (EncounterCombatant combatant in encounter.Combatants)
                {
                    if (CombatantView.Combatants.FirstOrDefault(c => c.Name == combatant.Name) == null) { messages.Add($"ENCOUNTER:{encounter.Name}>COMBATANT:{combatant.Name}>Combatant not found in Combatants data"); }
                }
            }

            if (messages.Count > 0)
            {
                HelperMethods.WriteToLogFile(messages);
                RaiseError("Data issues found, details written to log");
            }
            else
            {
                RaiseAlert("No data issues found.");
            }
        }
        public ICommand ImportFullData => new RelayCommand(DoImportFullData);
        private void DoImportFullData(object param)
        {
            FolderBrowserDialog folderBrowser = new();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                string filepath = folderBrowser.SelectedPath.Split('\\').Last() == "Data" ? Directory.GetParent(folderBrowser.SelectedPath).FullName + "\\" : folderBrowser.SelectedPath + "\\";
                if (File.Exists($"{filepath}Data\\{AppData.File_Campaigns}"))
                {
                    ImportData_Campaigns($"{filepath}Data\\{AppData.File_Campaigns}");
                }
                if (File.Exists($"{filepath}Data\\{AppData.File_Combatants}"))
                {
                    ImportData_Combatants($"{filepath}Data\\{AppData.File_Combatants}");
                }
                if (File.Exists($"{filepath}Data\\{AppData.File_Encounters}"))
                {
                    ImportData_Encounters($"{filepath}Data\\{AppData.File_Encounters}");
                }
                if (File.Exists($"{filepath}Data\\{AppData.File_Settings}"))
                {
                    ImportData_Settings($"{filepath}Data\\{AppData.File_Settings}");
                }
            }
        }
        public ICommand ImportCombatants => new RelayCommand(DoImportCombatants);
        private void DoImportCombatants(object param)
        {
            string filepath = HelperMethods.GetFile(AppData.FilterXmlFiles);
            ImportData_Combatants(filepath);
        }
        public ICommand ImportCampaigns => new RelayCommand(DoImportCampaigns);
        private void DoImportCampaigns(object param)
        {
            string filepath = HelperMethods.GetFile(AppData.FilterXmlFiles);
            ImportData_Campaigns(filepath);
        }
        public ICommand ImportEncounters => new RelayCommand(DoImportEncounters);
        private void DoImportEncounters(object param)
        {
            string filepath = HelperMethods.GetFile(AppData.FilterXmlFiles);
            ImportData_Encounters(filepath);
        }

        // Public Methods
        public void AddUserAlert(string type, string message)
        {
            UserAlerts.Add(new(type, message));
        }

        // Private Methods
        private void LoadData()
        {
            LoadSettingsData();
            LoadCampaignsData();
            LoadCombatantsData();
            LoadEncountersData();
        }
        private void LoadCampaignsData()
        {
            try
            {
                XmlSerializer xmlSerializer = new(typeof(CampaignViewModel));
                using FileStream fs = new(AppData.FilePath_Campaigns, FileMode.Open);
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
            if (SettingsView.CreateBackupOnStartup)
            {
                CampaignView.SaveCampaignsToFile($"{AppData.BackupDirectory}{AppData.File_Campaigns}", false);
            }
        }
        private void LoadCombatantsData()
        {
            try
            {
                XmlSerializer xmlSerializer = new(typeof(CombatantBuilderViewModel));
                using FileStream fs = new(AppData.FilePath_Combatants, FileMode.Open);
                CombatantView = (CombatantBuilderViewModel)xmlSerializer.Deserialize(fs);
                CombatantView!.ResetActiveItems();
            }
            catch
            {
                CombatantView = new();
            }
            if (SettingsView.CreateBackupOnStartup)
            {
                CombatantView.SaveCombatantsToFile($"{AppData.BackupDirectory}{AppData.File_Combatants}", false);
            }
        }
        private void LoadEncountersData()
        {
            try
            {
                XmlSerializer xmlSerializer = new(typeof(EncounterBuilder));
                using FileStream fs = new(AppData.FilePath_Encounters, FileMode.Open);
                EncounterView = (EncounterBuilder)xmlSerializer.Deserialize(fs);
                EncounterView!.ResetActiveItems();
            }
            catch
            {
                EncounterView = new();
            }
            if (SettingsView.CreateBackupOnStartup)
            {
                EncounterView.SaveEncountersToFile($"{AppData.BackupDirectory}{AppData.File_Encounters}", false);
            }
        }
        private void LoadSettingsData()
        {
            try
            {
                XmlSerializer xmlSerializer = new(typeof(SettingsViewModel));
                using FileStream fs = new(AppData.FilePath_Settings, FileMode.Open);
                SettingsView = (SettingsViewModel)xmlSerializer.Deserialize(fs);
            }
            catch
            {
                SettingsView = new();
                SettingsView.SetDefaultSettings();
            }
            if (SettingsView.CreateBackupOnStartup) { Directory.CreateDirectory(AppData.BackupDirectory); }
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
        private void ImportData_Campaigns(string filepath)
        {
            if (string.IsNullOrEmpty(filepath)) { return; }
            CampaignViewModel importedData = new();
            List<GameCampaign> campaignsToAdd = new();
            List<Comparer> campaignsToCompare = new();
            try
            {
                XmlSerializer xmlSerializer = new(typeof(CampaignViewModel));
                using FileStream fs = new(filepath, FileMode.Open);
                importedData = (CampaignViewModel)xmlSerializer.Deserialize(fs)!;
            }
            catch
            {
                RaiseError("Invalid XML file, no campaign data detected");
                return;
            }
            foreach (GameCampaign campaign in importedData.Campaigns)
            {
                if (!CampaignExistsInCurrentData(campaign)) { campaignsToAdd.Add(campaign.DeepClone()); }
                else
                {
                    campaignsToCompare.Add(new(CampaignView.Campaigns.FirstOrDefault(c => c.Name == campaign.Name).AsNamedRecord(), campaign.AsNamedRecord()));
                }
            }
            if (campaignsToCompare.Count > 0)
            {
                ImportSelector importer = new(AppData.ImporterModeCampaigns, campaignsToCompare);
                if (importer.ShowDialog() == true)
                {
                    foreach (Comparer comparer in (importer.DataContext as ImporterViewModel).ComparedItems)
                    {
                        if (comparer.RecordASelected) { continue; } // since that data already exists
                        if (comparer.RecordBSelected)
                        {
                            GameCampaign campaign = importedData.Campaigns.FirstOrDefault(c => c.Name == comparer.RecordB.Name).DeepClone();
                            campaign.Name += " (new)";
                            campaignsToAdd.Add(campaign);
                        }
                    }
                }
            }
            foreach (GameCampaign campaignToAdd in campaignsToAdd)
            {
                CampaignView.Campaigns.Add(campaignToAdd);
                foreach (NPC npc in campaignToAdd.Npcs)
                {
                    if (File.Exists(npc.PortraitFilePath))
                    {
                        File.Copy(npc.PortraitFilePath, $"{AppData.NpcImageDirectory}{Path.GetFileName(npc.PortraitFilePath)}", true);
                    }
                }
                foreach (Combatant player in campaignToAdd.Players)
                {
                    if (File.Exists(player.PortraitFilePath))
                    {
                        File.Copy(player.PortraitFilePath, $"{AppData.PlayerImageDirectory}{Path.GetFileName(player.PortraitFilePath)}", true);
                    }
                }
            }
            CampaignView.SortCampaigns.Execute(null);
            RaiseAlert($"{campaignsToAdd.Count} campaign(s) imported");
        }
        private void ImportData_Combatants(string filepath)
        {
            if (string.IsNullOrEmpty(filepath)) { return; }
            CombatantBuilderViewModel importedData = new();
            List<Combatant> combatantsToAdd = new();
            List<Comparer> combatantsToCompare = new();
            try
            {
                XmlSerializer xmlSerializer = new(typeof(CombatantBuilderViewModel));
                using FileStream fs = new(filepath, FileMode.Open);
                importedData = (CombatantBuilderViewModel)xmlSerializer.Deserialize(fs)!;
            }
            catch
            {
                RaiseError("Invalid XML file, no combatant data detected");
                return;
            }
            foreach (Combatant combatant in importedData.Combatants)
            {
                if (!CombatantExistsInCurrentData(combatant)) { combatantsToAdd.Add(combatant.DeepClone()); }
                else
                {
                    combatantsToCompare.Add(new(CombatantView.Combatants.FirstOrDefault(c => c.Name == combatant.Name).AsNamedRecord(), combatant.AsNamedRecord()));
                }
            }
            if (combatantsToCompare.Count > 0)
            {
                ImportSelector importer = new(AppData.ImporterModeCombatants, combatantsToCompare);
                if (importer.ShowDialog() == true)
                {
                    foreach (Comparer comparer in (importer.DataContext as ImporterViewModel).ComparedItems)
                    {
                        if (comparer.RecordASelected) { continue; } // since that data already exists
                        if (comparer.RecordBSelected)
                        {
                            Combatant combatant = importedData.Combatants.FirstOrDefault(c => c.Name == comparer.RecordB.Name).DeepClone();
                            combatant.Name += " (new)";
                            combatantsToAdd.Add(combatant);
                        }
                    }
                }
            }
            foreach (Combatant combatantToAdd in combatantsToAdd)
            {
                CombatantView.Combatants.Add(combatantToAdd);
                if (File.Exists(combatantToAdd.PortraitFilePath))
                {
                    File.Copy(combatantToAdd.PortraitFilePath, $"{AppData.CombatantImageDirectory}{Path.GetFileName(combatantToAdd.PortraitFilePath)}", true);
                }
            }
            CombatantView.SortCombatants.Execute(null);
            RaiseAlert($"{combatantsToAdd.Count} combatant(s) imported");
        }
        private void ImportData_Encounters(string filepath)
        {
            if (string.IsNullOrEmpty(filepath)) { return; }
            EncounterBuilder importedData = new();
            List<Encounter> encountersToAdd = new();
            List<Comparer> encountersToCompare = new();
            try
            {
                XmlSerializer xmlSerializer = new(typeof(EncounterBuilder));
                using FileStream fs = new(filepath, FileMode.Open);
                importedData = (EncounterBuilder)xmlSerializer.Deserialize(fs)!;
            }
            catch
            {
                RaiseError("Invalid XML file, no encounter data detected");
                return;
            }
            foreach (Encounter encounter in importedData.Encounters)
            {
                if (!EncounterExistsInCurrentData(encounter)) { encountersToAdd.Add(encounter.DeepClone()); }
                else
                {
                    encountersToCompare.Add(new(EncounterView.Encounters.FirstOrDefault(e => e.Name == encounter.Name).AsNamedRecord(), encounter.AsNamedRecord()));
                }
            }
            if (encountersToCompare.Count > 0)
            {
                ImportSelector importer = new(AppData.ImporterModeEncounters, encountersToCompare);
                if (importer.ShowDialog() == true)
                {
                    foreach (Comparer comparer in (importer.DataContext as ImporterViewModel).ComparedItems)
                    {
                        if (comparer.RecordASelected) { continue; } // since that data already exists
                        if (comparer.RecordBSelected)
                        {
                            Encounter encounter = importedData.Encounters.FirstOrDefault(e => e.Name == comparer.RecordB.Name).DeepClone();
                            encounter.Name += " (new)";
                            encountersToAdd.Add(encounter);
                        }
                    }
                }
            }
            foreach (Encounter encounterToAdd in encountersToAdd)
            {
                EncounterView.Encounters.Add(encounterToAdd);
            }
            EncounterView.SortEncounters.Execute(null);
            RaiseAlert($"{encountersToAdd.Count} encounter(s) imported");
        }
        private void ImportData_Settings(string filepath)
        {
            if (string.IsNullOrEmpty(filepath)) { return; }
            SettingsViewModel importedData = new();
            try
            {
                XmlSerializer xmlSerializer = new(typeof(SettingsViewModel));
                using FileStream fs = new(filepath, FileMode.Open);
                importedData = (SettingsViewModel)xmlSerializer.Deserialize(fs)!;
            }
            catch
            {
                RaiseError("Invalid XML file, no encounter data detected");
                return;
            }
            SettingsView = importedData;
        }
        private bool CombatantExistsInCurrentData(Combatant combatant)
        {
            return (CombatantView.Combatants.FirstOrDefault(c => c.Name == combatant.Name) != null);
        }
        private bool CampaignExistsInCurrentData(GameCampaign campaign)
        {
            return (CampaignView.Campaigns.FirstOrDefault(c => c.Name == campaign.Name) != null);
        }
        private bool EncounterExistsInCurrentData(Encounter encounter)
        {
            return (EncounterView.Encounters.FirstOrDefault(e => e.Name == encounter.Name) != null);
        }

    }
}
