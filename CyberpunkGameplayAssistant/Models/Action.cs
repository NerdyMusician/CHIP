using CyberpunkGameplayAssistant.Toolbox;
using CyberpunkGameplayAssistant.Toolbox.ExtensionMethods;
using CyberpunkGameplayAssistant.Windows;
using System;
using System.Linq;
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
                ReferenceData.ActionDeathSave => PerformActionDeathSave(combatant),
                ReferenceData.ActionEvade => PerformActionEvade(combatant),
                ReferenceData.ActionGrab => PerformActionGrab(combatant),
                ReferenceData.ActionInitiative => PerformActionInitiative(combatant),
                ReferenceData.ActionThrowGrapple => PerformActionThrowGrapple(combatant),
                ReferenceData.ActionThrowObject => PerformActionThrowObject(combatant),
                _ => ""
            };
            if (string.IsNullOrEmpty(result))
            {
                RaiseError($"Unhandled standard action: {action}");
                return;
            }
            else
            {
                HelperMethods.AddToGameplayLog(result, ReferenceData.MessageStandardAction);
            }

        }
        public ICommand PerformNetAction => new RelayCommand(DoPerformNetAction);
        private void DoPerformNetAction(object param)
        {
            Combatant combatant = (Combatant)(param as object[])![0];
            string action = (param as object[])![1].ToString()!;
            string result = action switch
            {
                ReferenceData.NetActionInterface => PerformNetActionInterface(combatant),
                ReferenceData.NetActionJackIn => $"{combatant.DisplayName} has jacked in to a NET Architecture",
                ReferenceData.NetActionJackOut => $"{combatant.DisplayName} has safely jacked out from a NET Architecture",
                ReferenceData.NetActionActivateProgram => PerformNetActionActivateProgram(combatant),
                ReferenceData.NetActionScanner => PerformNetActionBasic(combatant, "scanned for NET access points"),
                ReferenceData.NetActionBackdoor => PerformNetActionBasic(combatant, "attempts to break through a password"),
                ReferenceData.NetActionCloak => PerformNetActionBasic(combatant, "attempts to hide traces of their presence in the NET"),
                ReferenceData.NetActionControl => PerformNetActionBasic(combatant, "attempts to take over a control node"),
                ReferenceData.NetActionEyeDee => PerformNetActionBasic(combatant, "attempts to identify a file"),
                ReferenceData.NetActionPathfinder => PerformNetActionBasic(combatant, "attempts to reveal the NET architecture"),
                ReferenceData.NetActionSlide => PerformNetActionBasic(combatant, "attempts to flee from Black ICE's PER"),
                ReferenceData.NetActionVirus => PerformNetActionBasic(combatant, "attempts to create a virus"),
                ReferenceData.NetActionZap => PerformNetActionZap(combatant),
                _ => string.Empty
            };
            if (string.IsNullOrEmpty(result))
            {
                RaiseError($"Unhandled NET action: {action}");
                return;
            }
            else
            {
                HelperMethods.AddToGameplayLog(result, ReferenceData.MessageStandardAction);
            }
        }

        // Private Methods
        #region Standard Actions
        private static string PerformActionBrawl(Combatant combatant)
        {
            int attack = HelperMethods.RollSkillCheck(combatant, ReferenceData.StatDexterity, ReferenceData.SkillBrawling);
            int body = combatant.CalculatedStats.GetValue(ReferenceData.StatBody);
            if (combatant.InstalledCyberware.FirstOrDefault(c => c.Name == ReferenceData.CyberwareCyberarm) != null)
            {
                body = (body > 5) ? body : 5;
            }
            int damage = body switch
            {
                <= 4 => 1,
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
            return $"{combatant.DisplayName} choked their target for {combatant.CalculatedStats.GetValue(ReferenceData.StatBody)} damage";
        }
        private static string PerformActionDeathSave(Combatant combatant)
        {
            int result = HelperMethods.RollD10();
            result += combatant.DeathSavePasses;
            result += combatant.CriticalInjuries.GetDeathPenaltyTotal();
            bool success = result < combatant.DeathSave;
            if (!success) { combatant.IsDead = true; combatant.UpdateWoundState(); }
            if (success) { combatant.DeathSavePasses++; }
            return $"{combatant.DisplayName} made a death save\nResult: {(success ? "Success" : "Fail")}";
        }
        private static string PerformActionEvade(Combatant combatant)
        {
            int result = HelperMethods.RollSkillCheck(combatant, ReferenceData.StatDexterity, ReferenceData.SkillEvasion);
            return $"{combatant.DisplayName} attempted to Evade\nResult: {result}";
        }
        private static string PerformActionGrab(Combatant combatant)
        {
            int result = HelperMethods.RollSkillCheck(combatant, ReferenceData.StatDexterity, ReferenceData.SkillBrawling);
            return $"{combatant.DisplayName} attempted to Grab/Resist\nResult: {result}";
        }
        private static string PerformActionInitiative(Combatant combatant)
        {
            int result = combatant.GetInitiative();
            combatant.Initiative = result;
            return $"{combatant.DisplayName} rolled initiative\nResult: {result}";
        }
        private static string PerformActionThrowGrapple(Combatant combatant)
        {
            return $"{combatant.DisplayName} threw their target prone for {combatant.CalculatedStats.GetValue(ReferenceData.StatBody)} damage";
        }
        private static string PerformActionThrowObject(Combatant combatant)
        {
            int result = HelperMethods.RollSkillCheck(combatant, ReferenceData.StatDexterity, ReferenceData.SkillAthletics);
            return $"{combatant.DisplayName} threw an object\nResult: {result}";
        }
        #endregion

        #region NET Actions
        private static string PerformNetActionInterface(Combatant combatant)
        {
            GetInterfaceCheck(combatant, out int roll, out int interfaceLevel);
            string output = $"{combatant.DisplayName} made an Interface check\nResult: {roll + interfaceLevel}";
            output += GetInterfaceDebugText(roll, interfaceLevel);
            return output;
        }
        private static string PerformNetActionActivateProgram(Combatant combatant)
        {
            ObjectSelectionDialog selectionDialog = new(combatant.CyberdeckPrograms.ToList().ToNamedRecordList(), "Programs");
            if (selectionDialog.ShowDialog() == true)
            {
                NamedRecord selectedRecord = selectionDialog.SelectedObject as NamedRecord;
                CyberdeckProgram program = combatant.CyberdeckPrograms.FirstOrDefault(p => p.Name == selectedRecord.Name);
                if (program == null) { RaiseError($"Program {selectedRecord.Name} not found"); return string.Empty; }
                CyberdeckProgram duplicateProgram = combatant.ActivePrograms.FirstOrDefault(p => p.Name == program.Name);
                if (duplicateProgram != null) { RaiseError($"Program {program.Name} already active for {combatant.DisplayName}"); return string.Empty; }
                combatant.ActivePrograms.Add(program);
                return $"{program.Name} added to Active Programs for {combatant.DisplayName}";
            }
            return string.Empty;
        }
        private static string PerformNetActionBasic(Combatant combatant, string insert)
        {
            GetInterfaceCheck(combatant, out int roll, out int interfaceLevel);
            string output = $"{combatant.DisplayName} {insert}\nResult: {roll + interfaceLevel}";
            output += GetInterfaceDebugText(roll, interfaceLevel);
            return output;
        }
        private static string PerformNetActionZap(Combatant combatant)
        {
            GetInterfaceCheck(combatant, out int roll, out int interfaceLevel);
            int damage = HelperMethods.RollDice(1, 6).Sum();
            string output = $"{combatant.DisplayName} attempts to create a virus\nResult: {roll + interfaceLevel}\nDamage: {damage}";
            output += GetInterfaceDebugText(roll, interfaceLevel);
            return output;
        }
        private static void GetInterfaceCheck(Combatant combatant, out int roll, out int interfaceLevel)
        {
            roll = HelperMethods.RollD10();
            interfaceLevel = combatant.Skills.GetLevel(ReferenceData.SkillInterface);
        }
        private static string GetInterfaceDebugText(int roll, int interfaceLevel)
        {
            return ReferenceData.DebugMode ? $"\nDEBUG: ROLL: {roll} INTERFACE: {interfaceLevel}" : "";
        }
        #endregion

    }
}
