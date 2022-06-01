namespace CyberpunkGameplayAssistant.Models
{
    public class Weapon : BaseModel
    {
        // Constructors
        public Weapon()
        {

        }
        public Weapon(string type, string skill, int damage, int handsRequired, string ammoType, int rof, bool canBeConcealed)
        {
            Type = type;
            AssociatedSkill = skill;
            Damage = damage;
            HandsRequired = handsRequired;
            AmmoType = ammoType;
            RateOfFire = rof;
            CanBeConcealed = canBeConcealed;
        }

        // Databound Properties
        private string _Type;
        public string Type
        {
            get => _Type;
            set => SetAndNotify(ref _Type, value);
        }
        private string _AssociatedSkill;
        public string AssociatedSkill
        {
            get => _AssociatedSkill;
            set => SetAndNotify(ref _AssociatedSkill, value);
        }
        private int _HandsRequired;
        public int HandsRequired
        {
            get => _HandsRequired;
            set => SetAndNotify(ref _HandsRequired, value);
        }
        private int _Damage;
        public int Damage
        {
            get => _Damage;
            set => SetAndNotify(ref _Damage, value);
        }
        private int _RateOfFire;
        public int RateOfFire
        {
            get => _RateOfFire;
            set => SetAndNotify(ref _RateOfFire, value);
        }
        private string _AmmoType;
        public string AmmoType
        {
            get => _AmmoType;
            set => SetAndNotify(ref _AmmoType, value);
        }
        private bool _CanBeConcealed;
        public bool CanBeConcealed
        {
            get => _CanBeConcealed;
            set => SetAndNotify(ref _CanBeConcealed, value);
        }
        private string _CostTier;
        public string CostTier
        {
            get => _CostTier;
            set => SetAndNotify(ref _CostTier, value);
        }
        private string _Quality;
        public string Quality
        {
            get => _Quality;
            set => SetAndNotify(ref _Quality, value);
        }

    }
}
