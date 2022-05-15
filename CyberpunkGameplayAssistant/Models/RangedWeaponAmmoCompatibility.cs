using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberpunkGameplayAssistant.Models
{
    public class RangedWeaponAmmoCompatibility : BaseModel
    {
        public RangedWeaponAmmoCompatibility()
        {
            AmmoTypes = new();
        }
        public RangedWeaponAmmoCompatibility(string weaponType, params string[] ammoTypes)
        {
            WeaponType = weaponType;
            AmmoTypes = ammoTypes.ToList();
        }
        public string WeaponType { get; set; }
        public List<string> AmmoTypes { get; set; }

    }
}
