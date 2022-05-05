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
        [XmlSaveMode(XSME.Single)]
        public string Name
        {
            get => _Name;
            set => SetAndNotify(ref _Name, value);
        }
        private int _Value;
        [XmlSaveMode(XSME.Single)]
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
            string output = $"{combatant.DisplayName} made a {Name} check\n";
            int result = HelperMethods.RollD10();
            int stat = combatant.CalculatedStats.GetValue(Name);
            if (new List<string> { ReferenceData.StatReflexes, ReferenceData.StatDexterity, ReferenceData.StatMovement }.Contains(Name))
            {
                stat -= ReferenceData.ArmorTable.GetPenalty(combatant.ArmorType);
            }
            output += $"Result: {result + stat}\n";
            HelperMethods.AddToGameplayLog(output, ReferenceData.MessageTypeSkillCheck);
        }

    }
}
