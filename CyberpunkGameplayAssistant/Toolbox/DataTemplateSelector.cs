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
        public DataTemplate BlackIceDataTemplate { get; set; }
        public DataTemplate DemonDataTemplate { get; set; }
        public DataTemplate ActiveDefenseDataTemplate { get; set; }
        public DataTemplate EmplacedDefenseDataTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item == null) { return DefaultDataTemplate; }
            if (item.GetType() == typeof(Combatant))
            {
                return ((item as Combatant)!.Type) switch
                {
                    AppData.ComTypePlayer => PlayerDataTemplate,
                    AppData.ComTypeBlackIce => BlackIceDataTemplate,
                    AppData.ComTypeDemon => DemonDataTemplate,
                    AppData.ComTypeActiveDefense => ActiveDefenseDataTemplate,
                    AppData.ComTypeEmplacedDefense => EmplacedDefenseDataTemplate,
                    _ => CombatantDataTemplate
                };
            }
            return DefaultDataTemplate;
        }
    }

    public class ObjectTypeTemplateSelector : DataTemplateSelector
    {
        public DataTemplate DefaultDataTemplate { get; set; }
        public DataTemplate CombatantTemplate { get; set; }
        public DataTemplate CombatantComparerTemplate { get; set; }
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item.GetType() == typeof(Combatant)) { return CombatantTemplate; }
            if (item.GetType() == typeof(CombatantComparer)) { return CombatantComparerTemplate; }
            return DefaultDataTemplate;

        }

    }

}
