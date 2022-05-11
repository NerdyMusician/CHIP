using System.Collections.ObjectModel;

namespace CyberpunkGameplayAssistant.Models
{
    public class NetArchitecture : BaseModel
    {
        // Constructors
        public NetArchitecture()
        {

        }
        public NetArchitecture(string name, string difficulty)
        {

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

    }
}
