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

}
