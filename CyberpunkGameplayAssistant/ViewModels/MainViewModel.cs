using CyberpunkGameplayAssistant.Models;
using CyberpunkGameplayAssistant.Toolbox;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Timers;
using System.Windows.Input;

namespace CyberpunkGameplayAssistant.ViewModels
{
    public class MainViewModel : BaseModel
    {
        // Constructors
        public MainViewModel()
        {
            ApplicationVersion = "CHIP 2.00.00 beta";
            UserAlerts = new();
            HelperMethods.CreateDirectories(ReferenceData.Directories);
            LoadData();
            UserAlertTimer = new Timer(TimeSpan.FromSeconds(1).TotalMilliseconds);
            UserAlertTimer.Elapsed += UserAlertTimer_Elapsed;
            UserAlertTimer.Enabled = true;
            ReferenceData.MainModelRef = this;
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
                    ReferenceData.NetArchitectureDifficultyBasic,
                    ReferenceData.NetArchitectureDifficultyStandard,
                    ReferenceData.NetArchitectureDifficultyUncommon,
                    ReferenceData.NetArchitectureDifficultyAdvanced
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
            try
            {
                System.Xml.Serialization.XmlSerializer xmlSerializer = new(typeof(CampaignViewModel));
                using System.IO.FileStream fs = new(ReferenceData.File_CampaignData, System.IO.FileMode.Open);
                CampaignView = (CampaignViewModel)xmlSerializer.Deserialize(fs);
                CampaignView!.ResetActiveItems();
            }
            catch
            {
                CampaignView = new();
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
