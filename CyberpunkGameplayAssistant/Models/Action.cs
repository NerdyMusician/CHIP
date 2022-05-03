using CyberpunkGameplayAssistant.Toolbox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CyberpunkGameplayAssistant.Models
{
    [Serializable]
    public class Action : BaseModel
    {
        // Constructors
        public Action()
        {

        }
        public Action(string name)
        {
            Name = name;
        }

        // Databound Properties
        private string _Name;
        public string Name
        {
            get => _Name;
            set => SetAndNotify(ref _Name, value);
        }

        // Commands
        public ICommand PerformStandardAction => new RelayCommand(DoPerformStandardAction);
        private void DoPerformStandardAction(object param)
        {
            Combatant combatant = (Combatant)(param as object[])![0];
            string action = (param as object[])![1].ToString()!;
            string result = action switch
            {
                ReferenceData.ActionBrawl => PerformActionBrawl(combatant),
                ReferenceData.ActionChoke => PerformActionChoke(combatant),
                ReferenceData.ActionEvade => PerformActionEvade(combatant),
                ReferenceData.ActionGrab => PerformActionGrab(combatant),
                ReferenceData.ActionThrowGrapple => PerformActionThrowGrapple(combatant),
                ReferenceData.ActionThrowObject => PerformActionThrowObject(combatant),
                _ => ""
            };
            if (string.IsNullOrEmpty(result))
            {
                HelperMethods.NotifyUser($"Unhandled standard action: {action}");
                return;
            }
            else
            {
                HelperMethods.AddToGameplayLog(result);
            }

        }

        // Private Methods
        private static string PerformActionBrawl(Combatant combatant)
        {
            int attack = HelperMethods.RollD10() +
                combatant.Skills.GetLevel(ReferenceData.SkillBrawling) +
                combatant.Stats.GetValue(ReferenceData.StatDexterity);
            int body = combatant.Stats.GetValue(ReferenceData.StatBody);
            if (combatant.InstalledCyberware.FirstOrDefault(c => c.Name == ReferenceData.CyberwareCyberarm) != null)
            {
                body = (body > 5) ? body : 5;
            }
            int damage = body switch
            {
                <=4 => 1,
                5 => 2,
                6 => 2,
                7 => 3,
                8 => 3,
                9 => 3,
                10 => 3,
                _ => 4,
            };
            damage = HelperMethods.RollDamage(damage, out bool criticalInjury);
            return $"{combatant.DisplayName} is brawling\nAttack: {attack}\nDamage: {damage} {(criticalInjury ? "CRIT" : "")}";
        }
        private static string PerformActionChoke(Combatant combatant)
        {
            return $"{combatant.DisplayName} choked their target for {combatant.Stats.GetValue(ReferenceData.StatBody)} damage";
        }
        private static string PerformActionEvade(Combatant combatant)
        {
            int result = HelperMethods.RollD10() +
                combatant.Skills.GetLevel(ReferenceData.SkillEvasion) +
                combatant.Stats.GetValue(ReferenceData.StatDexterity);
            return $"{combatant.DisplayName} attempted to Evade\nResult: {result}";
        }
        private static string PerformActionGrab(Combatant combatant)
        {
            int result = HelperMethods.RollD10() +
                combatant.Skills.GetLevel(ReferenceData.SkillBrawling) +
                combatant.Stats.GetValue(ReferenceData.StatDexterity);
            return $"{combatant.DisplayName} attempted to Grab/Resist\nResult: {result}";
        }
        private static string PerformActionThrowGrapple(Combatant combatant)
        {
            return $"{combatant.DisplayName} threw their target prone for {combatant.Stats.GetValue(ReferenceData.StatBody)} damage";
        }
        private static string PerformActionThrowObject(Combatant combatant)
        {
            int result = HelperMethods.RollD10() +
                combatant.Skills.GetLevel(ReferenceData.SkillAthletics) +
                combatant.Stats.GetValue(ReferenceData.StatDexterity);
            return $"{combatant.DisplayName} threw an object\nResult: {result}";
        }

    }
}
