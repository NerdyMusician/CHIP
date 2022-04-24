using CyberpunkGameplayAssistant.Models;
using System;
using System.IO;
using System.Windows;
using System.Xml.Serialization;

namespace CyberpunkGameplayAssistant.Toolbox
{
    public static class HelperMethods
    {
        public static void NotifyUser(string message)
        {
            MessageBox.Show(message);
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
        public static int RollD10()
        {
            return ReferenceData.RNG.Next(1, 11);
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
    }
}
