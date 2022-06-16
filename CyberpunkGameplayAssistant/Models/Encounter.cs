using CyberpunkGameplayAssistant.Toolbox;
using CyberpunkGameplayAssistant.Toolbox.ExtensionMethods;
using CyberpunkGameplayAssistant.ViewModels;
using CyberpunkGameplayAssistant.Windows;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace CyberpunkGameplayAssistant.Models
{
    public class Encounter : BaseModel
    {
        // Constructors
        public Encounter()
        {
            Combatants = new();
        }

        // Properties
        private string _Name;
        public string Name
        {
            get => _Name;
            set => SetAndNotify(ref _Name, value);
        }
        private string _Description;
        public string Description
        {
            get => _Description;
            set => SetAndNotify(ref _Description, value);
        }
        private string _Type;
        public string Type
        {
            get => _Type;
            set => SetAndNotify(ref _Type, value);
        }
        private string _ThreatLevel;
        public string ThreatLevel
        {
            get => _ThreatLevel;
            set => SetAndNotify(ref _ThreatLevel, value);
        }
        private ObservableCollection<EncounterCombatant> _Combatants;
        public ObservableCollection<EncounterCombatant> Combatants
        {
            get => _Combatants;
            set => SetAndNotify(ref _Combatants, value);
        }

        // Commands
        public ICommand DuplicateEncounter => new RelayCommand(DoDuplicateEncounter);
        private void DoDuplicateEncounter(object param)
        {
            Encounter duplicatedEncounter = this.DeepClone();
            duplicatedEncounter.Name += " (Copy)";
            AppData.MainModelRef.EncounterView.Encounters.Add(duplicatedEncounter);
            AppData.MainModelRef.EncounterView.ActiveEncounter = duplicatedEncounter;
            RaiseAlert($"Encounter \"{Name}\" duplicated");
        }
        public ICommand DeleteEncounter => new RelayCommand(DoDeleteEncounter);
        private void DoDeleteEncounter(object param)
        {
            if (!HelperMethods.AskYesNoQuestion($"Delete Encounter \"{Name}\"?")) { return; }
            AppData.MainModelRef.EncounterView.Encounters.Remove(this);
            AppData.MainModelRef.EncounterView.ActiveEncounter = null;
            RaiseAlert($"Encounter \"{Name}\" deleted");
        }
        public ICommand AddCombatants => new RelayCommand(DoAddCombatants);
        private void DoAddCombatants(object param)
        {
            MultiObjectSelectionDialog selectionDialog = new(AppData.MainModelRef.CombatantView.Combatants.ToList().ToNamedRecordList(), AppData.MultiModeEncounterCombatants);

            if (selectionDialog.ShowDialog() == true)
            {
                int startCount = Combatants.Count;
                foreach (NamedRecord selectedRecord in (selectionDialog.DataContext as MultiObjectSelectionViewModel)!.SelectedRecords)
                {
                    EncounterCombatant combatant = new();
                    combatant.Name = selectedRecord.Name;
                    combatant.RatioA = 1;
                    combatant.RatioB = 1;
                    Combatants.Add(combatant);
                }
                int endCount = Combatants.Count;
                RaiseAlert($"{(endCount - startCount)} combatant(s) added to encounter");
            }
        }

        // Public Methods
        public string GetInfoDump()
        {
            string info = $"TYPE: {Type}\nTHREATLEVEL: {ThreatLevel}\nCOMBATANTS: ";
            foreach (EncounterCombatant combatant in Combatants)
            {
                info += $"{combatant.Name}[{combatant.RatioA}:{combatant.RatioB}], ";
            }
            return info;
        }

    }
}
