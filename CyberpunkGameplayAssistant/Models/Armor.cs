using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberpunkGameplayAssistant.Models
{
    public class Armor
    {
        public Armor(string name, int stoppingPower, int armorPenalty)
        {
            Name = name;
            StoppingPower = stoppingPower;
            ArmorPenalty = armorPenalty;
        }

        public string Name { get; set; }
        public int StoppingPower { get; set; }
        public int ArmorPenalty { get; set; }

    }
}
