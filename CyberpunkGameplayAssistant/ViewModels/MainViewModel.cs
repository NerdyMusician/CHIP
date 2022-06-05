using CyberpunkGameplayAssistant.Models;
using CyberpunkGameplayAssistant.Toolbox;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
            ApplicationVersion = "CHIP 1.01.00";
            UserAlerts = new();
            HelperMethods.CreateDirectories(AppData.Directories);
            LoadData();
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


    }
}
