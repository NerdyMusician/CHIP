using CyberpunkGameplayAssistant.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberpunkGameplayAssistant.ViewModels
{
    public class ImporterViewModel : BaseModel
    {
        // Constructors
        public ImporterViewModel(string mode, List<CombatantComparer> combatants)
        {
            InitializeCollections();
            Mode = mode;
            ComparedCombatants = new(combatants);
        }
        private void InitializeCollections()
        {
            ComparedCombatants = new();
        }

        // Properties
        private string _Mode;
        public string Mode
        {
            get => _Mode;
            set => SetAndNotify(ref _Mode, value);
        }
        private ObservableCollection<CombatantComparer> _ComparedCombatants;
        public ObservableCollection<CombatantComparer> ComparedCombatants
        {
            get => _ComparedCombatants;
            set => SetAndNotify(ref _ComparedCombatants, value);
        }

    }
}
