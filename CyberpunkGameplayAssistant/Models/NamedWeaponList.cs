using System.Collections.Generic;

namespace CyberpunkGameplayAssistant.Models
{
    public class NamedWeaponList
    {
        public NamedWeaponList()
        {
            WeaponNames = new();
        }
        public NamedWeaponList(string type, string quality, params string[] names)
        {
            WeaponType = type;
            WeaponQuality = quality;
            WeaponNames = new(names);
        }
        public string WeaponType { get; set; }
        public string WeaponQuality { get; set; }
        public List<string> WeaponNames { get; set; }
    }
}
