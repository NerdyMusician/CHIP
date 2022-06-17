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
        private bool _HasNetrunnerB;
        public bool HasNetrunnerB
        {
            get => _HasNetrunnerB;
            set => SetAndNotify(ref _HasNetrunnerB, value);
        }
        private bool _HasNetrunnerC;
        public bool HasNetrunnerC
        {
            get => _HasNetrunnerC;
            set => SetAndNotify(ref _HasNetrunnerC, value);
        }
        private bool _HasNetrunnerD;
        public bool HasNetrunnerD
        {
            get => _HasNetrunnerD;
            set => SetAndNotify(ref _HasNetrunnerD, value);
        }

        // Commands
        public ICommand RemoveFloor => new RelayCommand(DoRemoveFloor);
        private void DoRemoveFloor(object param)
        {
            AppData.MainModelRef.CampaignView.ActiveCampaign.ActiveNetArchitecture.Floors.Remove(this);
            AppData.MainModelRef.CampaignView.ActiveCampaign.ActiveNetArchitecture.RenumberFloors();
        }
        public ICommand ToggleHasNetrunnerA => new RelayCommand(DoToggleHasNetrunnerA);
        private void DoToggleHasNetrunnerA(object param)
        {
            if (!HasNetrunner) { return; }
            ObservableCollection<NetFloor> netFloors = (param as ObservableCollection<NetFloor>)!;
            foreach (NetFloor net in netFloors)
            {
                if (net != this) { net.HasNetrunner = false; }
            }
        }
        public ICommand ToggleHasNetrunnerB => new RelayCommand(DoToggleHasNetrunnerB);
        private void DoToggleHasNetrunnerB(object param)
        {
            if (!HasNetrunnerB) { return; }
            ObservableCollection<NetFloor> netFloors = (param as ObservableCollection<NetFloor>)!;
            foreach (NetFloor net in netFloors)
            {
                if (net != this) { net.HasNetrunnerB = false; }
            }
        }
        public ICommand ToggleHasNetrunnerC => new RelayCommand(DoToggleHasNetrunnerC);
        private void DoToggleHasNetrunnerC(object param)
        {
            if (!HasNetrunnerC) { return; }
            ObservableCollection<NetFloor> netFloors = (param as ObservableCollection<NetFloor>)!;
            foreach (NetFloor net in netFloors)
            {
                if (net != this) { net.HasNetrunnerC = false; }
            }
        }
        public ICommand ToggleHasNetrunnerD => new RelayCommand(DoToggleHasNetrunnerD);
        private void DoToggleHasNetrunnerD(object param)
        {
            if (!HasNetrunnerD) { return; }
            ObservableCollection<NetFloor> netFloors = (param as ObservableCollection<NetFloor>)!;
            foreach (NetFloor net in netFloors)
            {
                if (net != this) { net.HasNetrunnerD = false; }
            }
        }

    }
}
