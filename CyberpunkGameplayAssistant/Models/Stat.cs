using CyberpunkGameplayAssistant.Toolbox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CyberpunkGameplayAssistant.Models
{
    public class Stat : BaseModel
    {
        // Constructors
        public Stat()
        {

        }
        public Stat(string name)
        {
            Name = name;
        }
        public Stat(string name, int value)
        {
            Name = name;
            Value = value;
        }

        // Databound Properties
        private string _Name;
        
        public string Name
        {
            get => _Name;
            set => SetAndNotify(ref _Name, value);
        }
        private int _Value;
        
        public int Value
        {
            get => _Value;
            set => SetAndNotify(ref _Value, value);
        }

        // Properties
        public string StatAbbr
        {
            get
            {
                return ReferenceData.StatLinks.FirstOrDefault(s => s.StatName == Name)!.Abbreviation;
            }
        }

        // Commands
        public ICommand RollStat => new RelayCommand(DoRollStat);
        private void DoRollStat(object param)
        {
            Combatant combatant = param as Combatant;
            int diceRoll = HelperMethods.RollD10();
            int penalty = 0; // TODO - critical injuries
            string output = $"{combatant.DisplayName} made {Name.AOrAn()} roll";
            output += $"\nResult: {diceRoll + Value + penalty}";
            if (ReferenceData.DebugMode) { output += $"\nDEBUG: ROLL: {diceRoll}, STAT: {Value}, PENALTY: {penalty}"; }
            HelperMethods.AddToGameplayLog(output, ReferenceData.MessageBlackIceStat);
        }

    }
}
