using CyberpunkGameplayAssistant.Models;
using CyberpunkGameplayAssistant.Toolbox;
using CyberpunkGameplayAssistant.Windows;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using System.Xml.Linq;

namespace CyberpunkGameplayAssistant.ViewModels
{
    [Serializable]
    public class CampaignViewModel : BaseModel
    {
        // Constructors
        public CampaignViewModel()
        {
            Campaigns = new();
        }

        // Databound Properties
        private ObservableCollection<GameCampaign> _Campaigns;
        public ObservableCollection<GameCampaign> Campaigns
        {
            get => _Campaigns;
            set => SetAndNotify(ref _Campaigns, value);
        }
        private GameCampaign _ActiveCampaign;
        public GameCampaign ActiveCampaign
        {
            get => _ActiveCampaign;
            set => SetAndNotify(ref _ActiveCampaign, value);
        }
        private string _LastSave;
        public string LastSave
        {
            get => _LastSave;
            set => SetAndNotify(ref _LastSave, value);
        }

        // Commands
        public ICommand AddCampaign => new RelayCommand(DoAddCampaign);
        private void DoAddCampaign(object param)
        {
            Campaigns.Add(new());
            ActiveCampaign = Campaigns.Last();
        }
        public ICommand SortCampaigns => new RelayCommand(DoSortCampaigns);
        private void DoSortCampaigns(object param)
        {
            Campaigns = new(Campaigns.OrderBy(c => c.Name));
        }
        public ICommand SaveCampaigns => new RelayCommand(param => DoSaveCampaigns());
        public void DoSaveCampaigns(bool notifyUser = true)
        {
            LastSave = DateTime.Now.ToString();
            System.Xml.Serialization.XmlSerializer serializer = new(typeof(CampaignViewModel));
            using (System.IO.StreamWriter writer = new(ReferenceData.File_CampaignData))
            {
                serializer.Serialize(writer, this);
            }
            HelperMethods.WriteToLogFile("Campaigns Saved", notifyUser);
        }
        public ICommand ImportCampaigns => new RelayCommand(param => DoImportCampaigns());
        private void DoImportCampaigns()
        {
            OpenFileDialog openWindow = new()
            {
                Filter = "XML Files (*.xml)|*.xml"
            };

            if (Campaigns.Count > 0)
            {
                YesNoDialog question = new("Prior to import, the current campaign list must be saved.\nContinue?");
                question.ShowDialog();
                if (question.Answer == false) { return; }

                DoSaveCampaigns(false);
            }

            if (openWindow.ShowDialog() == true)
            {
                //DataImport.ImportData_Campaigns(openWindow.FileName, out string message); // TODO
                //HelperMethods.NotifyUser(message);
            }
        }
        

    }
}
