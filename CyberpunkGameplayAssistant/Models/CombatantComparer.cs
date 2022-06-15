using CyberpunkGameplayAssistant.Toolbox;
using System.Windows.Input;

namespace CyberpunkGameplayAssistant.Models
{
    public class CombatantComparer : BaseModel
    {
        // Constructors
        public CombatantComparer()
        {

        }
        public CombatantComparer(Combatant a, Combatant b)
        {
            CombatantA = a;
            CombatantB = b;
            CombatantASelected = true;
        }

        // Properties
        private bool _CombatantASelected;
        public bool CombatantASelected
        {
            get => _CombatantASelected;
            set => SetAndNotify(ref _CombatantASelected, value);
        }
        private bool _CombatantBSelected;
        public bool CombatantBSelected
        {
            get => _CombatantBSelected;
            set => SetAndNotify(ref _CombatantBSelected, value);
        }
        private Combatant _CombatantA;
        public Combatant CombatantA
        {
            get => _CombatantA;
            set => SetAndNotify(ref _CombatantA, value);
        }
        private Combatant _CombatantB;
        public Combatant CombatantB
        {
            get => _CombatantB;
            set => SetAndNotify(ref _CombatantB, value);
        }
        private bool _CombatantInfoDisplayed;
        public bool CombatantInfoDisplayed
        {
            get => _CombatantInfoDisplayed;
            set => SetAndNotify(ref _CombatantInfoDisplayed, value);
        }

        // Commands
        public ICommand ToggleSelectedCombatant => new RelayCommand(DoToggleSelectedCombatant);
        private void DoToggleSelectedCombatant(object param)
        {
            if (param.ToString() == "A")
            {
                CombatantBSelected = !CombatantASelected;
            }
            if (param.ToString() == "B")
            {
                CombatantASelected = !CombatantBSelected;
            }
        }

    }
}
