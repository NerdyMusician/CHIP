using CyberpunkGameplayAssistant.Models;
using CyberpunkGameplayAssistant.Toolbox;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CyberpunkGameplayAssistant.ViewModels
{
    public class MultiObjectSelectionViewModel : BaseModel
    {
        // Constructors
        public MultiObjectSelectionViewModel(List<Combatant> combatants, string mode)
        {
            SourceCombatants = new(combatants);
            FilteredSourceCombatants = new();
            SelectedCombatants = new();
            Mode = mode;
            SourceTextSearch = "";
        }
        public MultiObjectSelectionViewModel(List<NamedRecord> records, string mode)
        {
            SourceRecords = new(records);
            FilteredSourceRecords = new();
            SelectedRecords = new();
            Mode = mode;
            SourceTextSearch = "";
        }

        // Databound Properties
        private string _Mode;
        public string Mode
        {
            get => _Mode;
            set => SetAndNotify(ref _Mode, value);
        }

        #region NamedRecord
        private ObservableCollection<NamedRecord> _SourceRecords;
        public ObservableCollection<NamedRecord> SourceRecords
        {
            get => _SourceRecords;
            set => SetAndNotify(ref _SourceRecords, value);
        }
        private ObservableCollection<NamedRecord> _FilteredSourceRecords;
        public ObservableCollection<NamedRecord> FilteredSourceRecords
        {
            get => _FilteredSourceRecords;
            set => SetAndNotify(ref _FilteredSourceRecords, value);
        }
        private ObservableCollection<NamedRecord> _SelectedRecords;
        public ObservableCollection<NamedRecord> SelectedRecords
        {
            get => _SelectedRecords;
            set => SetAndNotify(ref _SelectedRecords, value);
        }
        #endregion

        #region Combatants
        private ObservableCollection<Combatant> _SourceCombatants;
        public ObservableCollection<Combatant> SourceCombatants
        {
            get => _SourceCombatants;
            set => SetAndNotify(ref _SourceCombatants, value);
        }
        private ObservableCollection<Combatant> _FilteredSourceCombatants;
        public ObservableCollection<Combatant> FilteredSourceCombatants
        {
            get => _FilteredSourceCombatants;
            set => SetAndNotify(ref _FilteredSourceCombatants, value);
        }
        private ObservableCollection<Combatant> _SelectedCombatants;
        public ObservableCollection<Combatant> SelectedCombatants
        {
            get => _SelectedCombatants;
            set => SetAndNotify(ref _SelectedCombatants, value);
        }
        #endregion

        #region SourceTextSearch
        private string _SourceTextSearch;
        public string SourceTextSearch
        {
            get => _SourceTextSearch;
            set
            {
                _SourceTextSearch = value;
                NotifyPropertyChanged();
                UpdateFilteredList();
            }
        }
        #endregion
        #region Count_SourceAll
        private int _Count_SourceAll;
        public int Count_SourceAll
        {
            get => _Count_SourceAll;
            set => SetAndNotify(ref _Count_SourceAll, value);
        }
        #endregion
        #region Count_SourceFiltered
        private int _Count_SourceFiltered;
        public int Count_SourceFiltered
        {
            get => _Count_SourceFiltered;
            set => SetAndNotify(ref _Count_SourceFiltered, value);
        }
        #endregion

        // Private Methods
        private void UpdateFilteredList()
        {
            switch (Mode)
            {
                case AppData.MultiModeEnemies:
                    FilteredSourceCombatants.Clear();
                    foreach (Combatant combatant in SourceCombatants)
                    {
                        if (combatant.Name.ToUpper().Contains(SourceTextSearch.ToUpper())) { FilteredSourceCombatants.Add(combatant); }
                    }
                    Count_SourceFiltered = FilteredSourceCombatants.Count;
                    Count_SourceAll = SourceCombatants.Count;
                    break;
                default:
                    FilteredSourceRecords.Clear();
                    foreach (NamedRecord record in SourceRecords)
                    {
                        if (record.Name.ToUpper().Contains(SourceTextSearch.ToUpper())) { FilteredSourceRecords.Add(record); }
                    }
                    Count_SourceFiltered = FilteredSourceRecords.Count;
                    Count_SourceAll = SourceRecords.Count;
                    break;
            }
        }

    }
}
