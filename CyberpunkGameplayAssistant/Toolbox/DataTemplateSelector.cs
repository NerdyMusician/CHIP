using CyberpunkGameplayAssistant.Models;
using System.Windows;
using System.Windows.Controls;

namespace CyberpunkGameplayAssistant.Toolbox
{
    public class CombatTrackerTemplateSelector : DataTemplateSelector
    {
        public DataTemplate DefaultDataTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item == null) { return DefaultDataTemplate; }
            return DefaultDataTemplate;
        }
    }

    public class ObjectTypeTemplateSelector : DataTemplateSelector
    {
        public DataTemplate DefaultDataTemplate { get; set; }
        public DataTemplate CombatantTemplate { get; set; }
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item.GetType() == typeof(Combatant)) { return CombatantTemplate; }
            return DefaultDataTemplate;

        }

    }

}
