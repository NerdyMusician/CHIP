using System;
using System.IO;
using System.Windows;

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
    }
}
