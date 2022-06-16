using CyberpunkGameplayAssistant.Models;
using CyberpunkGameplayAssistant.Toolbox;
using CyberpunkGameplayAssistant.Toolbox.ExtensionMethods;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace CyberpunkGameplayAssistant.ViewModels
{
    public class EncounterBuilder : BaseModel
    {
        // Constructors
        public EncounterBuilder()
        {
            Encounters = new();
        }

        // Properties
        private ObservableCollection<Encounter> _Encounters;
        public ObservableCollection<Encounter> Encounters
        {
            get => _Encounters;
            set => SetAndNotify(ref _Encounters, value);
        }
        private Encounter _ActiveEncounter;
        public Encounter ActiveEncounter
        {
            get => _ActiveEncounter;
            set => SetAndNotify(ref _ActiveEncounter, value);
        }
        private string _LastSave;
        public string LastSave
        {
            get => _LastSave;
            set => SetAndNotify(ref _LastSave, value);
        }

        // Commands
        public ICommand AddEncounter => new RelayCommand(DoAddEncounter);
        private void DoAddEncounter(object param)
        {
            Encounter newEncounter = new();
            newEncounter.Name = "New Encounter";
            newEncounter.Type = AppData.EnTypeOther;
            newEncounter.ThreatLevel = AppData.EnThreatLow;
            Encounters.Add(newEncounter);
            ActiveEncounter = newEncounter;
        }
        public ICommand SortEncounters => new RelayCommand(DoSortEncounters);
        private void DoSortEncounters(object param)
        {
            string[] threatLevelSortOrder = { AppData.EnThreatLow, AppData.EnThreatMedium, AppData.EnThreatHigh, AppData.EnThreatLethal };
            Encounters = new(Encounters.OrderBy(e => Array.IndexOf(threatLevelSortOrder, e.Type)).ThenBy(e => e.Name));
        }
        public ICommand SaveEncounters => new RelayCommand(param => DoSaveEncounters());
        public void DoSaveEncounters(bool notifyUser = true)
        {
            LastSave = DateTime.Now.ToString();
            System.Xml.Serialization.XmlSerializer serializer = new(typeof(EncounterBuilder));
            using (System.IO.StreamWriter writer = new(AppData.FilePath_Encounters))
            {
                serializer.Serialize(writer, this.DeepClone());
            }
            RaiseAlert($"{Encounters.Count} Encounter(s) Saved");
        }
        public ICommand DuplicateEncounter => new RelayCommand(DoDuplicateEncounter);
        private void DoDuplicateEncounter(object param)
        {

        }

        // Public Methods
        public void ResetActiveItems()
        {
            ActiveEncounter = null;
        }


    }
}
