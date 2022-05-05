using CyberpunkGameplayAssistant.Models;
using CyberpunkGameplayAssistant.Toolbox;
using System.Windows.Input;

namespace CyberpunkGameplayAssistant.ViewModels
{
    public class MainViewModel : BaseModel
    {
        // Constructors
        public MainViewModel()
        {
            ApplicationVersion = "CHIP 1.00.00 beta";
            try
            {
                System.Xml.Serialization.XmlSerializer xmlSerializer = new(typeof(CampaignViewModel));
                using System.IO.FileStream fs = new(ReferenceData.File_CampaignData, System.IO.FileMode.Open);
                CampaignView = (CampaignViewModel)xmlSerializer.Deserialize(fs);
            }
            catch
            {
                CampaignView = new();
            }
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

        // Commands
        public ICommand ProcessKeyboardShortcut => new RelayCommand(DoProcessKeyboardShortcut);
        private void DoProcessKeyboardShortcut(object key)
        {
            switch (key.ToString())
            {
                case "CtrlS":
                    break;
                case "CtrlN":
                    break;
                default:
                    break;
            }
        }


    }
}
