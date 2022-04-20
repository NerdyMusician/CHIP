using CyberpunkGameplayAssistant.Toolbox;

namespace CyberpunkGameplayAssistant.Models
{
    public class GameCampaign : BaseModel
    {
        // Constructors
        public GameCampaign()
        {

        }

        // Databound Properties
        private string _Name;
        [XmlSaveMode(XSME.Single)]
        public string Name
        {
            get => _Name;
            set => SetAndNotify(ref _Name, value);
        }

    }
}
