using CyberpunkGameplayAssistant.Models;
using CyberpunkGameplayAssistant.Toolbox;
using CyberpunkGameplayAssistant.Toolbox.ExtensionMethods;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace CyberpunkGameplayAssistant.ViewModels
{
    [Serializable]
    public class CombatantBuilderViewModel : BaseModel
    {
        // Constructors
        public CombatantBuilderViewModel()
        {
            Combatants = new();
        }

        // Properties
        private ObservableCollection<Combatant> _Combatants;
        public ObservableCollection<Combatant> Combatants
        {
            get => _Combatants;
            set => SetAndNotify(ref _Combatants, value);
        }
        private Combatant _ActiveCombatant;
        public Combatant ActiveCombatant
        {
            get => _ActiveCombatant;
            set => SetAndNotify(ref _ActiveCombatant, value);
        }
        private string _LastSave;
        public string LastSave
        {
            get => _LastSave;
            set => SetAndNotify(ref _LastSave, value);
        }

        // Commands
        public ICommand AddCombatant => new RelayCommand(DoAddCombatant);
        private void DoAddCombatant(object param)
        {
            Combatant newCombatant = new();
            newCombatant.Name = "New Combatant";
            newCombatant.Type = AppData.ComTypeStandard;
            newCombatant.InitializeCustomCombatant();
            Combatants.Add(newCombatant);
            ActiveCombatant = newCombatant;
        }
        public ICommand SortCombatants => new RelayCommand(DoSortCombatants);
        private void DoSortCombatants(object param)
        {
            Combatants = new(Combatants.OrderBy(c => c.Name).ThenBy(c => c.Variant));
        }
        public ICommand SaveCombatants => new RelayCommand(param => DoSaveCombatants());
        public void DoSaveCombatants(bool notifyUser = true)
        {
            LastSave = DateTime.Now.ToString();
            System.Xml.Serialization.XmlSerializer serializer = new(typeof(CombatantBuilderViewModel));
            using (System.IO.StreamWriter writer = new(AppData.File_CombatantData))
            {
                serializer.Serialize(writer, this.DeepClone());
            }
            RaiseAlert($"{Combatants.Count} Combatants(s) Saved");
        }

        // Public Methods
        public void ResetActiveItems()
        {
            ActiveCombatant = null;
        }

    }
}
