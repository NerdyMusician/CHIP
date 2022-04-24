using CyberpunkGameplayAssistant.Toolbox;

namespace CyberpunkGameplayAssistant.Models
{
    public class CombatantWeapon : BaseModel
    {
        public CombatantWeapon(string weaponType, string weaponQuality, string weaponName)
        {
            Type = weaponType;
            Quality = weaponQuality;
            Name = string.IsNullOrEmpty(weaponName) ? weaponType : weaponName;
        }

        private string _Name;
        [XmlSaveMode(XSME.Single)]
        public string Name
        {
            get => _Name;
            set => SetAndNotify(ref _Name, value);
        }
        private string _Type;
        [XmlSaveMode(XSME.Single)]
        public string Type
        {
            get => _Type;
            set => SetAndNotify(ref _Type, value);
        }
        private string _Quality;
        [XmlSaveMode(XSME.Single)]
        public string Quality
        {
            get => _Quality;
            set => SetAndNotify(ref _Quality, value);
        }
        private int _CurrentClipQuantity;
        [XmlSaveMode(XSME.Single)]
        public int CurrentClipQuantity
        {
            get => _CurrentClipQuantity;
            set => SetAndNotify(ref _CurrentClipQuantity, value);
        }

    }
}
