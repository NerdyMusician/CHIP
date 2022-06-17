using CyberpunkGameplayAssistant.Toolbox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CyberpunkGameplayAssistant.Models
{
    public class EncounterCombatant : BaseModel
    {
        // Constructors
        public EncounterCombatant()
        {

        }

        // Properties
        private string _Name;
        public string Name
        {
            get => _Name;
            set => SetAndNotify(ref _Name, value);
        }
        private int _RatioA;
        public int RatioA
        {
            get => _RatioA;
            set => SetAndNotify(ref _RatioA, value);
        }
        private int _RatioB;
        public int RatioB
        {
            get => _RatioB;
            set => SetAndNotify(ref _RatioB, value);
        }

        // Commands
        public ICommand RemoveCombatant => new RelayCommand(DoRemoveCombatant);
        private void DoRemoveCombatant(object param)
        {
            AppData.MainModelRef.EncounterView.ActiveEncounter.Combatants.Remove(this);
        }

    }
}
