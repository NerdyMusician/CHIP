using CyberpunkGameplayAssistant.Toolbox;
using CyberpunkGameplayAssistant.Windows;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace CyberpunkGameplayAssistant.Models
{
    public class GameCampaign : BaseModel
    {
        // Constructors
        public GameCampaign()
        {
            AllCombatants = new();
        }

        // Databound Properties
        private string _Name;
        [XmlSaveMode(XSME.Single)]
        public string Name
        {
            get => _Name;
            set => SetAndNotify(ref _Name, value);
        }
        private ObservableCollection<Combatant> _AllCombatants;
        [XmlSaveMode(XSME.Enumerable)]
        public ObservableCollection<Combatant> AllCombatants
        {
            get => _AllCombatants;
            set => SetAndNotify(ref _AllCombatants, value);
        }

        // Commands
        public ICommand AddCombatants => new RelayCommand(DoAddCombatants);
        private void DoAddCombatants(object param)
        {
            MultiObjectSelectionDialog selectionDialog = new(ReferenceData.Combatants);
        }

    }
}
