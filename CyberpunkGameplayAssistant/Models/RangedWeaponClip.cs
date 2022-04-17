namespace CyberpunkGameplayAssistant.Models
{
    public class RangedWeaponClip : BaseModel
    {
        // Constructors
        public RangedWeaponClip()
        {

        }
        public RangedWeaponClip(string weaponType, int standardSize, int extendedSize, int drumSize)
        {
            WeaponType = weaponType;
            Standard = standardSize;
            Extended = extendedSize;
            Drum = drumSize;
        }

        // Databound Properties
        private string _WeaponType;
        public string WeaponType
        {
            get => _WeaponType;
            set => SetAndNotify(ref _WeaponType, value);
        }
        private int _Standard;
        public int Standard
        {
            get => _Standard;
            set => SetAndNotify(ref _Standard, value);
        }
        private int _Extended;
        public int Extended
        {
            get => _Extended;
            set => SetAndNotify(ref _Extended, value);
        }
        private int _Drum;
        public int Drum
        {
            get => _Drum;
            set => SetAndNotify(ref _Drum, value);
        }

    }
}
