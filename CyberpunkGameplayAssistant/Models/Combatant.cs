using CyberpunkGameplayAssistant.Toolbox;
using System.Collections.ObjectModel;

namespace CyberpunkGameplayAssistant.Models
{
    public class Combatant : Entity
    {
        // Constructors
        public Combatant()
        {
            Stats = new();
        }

        // Databound Properties
        private string _Name;
        [XmlSaveMode(XSME.Single)]
        public string Name
        {
            get => _Name;
            set => SetAndNotify(ref _Name, value);
        }
        private ObservableCollection<Stat> _Stats;
        [XmlSaveMode(XSME.Enumerable)]
        public ObservableCollection<Stat> Stats
        {
            get => _Stats;
            set => SetAndNotify(ref _Stats, value);
        }
        private ObservableCollection<Skill> _Skills;
        [XmlSaveMode(XSME.Enumerable)]
        public ObservableCollection<Skill> Skills
        {
            get => _Skills;
            set => SetAndNotify(ref _Skills, value);
        }

        private int _MaximumHitPoints;
        public int MaximumHitPoints
        {
            get => _MaximumHitPoints;
            set => SetAndNotify(ref _MaximumHitPoints, value);
        }
        private int _CurrentHitPoints;
        [XmlSaveMode(XSME.Single)]
        public int CurrentHitPoints
        {
            get => _CurrentHitPoints;
            set => SetAndNotify(ref _CurrentHitPoints, value);
        }
        private int _SeriouslyWoundedThreshold;
        public int SeriouslyWoundedThreshold
        {
            get => _SeriouslyWoundedThreshold;
            set => SetAndNotify(ref _SeriouslyWoundedThreshold, value);
        }
        private int _DeathSave;
        public int DeathSave
        {
            get => _DeathSave;
            set => SetAndNotify(ref _DeathSave, value);
        }


    }
}
