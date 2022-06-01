using CyberpunkGameplayAssistant.Toolbox;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace CyberpunkGameplayAssistant.Models
{
    [Serializable]
    public class NetFloor : BaseModel
    {
        // Constructors
        public NetFloor()
        {

        }
        public NetFloor(int level, string description)
        {
            Level = level;
            Description = description;
        }

        // Databound Properties
        private int _Level;
        public int Level
        {
            get => _Level;
            set => SetAndNotify(ref _Level, value);
        }
        private string _Description;
        public string Description
        {
            get => _Description;
            set => SetAndNotify(ref _Description, value);
        }
        private string _Notes;
        public string Notes
        {
            get => _Notes;
            set => SetAndNotify(ref _Notes, value);
        }
        private bool _HasNetrunner;
        public bool HasNetrunner
        {
            get => _HasNetrunner;
            set => SetAndNotify(ref _HasNetrunner, value);
        }

        // Commands
        public ICommand RemoveFloor => new RelayCommand(DoRemoveFloor);
        private void DoRemoveFloor(object param)
        {
            AppData.MainModelRef.CampaignView.ActiveCampaign.ActiveNetArchitecture.Floors.Remove(this);
            AppData.MainModelRef.CampaignView.ActiveCampaign.ActiveNetArchitecture.RenumberFloors();
        }
        public ICommand ToggleHasNetrunner => new RelayCommand(DoToggleHasNetrunner);
        private void DoToggleHasNetrunner(object param)
        {
            if (!HasNetrunner) { return; }
            ObservableCollection<NetFloor> netFloors = (param as ObservableCollection<NetFloor>)!;
            foreach (NetFloor net in netFloors)
            {
                if (net != this) { net.HasNetrunner = false; }
            }
        }

    }
}
