namespace CyberpunkGameplayAssistant.Models
{
    public class MarketWeapon : BaseModel
    {
        public MarketWeapon(string name, string type, string quality)
        {
            Name = name;
            Type = type;
            Quality = quality;
        }
        private string _Name;
        public string Name
        {
            get => _Name;
            set => SetAndNotify(ref _Name, value);
        }
        private string _Type;
        public string Type
        {
            get => _Type;
            set => SetAndNotify(ref _Type, value);
        }
        private string _Quality;
        public string Quality
        {
            get => _Quality;
            set => SetAndNotify(ref _Quality, value);
        }
    }
}
