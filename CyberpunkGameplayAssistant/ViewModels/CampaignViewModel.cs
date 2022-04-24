using CyberpunkGameplayAssistant.Models;
using CyberpunkGameplayAssistant.Toolbox;
using CyberpunkGameplayAssistant.Windows;
using Microsoft.Win32;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using System.Xml.Linq;

namespace CyberpunkGameplayAssistant.ViewModels
{
    public class CampaignViewModel : BaseModel
    {
        // Constructors
        public CampaignViewModel()
        {
            //XmlMethods.XmlToList(Configuration.CampaignDataFilePath, out List<GameCampaign> campaigns);
            //Campaigns = new(campaigns);
            Campaigns = new();
        }

        // Databound Properties
        private ObservableCollection<GameCampaign> _Campaigns;
        [XmlSaveMode(XSME.Enumerable)]
        public ObservableCollection<GameCampaign> Campaigns
        {
            get => _Campaigns;
            set => SetAndNotify(ref _Campaigns, value);
        }
        private GameCampaign _ActiveCampaign;
        [XmlSaveMode(XSME.Single)]
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
            if (Campaigns.Count == 0)
            {
                // Prevents zero character save crash
                XDocument blankDoc = new();
                blankDoc.Add(new XElement("GameCampaignSet"));
                blankDoc.Save(ReferenceData.File_CampaignData);
                return;
            }
            XDocument itemDocument = new();
            itemDocument.Add(XmlMethods.ListToXml(Campaigns.ToList()));
            itemDocument.Save(ReferenceData.File_CampaignData);
            HelperMethods.WriteToLogFile("Campaigns Saved", notifyUser);
            return;
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
