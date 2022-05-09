using CyberpunkGameplayAssistant.Models;
using System.Windows;
using System.Windows.Controls;

namespace CyberpunkGameplayAssistant.Toolbox
{
    public class CombatTrackerTemplateSelector : DataTemplateSelector
    {
        public DataTemplate DefaultDataTemplate { get; set; }
        public DataTemplate CombatantDataTemplate { get; set; }
        public DataTemplate PlayerDataTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item == null) { return DefaultDataTemplate; }
            if (item.GetType() == typeof(Combatant))
            {
                return ((item as Combatant)!.IsPlayer) ? PlayerDataTemplate : CombatantDataTemplate;
            }
            return DefaultDataTemplate;
        }
    }

    public class ObjectTypeTemplateSelector : DataTemplateSelector
    {
        public DataTemplate DefaultDataTemplate { get; set; }
        public DataTemplate CombatantTemplate { get; set; }
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item.GetType() == typeof(Combatant)) 
            {
                return CombatantTemplate;
            }
            return DefaultDataTemplate;

        }

    }

}
