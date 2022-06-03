using CyberpunkGameplayAssistant.Models;
using System.Collections.Generic;

namespace CyberpunkGameplayAssistant.Toolbox.ExtensionMethods
{
    public static class NamedRecordList
    {
        public static List<NamedRecord> ToNamedRecordList(this List<string> items)
        {
            List<NamedRecord> records = new();
            items.Sort();
            foreach (string item in items)
            {
                records.Add(new(item, string.Empty));
            }
            return records;
        }
        public static List<NamedRecord> ToNamedRecordList(this List<CriticalInjury> injuries)
        {
            List<NamedRecord> records = new();
            foreach (CriticalInjury injury in injuries)
            {
                records.Add(new(injury.Name, injury.Description));
            }
            return records;
        }
        public static List<NamedRecord> ToNamedRecordList(this List<Combatant> combatants)
        {
            List<NamedRecord> records = new();
            foreach (Combatant combatant in combatants)
            {
                records.Add(new(combatant.Name, string.Empty));
            }
            return records;
        }
        public static List<NamedRecord> ToNamedRecordList(this List<NPC> npcs)
        {
            List<NamedRecord> records = new();
            foreach (NPC npc in npcs)
            {
                records.Add(new(npc.Name, npc.BaseCombatant));
            }
            return records;
        }
        public static List<NamedRecord> ToNamedRecordList(this List<WeaponOption> weaponOptions)
        {
            List<NamedRecord> records = new();
            foreach (WeaponOption weapon in weaponOptions)
            {
                records.Add(new(weapon.WeaponType, string.Empty));
            }
            return records;
        }
        public static List<NamedRecord> ToNamedRecordList(this List<Ammo> ammoTypes)
        {
            List<NamedRecord> records = new();
            foreach (Ammo ammo in ammoTypes)
            {
                records.Add(new(ammo.Type, ammo.Variant));
            }
            return records;
        }
        public static List<NamedRecord> ToNamedRecordList(this List<CyberdeckProgram> programs)
        {
            List<NamedRecord> records = new();
            foreach (CyberdeckProgram program in programs)
            {
                records.Add(new(program.Name, program.Effect));
            }
            return records;
        }
        public static List<NamedRecord> ToNamedRecordList(this Dictionary<string, string> dictionary)
        {
            List<NamedRecord> records = new();
            foreach (KeyValuePair<string, string> kvp in dictionary)
            {
                records.Add(new(kvp.Key, kvp.Value));
            }
            return records;
        }
    }
}
