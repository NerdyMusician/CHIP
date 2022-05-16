using CyberpunkGameplayAssistant.Toolbox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace CyberpunkGameplayAssistant.Models
{
    public partial class Combatant : BaseModel
    {
        // Constructors
        public Combatant(string name, string type, string portrait, string armor)
        {
            InitializeLists();
            Name = name;
            Type = type;
            PortraitFilePath = portrait;
            ArmorType = armor;
        }

        // Properties
        private bool _UsesLoyalty;
        public bool UsesLoyalty
        {
            get => _UsesLoyalty;
            set => SetAndNotify(ref _UsesLoyalty, value);
        }
        private int _Loyalty;
        public int Loyalty
        {
            get => _Loyalty;
            set => SetAndNotify(ref _Loyalty, value);
        }

        // Commands
        public ICommand ToggleLoyalty => new RelayCommand(DoToggleLoyalty);
        private void DoToggleLoyalty(object param)
        {
            UsesLoyalty = !UsesLoyalty;
            if (UsesLoyalty) { RaiseAlert($"Loyalty controls enabled for {DisplayName}"); }
            else { RaiseAlert($"Loyal controls disabled for {DisplayName}"); }
        }
        public ICommand MakeLoyaltySave => new RelayCommand(DoMakeLoyaltySave);
        private void DoMakeLoyaltySave(object param)
        {
            int roll = HelperMethods.RollD6();
            if (roll < Loyalty) { HelperMethods.AddToGameplayLog($"{DisplayName} passed their Loyalty check"); }
            else { HelperMethods.AddToGameplayLog($"{DisplayName} failed their Loyalty check"); }
        }

        // Public Methods
        public void SetSkillLevels(int level, params string[] skills)
        {
            foreach (string skill in skills)
            {
                Skill matchedSkill = Skills.FirstOrDefault(s => s.Name == skill);
                if (matchedSkill != null) { matchedSkill.Level = level; }
                else { Skills.Add(new(skill, string.Empty, level)); }
            }
        }


    }
}
