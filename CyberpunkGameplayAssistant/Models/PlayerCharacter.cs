using CyberpunkGameplayAssistant.Toolbox;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
namespace CyberpunkGameplayAssistant.Models
{
    public class PlayerCharacter : BaseModel
    {
        // Constructors
        public PlayerCharacter()
        {
            Messages = new();
            Stats = new();
            Skills = new();
        }

        // Databound Properties
        // Utility
        private ObservableCollection<GameMessage> _Messages;
        
        public ObservableCollection<GameMessage> Messages
        {
            get => _Messages;
            set => SetAndNotify(ref _Messages, value);
        }

        // About Your Character
        private string _Name;
        
        public string Name
        {
            get => _Name;
            set => SetAndNotify(ref _Name, value);
        }
        private string _CulturalOrigin;
        
        public string CulturalOrigin
        {
            get => _CulturalOrigin;
            set => SetAndNotify(ref _CulturalOrigin, value);
        }
        private string _RoleAbility;
        
        public string RoleAbility
        {
            get => _RoleAbility;
            set => SetAndNotify(ref _RoleAbility, value);
        }
        private string _Personality;
        
        public string Personality
        {
            get => _Personality;
            set => SetAndNotify(ref _Personality, value);
        }
        private string _Appearance;
        
        public string Appearance
        {
            get => _Appearance;
            set => SetAndNotify(ref _Appearance, value);
        }
        private string _Background;
        
        public string Background
        {
            get => _Background;
            set => SetAndNotify(ref _Background, value);
        }
        private string _Relationships;
        
        public string Relationships
        {
            get => _Relationships;
            set => SetAndNotify(ref _Relationships, value);
        }

        // THE STAT BLOCK - pg 72
        private string _Rank; // pg 78 - determines stat points
        
        public string Rank
        {
            get => _Rank;
            set => SetAndNotify(ref _Rank, value);
        }
        private ObservableCollection<Stat> _Stats;
        
        public ObservableCollection<Stat> Stats
        {
            get => _Stats;
            set => SetAndNotify(ref _Stats, value);
        }

        // Derived Stats - pg 79
        private int _HitPointsMaximum;
        
        public int HitPointsMaximum
        {
            get => _HitPointsMaximum;
            set => SetAndNotify(ref _HitPointsMaximum, value);
        }
        private int _HitPointsCurrent;
        
        public int HitPointsCurrent
        {
            get => _HitPointsCurrent;
            set => SetAndNotify(ref _HitPointsCurrent, value);
        }
        private int _SeriouslyWoundedThreshold;
        public int SeriouslyWoundedThreshold
        {
            get => _SeriouslyWoundedThreshold;
            set => SetAndNotify(ref _SeriouslyWoundedThreshold, value);
        }
        private int _HumanityMaximum;
        
        public int HumanityMaximum
        {
            get => _HumanityMaximum;
            set => SetAndNotify(ref _HumanityMaximum, value);
        }
        private int _HumanityCurrent;
        
        public int HumanityCurrent
        {
            get => _HumanityCurrent;
            set => SetAndNotify(ref _HumanityCurrent, value);
        }
        private int _Initiative;
        
        public int Initiative
        {
            get => _Initiative;
            set => SetAndNotify(ref _Initiative, value);
        }

        // SKILLS
        private ObservableCollection<Skill> _Skills;
        
        public ObservableCollection<Skill> Skills
        {
            get => _Skills;
            set => SetAndNotify(ref _Skills, value);
        }

        // Commands
        public ICommand RollInitiative => new RelayCommand(DoRollInitiative);
        private void DoRollInitiative(object param)
        {
            Initiative = Stats.GetValue(ReferenceData.StatReflexes) + HelperMethods.RollD10();
        }
        public ICommand MakeSkillCheck => new RelayCommand(DoMakeSkillCheck);
        private void DoMakeSkillCheck(object param)
        {
            string skill = (string)param;
            try
            {
                SkillLinkReference skillRef = ReferenceData.SkillLinks.FirstOrDefault(s => s.SkillName == skill);
                int skillValue = Skills.GetLevel(skillRef.SkillName);
                int statValue = Stats.GetValue(skillRef.StatName);
                int roll = HelperMethods.RollD10();
                string output =
                    $"{Name} makes a {skill} check\n" +
                    $"Result: {(roll + statValue + skillValue)}" +
                    $"Roll: [{roll}] + {statValue} + {skillValue}";
                Messages.Add(new(ReferenceData.MessageSkillCheck, output));
            }
            catch (Exception e)
            {
                HelperMethods.NotifyUser($"Error in DoMakeSkillCheck: {e.Message}");
                return;
            }
        }

        // Private Methods
        private int GetCalculatedMaxHitPoints()
        {
            return (int)(10 + (5 * (((float)Stats.GetValue(ReferenceData.StatBody) + Stats.GetValue(ReferenceData.StatWillpower)) / 2)));
        }
        private int GetCalculatedMaxHumanity()
        {
            return 10 * Stats.GetValue(ReferenceData.StatEmpathy);
        }
        private int GetCalculatedSeriouslyWoundedThreshold()
        {
            return HitPointsMaximum / 2;
        }

    }
}
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning restore CS8602 // Dereference of a possibly null reference.