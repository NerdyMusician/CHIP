using CyberpunkGameplayAssistant.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

#pragma warning disable CS8602 // Dereference of a possibly null reference.
namespace CyberpunkGameplayAssistant.Toolbox
{
    public static class ExtensionMethods
    {
        public static T DeepClone<T>(this T obj)
        {
            using MemoryStream ms = new();
            XmlSerializer xmlSerializer = new(typeof(T));
            xmlSerializer.Serialize(ms, obj);
            ms.Position = 0; // Fixes "Root element is missing" issue https://stackoverflow.com/questions/30698349/xml-serializing-and-deserializing-with-memory-stream 
            return (T)xmlSerializer.Deserialize(ms);
        }
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
        public static int GetLevel(this ObservableCollection<Skill> skills, string skillName)
        {
            return skills.FirstOrDefault(s => s.Name == skillName).Level;
        }
        public static bool IsNullOrEmpty(this string text)
        {
            return (text == null || text == string.Empty) ? true : false;
        }
        public static int GetCost(this List<SkillLinkReference> skills, string skillName)
        {
            return skills.FirstOrDefault(s => s.SkillName == skillName).CostPerLevel;
        }
    }
}
#pragma warning restore CS8602 // Dereference of a possibly null reference.