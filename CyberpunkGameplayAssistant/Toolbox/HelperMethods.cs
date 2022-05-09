using CyberpunkGameplayAssistant.Models;
using CyberpunkGameplayAssistant.Windows;
using Microsoft.Win32;
using System;
using System.IO;

namespace CyberpunkGameplayAssistant.Toolbox
{
    public static class HelperMethods
    {
        public static void NotifyUser(string message)
        {
            new NotificationDialog(message).ShowDialog();
        }
        public static void WriteToLogFile(string message, bool notifyUser = false)
        {
            if (notifyUser) { NotifyUser(message); }
            File.AppendAllText(ReferenceData.File_Log, $"{DateTime.Now}: {message}\n");
        }
        public static int[] RollDice(int numberOfDice, int sidesOnDice)
        {
            int[] diceResults = new int[numberOfDice];
            for (int i = 0; i < diceResults.Length; i++)
            {
                diceResults[i] = ReferenceData.RNG.Next(1, sidesOnDice + 1);
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
            int result = ReferenceData.RNG.Next(1, 11);
            if (includeCritical)
            {
                if (result == 1)
                {
                    result -= ReferenceData.RNG.Next(1, 11);
                }
                if (result == 10)
                {
                    result += ReferenceData.RNG.Next(1, 11);
                }
            }
            return result;
        }
        public static string GetAlphabetLetter(int position)
        {
            return ReferenceData.Alphabet[position];
        }
        public static void AddToGameplayLog(string message, string type = "", bool copyToWeb = false)
        {
            if (ReferenceData.MainModelRef.CampaignView == null) { return; }
            GameCampaign campaign = ReferenceData.MainModelRef.CampaignView.ActiveCampaign;
            campaign.EventHistory.Insert(0, new(type, message));
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
    }
}
