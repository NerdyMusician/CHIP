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
        private bool _AddCombatantMenuOpen;
        public bool AddCombatantMenuOpen
        {
            get => _AddCombatantMenuOpen;
            set => SetAndNotify(ref _AddCombatantMenuOpen, value);
        }

        // Commands
        public ICommand AddCombatant => new RelayCommand(DoAddCombatant);
        private void DoAddCombatant(object param)
        {
            if (!param.ToString().IsIn(AppData.ComTypeStandard, AppData.ComTypeEmplacedDefense, AppData.ComTypeActiveDefense, AppData.ComTypeDemon, AppData.ComTypeBlackIce))
            {
                RaiseError($"Invalid parameter \"{param}\" passed to AddCombatant");
                return;
            }
            Combatant newCombatant = new();
            newCombatant.Type = param.ToString();
            newCombatant.InitializeCustomCombatant();
            Combatants.Add(newCombatant);
            ActiveCombatant = newCombatant;
            AddCombatantMenuOpen = false;
        }
        public ICommand SortCombatants => new RelayCommand(DoSortCombatants);
        private void DoSortCombatants(object param)
        {
            string[] typeSortOrder = {
                AppData.ComTypeStandard, AppData.ComTypeActiveDefense, AppData.ComTypeEmplacedDefense,
                AppData.ComTypeDemon, AppData.ComTypeBlackIce };
            string[] classSortOrder = { 
                AppData.ComClassLightGanger, AppData.ComClassMediumGanger, AppData.ComClassHeavyGanger,
                AppData.ComClassLightCorpo, AppData.ComClassMediumCorpo, AppData.ComClassHeavyCorpo,
                AppData.ComClassLightPolice, AppData.ComClassMediumPolice, AppData.ComClassHeavyPolice,
                AppData.ComClassCivilian, AppData.ComTypeActiveDefense, AppData.ComTypeEmplacedDefense,
                AppData.ComTypeDemon, AppData.ComTypeBlackIce };
            Combatants = new(Combatants.OrderBy(c => Array.IndexOf(typeSortOrder, c.Type)).ThenBy(c => Array.IndexOf(classSortOrder, c.ComClass)).ThenBy(c => c.Name));
        }
        public ICommand SaveCombatants => new RelayCommand(param => DoSaveCombatants());
        public void DoSaveCombatants(bool notifyUser = true)
        {
            LastSave = DateTime.Now.ToString();
            SaveCombatantsToFile(AppData.FilePath_Combatants, true);
        }

        // Public Methods
        public void ResetActiveItems()
        {
            ActiveCombatant = null;
        }
        public void SaveCombatantsToFile(string filepath, bool notifyUser)
        {
            System.Xml.Serialization.XmlSerializer serializer = new(typeof(CombatantBuilderViewModel));
            using (System.IO.StreamWriter writer = new(filepath))
            {
                serializer.Serialize(writer, this.DeepClone());
            }
            if (notifyUser) { RaiseAlert($"{Combatants.Count} Combatants(s) Saved"); }
        }

    }
}
