using CyberpunkGameplayAssistant.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace CyberpunkGameplayAssistant.Toolbox.ExtensionMethods
{
    public static class General
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
            Stat matchedStat = stats.FirstOrDefault(s => s.Name == statName)!;
            return (matchedStat != null) ? matchedStat.Value : 0;
        }
        public static int GetLevel(this ObservableCollection<Skill> skills, string skillName)
        {
            Skill matchedSkill = skills.FirstOrDefault(s => s.Name == skillName)!;
            return (matchedSkill != null) ? (matchedSkill.Level) : 0;
        }
        public static bool IsNullOrEmpty(this string text)
        {
            return (text == null || text == string.Empty) ? true : false;
        }
        public static int GetCost(this List<SkillLinkReference> skills, string skillName)
        {
            SkillLinkReference? skillLink = skills.FirstOrDefault(s => s.SkillName == skillName);
            return (skillLink != null) ? skillLink.CostPerLevel : 1;
        }
        public static string GetCategory(this List<SkillLinkReference> skills, string skillName)
        {
            return skills.FirstOrDefault(s => s.SkillName == skillName).Category;
        }
        public static string GetStat(this List<SkillLinkReference> skills, string skillName)
        {
            return skills.FirstOrDefault(s => s.SkillName == skillName).StatName;
        }
        public static int GetStoppingPower(this List<Armor> armorList, string armorType)
        {
            Armor? armor = armorList.FirstOrDefault(a => a.Name == armorType);
            return (armor != null) ? armor.StoppingPower : 0;
        }
        public static int GetPenalty(this List<Armor> armorList, string armorType)
        {
            Armor matchedArmor = armorList.FirstOrDefault(a => a.Name == armorType)!;
            return (matchedArmor != null) ? matchedArmor.ArmorPenalty : 0;
        }
        public static int GetStandardClipSize(this List<RangedWeaponClip> clipList, string weaponType)
        {
            RangedWeaponClip clip = clipList.FirstOrDefault(c => c.WeaponType == weaponType)!;
            if (clip != null) { return clip.Standard; }
            return 1;
        }
        public static int GetDamage(this List<Weapon> weaponList, string weaponType)
        {
            return weaponList.FirstOrDefault(w => w.Type == weaponType).Damage;
        }
        public static string GetSkill(this List<Weapon> weaponList, string weaponType)
        {
            return weaponList.FirstOrDefault(w => w.Type == weaponType).AssociatedSkill;
        }
        public static int InstancesOf(this int[] numArray, int matchNum)
        {
            int results = 0;
            foreach (int num in numArray)
            {
                if (num == matchNum) { results++; }
            }
            return results;
        }
        public static int GetDeathPenaltyTotal(this ObservableCollection<CriticalInjury> injuries)
        {
            int total = 0;
            foreach (CriticalInjury injury in injuries)
            {
                if (AppData.CriticalInjuriesThatIncreaseDeathSavePenalty.Contains(injury.Name)) { total++; }
            }
            return total;
        }
        public static int GetMovePenaltyTotal(this ObservableCollection<CriticalInjury> injuries)
        {
            int total = 0;
            foreach (CriticalInjury injury in injuries)
            {
                if (AppData.CriticalInjuryMovePenalties.ContainsKey(injury.Name))
                {
                    total += AppData.CriticalInjuryMovePenalties[injury.Name];
                }
            }
            return total;
        }
        public static string ToFormattedString(this List<string> parts, string separator = "\n")
        {
            string output = "";
            for (int i = 0; i < parts.Count; i++)
            {
                if (i > 0) { output += separator; }
                output += parts[i];
            }
            return output;
        }
        
        public static string AOrAn(this string word)
        {
            return AppData.Vowels.ToList().Contains(word[0].ToString()) ? $"an {word}" : $"a {word}";
        }
        public static CriticalInjury ToCriticalInjury(this NamedRecord record)
        {
            return new(record.Name, record.Description);
        }
        public static Dictionary<string, int> AddPlus(this Dictionary<string, int> dictionary, string key, int value)
        {
            if (dictionary.ContainsKey(key)) { dictionary[key] += value; }
            else { dictionary.Add(key, value); }
            return dictionary;
        }
        public static string ToFormattedString(this Dictionary<string, int> dictionary, string separator = "\n")
        {
            string output = "";
            for (int i = 0; i < dictionary.Count; i++)
            {
                if (i > 0) { output += separator; }
                output += $"{dictionary.ElementAt(i).Key} x {dictionary.ElementAt(i).Value}";
            }
            return output;
        }
        public static bool Contains(this ObservableCollection<CriticalInjury> injuries, string injuryName)
        {
            return injuries.FirstOrDefault(i => i.Name == injuryName) != null;
        }
        public static bool Contains(this ObservableCollection<Cyberware> cyberwareSet, string cyberwareName)
        {
            return cyberwareSet.FirstOrDefault(c => c.Name == cyberwareName) != null;
        }
        public static bool IsIn(this string source, params string[] list)
        {
            return list.Contains(source);
        }
        public static int RoundUp(this int number)
        {
            return number + (10 - Convert.ToInt32(number.ToString().Last().ToString()));
        }

    }
}
