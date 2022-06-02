using CyberpunkGameplayAssistant.Toolbox;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace CyberpunkGameplayAssistant.Models
{
    public class NetArchitecture : BaseModel
    {
        // Constructors
        public NetArchitecture()
        {
            InitializeCollections();
        }
        public NetArchitecture(string name, string difficulty)
        {
            InitializeCollections();
            Name = name;
            Difficulty = difficulty;
        }

        // Databound Properties
        private string _Name;
        public string Name
        {
            get => _Name;
            set => SetAndNotify(ref _Name, value);
        }
        private string _Difficulty;
        public string Difficulty
        {
            get => _Difficulty;
            set => SetAndNotify(ref _Difficulty, value);
        }
        private ObservableCollection<NetFloor> _Floors;
        public ObservableCollection<NetFloor> Floors
        {
            get => _Floors;
            set => SetAndNotify(ref _Floors, value);
        }

        // Commands
        public ICommand AddFloor => new RelayCommand(DoAddFloor);
        private void DoAddFloor(object param)
        {
            if (param == null) { return; }
            const string paramBlank = "Blank";
            const string paramGenerated = "Generated";

            switch (param.ToString())
            {
                case paramBlank:
                    Floors.Add(new(Floors.Count + 1, string.Empty));
                    break;
                case paramGenerated:
                    Floors.Add(new(Floors.Count + 1, HelperMethods.RollNetFloor(Floors.Count + 1, Difficulty)));
                    break;
                default:
                    RaiseError($"Unhandled parameter {param.ToString()} in NetArchitecture.DoAddFloor");
                    return;
            }

        }
        public ICommand DeleteArchitecture => new RelayCommand(DoDeleteArchitecture);
        private void DoDeleteArchitecture(object param)
        {
            AppData.MainModelRef.CampaignView.ActiveCampaign.NetArchitectures.Remove(this);
            AppData.MainModelRef.CampaignView.ActiveCampaign.ActiveNetArchitecture = null;
        }

        // Public Methods
        public void RenumberFloors()
        {
            foreach (NetFloor netFloor in Floors)
            {
                netFloor.Level = Floors.IndexOf(netFloor) + 1;
            }
        }

        // Private Methods
        private void InitializeCollections()
        {
            Floors = new();
        }

    }
}
