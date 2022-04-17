using CyberpunkGameplayAssistant.Models;
using System.Collections.ObjectModel;
using System.Linq;

#pragma warning disable CS8602 // Dereference of a possibly null reference.
namespace CyberpunkGameplayAssistant.Toolbox
{
    public static class ExtensionMethods
    {
        public static int GetTotal(this int[] values)
        {
            int total = 0;
            foreach (int value in values)
            {
                total += value;
            }
            return total;
        }
        public static int GetValue(this ObservableCollection<Stat> stats, string statName)
        {
            return stats.FirstOrDefault(s => s.Name == statName).Value;
        }
        public static int GetValue(this ObservableCollection<Skill> skills, string skillName)
        {
            return skills.FirstOrDefault(s => s.Name == skillName).Value;
        }
    }
}
#pragma warning restore CS8602 // Dereference of a possibly null reference.