using CyberpunkGameplayAssistant.Models;
using CyberpunkGameplayAssistant.Toolbox.ExtensionMethods;
using CyberpunkGameplayAssistant.Windows;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CyberpunkGameplayAssistant.Toolbox
{
    public static class HelperMethods
    {
        public static void NotifyUser(string type, string message)
        {
            AppData.MainModelRef.AddUserAlert(type, message);
        }
        public static void WriteToLogFile(string message, bool notifyUser = false)
        {
            if (notifyUser) { NotifyUser(AppData.AlertError, message); }
            File.AppendAllText(AppData.File_Log, $"{DateTime.Now}: {message}\n");
        }
        public static int[] RollDice(int numberOfDice, int sidesOnDice)
        {
            int[] diceResults = new int[numberOfDice];
            for (int i = 0; i < diceResults.Length; i++)
            {
                diceResults[i] = AppData.RNG.Next(1, sidesOnDice + 1);
            }
            return diceResults;
        }
        public static int RollSkillCheck(Combatant combatant, string stat, string skill)
        {
            return RollD10() +
                combatant.Skills.GetLevel(skill) +
                combatant.CalculatedStats.GetValue(stat);
        }
        public static int RollDamage(int numberOfDice, out bool criticalInjury)
        {
            criticalInjury = false;
            int[] result = RollDice(numberOfDice, 6);
            if (result.InstancesOf(6) >= 2) { criticalInjury = true; }
            return result.GetTotal();
        }
        public static int RollD10(bool includeCritical = false)
        {
            int result = AppData.RNG.Next(1, 11);
            if (includeCritical)
            {
                if (result == 1)
                {
                    result -= AppData.RNG.Next(1, 11);
                }
                if (result == 10)
                {
                    result += AppData.RNG.Next(1, 11);
                }
            }
            return result;
        }
        public static int RollD6()
        {
            return AppData.RNG.Next(1, 7);
        }
        public static bool FlipCoin()
        {
            return AppData.RNG.Next(0,2) == 0 ? true : false;
        }
        public static string GetAlphabetLetter(int position)
        {
            return AppData.Alphabet[position];
        }
        public static void AddToGameplayLog(string message, string type = "", bool copyToWeb = false)
        {
            if (!AppData.IsLoaded) { return; }
            if (AppData.SkipLogging) { return; }
            if (AppData.MainModelRef.CampaignView == null) { return; }
            GameCampaign campaign = AppData.MainModelRef.CampaignView.ActiveCampaign;
            campaign.EventHistory.Insert(0, new(type, message));
        }
        public static bool AskYesNoQuestion(string question)
        {
            YesNoDialog yesNoDialog = new(question);
            if (yesNoDialog.ShowDialog() == true)
            {
                return yesNoDialog.Answer;
            }
            return false;
        }
        public static string AorAn(string word)
        {
            return AppData.Vowels.ToList().Contains(word[0].ToString()) ? "an" : "a";
        }
        public static string GetUniqueId()
        {
            return Guid.NewGuid().ToString().Replace("-","");
        }
        public static string GetFile(string fileTypeFilter, string saveDirectory)
        {
            OpenFileDialog openFileDialog = new() { Filter = fileTypeFilter };
            if (openFileDialog.ShowDialog() == true)
            {
                string fileName = $"{saveDirectory}{GetUniqueId()}{Path.GetExtension(openFileDialog.FileName)}";
                File.Copy(openFileDialog.FileName, fileName, true);
                return fileName;
            }
            else
            {
                return string.Empty;
            }
        }
        public static void CreateDirectories(string[] directories)
        {
            foreach (string directory in directories)
            {
                Directory.CreateDirectory(directory);
            }
        }
        public static void PlayWeaponSound(string weaponType)
        {
            if (AppData.WeaponSounds.ContainsKey(weaponType))
            {
                AppData.WindowRef.PlaySound(AppData.WeaponSounds[weaponType]);
            }
        }
        public static void PlayAutofireSound()
        {
            AppData.WindowRef.PlaySound(AppData.AudioAutofire);
        }
        public static void PlayReloadSound()
        {
            AppData.WindowRef.PlaySound(AppData.AudioReload);
        }
        public static void PlayMalfunctionSound()
        {
            AppData.WindowRef.PlaySound(AppData.AudioMalfunction);
        }
        public static void PlayExplosionSound()
        {
            AppData.WindowRef.PlaySound(AppData.AudioExplosion);
        }
        public static string RollNetFloor(int level, string difficulty)
        {
            if (level <= 0) { NotifyUser(AppData.AlertError, $"Invalid floor level {level} passed to HelperMethods.RollNetFloor"); return string.Empty; }
            bool isLobby = (level == 1 || level == 2);
            Dictionary<int, string> lobbyTable = new()
            {
                { 1, "File DV6" },
                { 2, "Password DV6" },
                { 3, "Password DV8" },
                { 4, "Skunk" },
                { 5, "Wisp" },
                { 6, "Killer" }
            };
            Dictionary<int, string> basicTable = new()
            {
                { 3, "Hellhound" },
                { 4, "Sabertooth" },
                { 5, "Raven x 2" },
                { 6, "Hellhound" },
                { 7, "Wisp" },
                { 8, "Raven" },
                { 9, "Password DV6" },
                { 10, "File DV6" },
                { 11, "Control Node DV6" },
                { 12, "Password DV6" },
                { 13, "Skunk" },
                { 14, "Asp" },
                { 15, "Scorpion" },
                { 16, "Killer, Skunk" },
                { 17, "Wisp x 3" },
                { 18, "Liche" }
            };
            Dictionary<int, string> standardTable = new()
            {
                { 3, "Hellhound x 2" },
                { 4, "Hellhound, Killer" },
                { 5, "Skunk x 2" },
                { 6, "Sabertooth" },
                { 7, "Scorpion" },
                { 8, "Hellhound" },
                { 9, "Password DV8" },
                { 10, "File DV8" },
                { 11, "Control Node DV8" },
                { 12, "Password DV8" },
                { 13, "Asp" },
                { 14, "Killer" },
                { 15, "Liche" },
                { 16, "Asp" },
                { 17, "Raven x 3" },
                { 18, "Liche, Raven" }
            };
            Dictionary<int, string> uncommonTable = new()
            {
                { 3, "Kraken" },
                { 4, "Hellhound, Scorpion" },
                { 5, "Hellhound, Killer" },
                { 6, "Raven x 2" },
                { 7, "Sabertooth" },
                { 8, "Hellhound" },
                { 9, "Password DV10" },
                { 10, "File DV10" },
                { 11, "Control Node DV10" },
                { 12, "Password DV10" },
                { 13, "Killer" },
                { 14, "Liche" },
                { 15, "Dragon" },
                { 16, "Asp, Raven" },
                { 17, "Dragon, Wisp" },
                { 18, "Giant" },
            };
            Dictionary<int, string> advancedTable = new()
            {
                { 3, "Hellhound x 3" },
                { 4, "Asp x 2" },
                { 5, "Hellhound, Liche" },
                { 6, "Wisp x 3" },
                { 7, "Hellhound, Sabertooth" },
                { 8, "Kraken" },
                { 9, "Password DV12" },
                { 10, "File DV12" },
                { 11, "Control Node DV12" },
                { 12, "Password DV12" },
                { 13, "Giant" },
                { 14, "Dragon" },
                { 15, "Killer, Scorpion" },
                { 16, "Kraken" },
                { 17, "Raven, Wisp, Hellhound" },
                { 18, "Dragon x 2" }
            };

            int diceResult = isLobby ? RollDice(1, 6).Sum() : RollDice(3, 6).Sum();
            Dictionary<int, string> otherTable = difficulty switch
            {
                AppData.NetArchitectureDifficultyBasic => basicTable,
                AppData.NetArchitectureDifficultyStandard => standardTable,
                AppData.NetArchitectureDifficultyUncommon => uncommonTable,
                _ => advancedTable
            };
            return (level == 1 || level == 2) ? lobbyTable[diceResult] : otherTable[diceResult];

        }
        public static string ProcessAmmoEffect(int damage, bool isCrit, string variant)
        {
            string output = "";
            if (variant.IsIn(AppData.AmmoVarBasic, AppData.AmmoVarArmorPiercing, AppData.AmmoVarExpansive,
                AppData.AmmoVarIncendiary, AppData.AmmoVarRubber))
            {
                output += $"\nDamage: {damage + (isCrit && variant != AppData.AmmoVarRubber ? 5 : 0)}"; // pg 187 Critical Injury Bonus Damage
                if (variant != AppData.AmmoVarRubber && isCrit) { output += " CRIT"; }
                if (variant == AppData.AmmoVarArmorPiercing) { output += " AP"; }
            }
            if (variant == AppData.AmmoVarBiotoxin)
            {
                output += $"\nTarget must pass a DV15 Resist Drugs Check or take {HelperMethods.RollDamage(3, out _)} direct damage.";
            }
            if (variant == AppData.AmmoVarEMP)
            {
                output += $"\nTarget must pass a DV15 Cybertech Check, or up to two pieces of their Cyberware or carried electronics become inoperable for 1 minute.";
            }
            if (variant == AppData.AmmoVarExpansive)
            {
                if (isCrit) { output += "\nIf you cause the Foreign Object injury, roll another injury. This second injury deals no bonus damage."; }
            }
            if (variant == AppData.AmmoVarFlashbang)
            {
                output += $"\nTarget must pass a DV15 Resist Torture Check or suffer the Damaged Eye and Damaged Ear injuries for the next minute. This does not cause bonus damage.";
            }
            if (variant == AppData.AmmoVarIncendiary)
            {
                output += $"\nIf a target takes damage, they are ignited, and take two direct damage to their HP at the end of their turn until they take an action to put themselves out.";
            }
            if (variant == AppData.AmmoVarPoison)
            {
                output += $"\nTarget must pass a DV13 Resist Drugs Check or take {HelperMethods.RollDamage(3, out _)} direct damage.";
            }
            if (variant == AppData.AmmoVarRubber)
            {
                output += $"\nTargets reduced to 0 HP are instead left at 1 HP.";
            }
            if (variant == AppData.AmmoVarSleep)
            {
                output += $"\nTarget must pass a DV13 Resist Drugs Check or falls Prone and Unconscious for 1 minute until awoken by taking damage or my someone using an Action to touch them.";
            }
            if (variant == AppData.AmmoVarSmart)
            {
                output += $"\nSee Page 346.";
            }
            if (variant == AppData.AmmoVarSmoke)
            {
                output += $"\nObscures a 5x5 tile area with smoke for 1 minute.";
            }
            if (variant == AppData.AmmoVarTeargas)
            {
                output += $"\nTargets with meat eyes must pass a DV13 Resist Torture Check or suffer the Damaged Eye injury for the next minute. This does not cause bonus damage.";
            }
            return output;
        }
    }
}
