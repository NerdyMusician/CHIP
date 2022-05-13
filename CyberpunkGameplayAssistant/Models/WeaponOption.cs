using System;

namespace CyberpunkGameplayAssistant.Models
{
    [Serializable]
    public class WeaponOption : BaseModel
    {
        // Constructors
        public WeaponOption()
        {

        }
        public WeaponOption(string weaponType, string weaponQuality, string ammoType, int ammoQty)
        {
            WeaponType = weaponType;
            WeaponQuality = weaponQuality;
            AmmoType = ammoType;
            AmmoQuantity = ammoQty;
        }

        // Databound Properties
        private string _WeaponType;
        public string WeaponType
        {
            get => _WeaponType;
            set => SetAndNotify(ref _WeaponType, value);
        }
        private string _WeaponQuality;
        public string WeaponQuality
        {
            get => _WeaponQuality;
            set => SetAndNotify(ref _WeaponQuality, value);
        }
        private string _AmmoType;
        public string AmmoType
        {
            get => _AmmoType;
            set => SetAndNotify(ref _AmmoType, value);
        }
        private int _AmmoQuantity;
        public int AmmoQuantity
        {
            get => _AmmoQuantity;
            set => SetAndNotify(ref _AmmoQuantity, value);
        }

    }
}
