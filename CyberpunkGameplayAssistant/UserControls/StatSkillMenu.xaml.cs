using CyberpunkGameplayAssistant.Toolbox;
using System.Windows.Controls;

namespace CyberpunkGameplayAssistant.UserControls
{
    /// <summary>
    /// Interaction logic for StatSkillMenu.xaml
    /// </summary>
    public partial class StatSkillMenu : UserControl
    {
        public StatSkillMenu()
        {
            InitializeComponent();
        }

        private void ScrollViewer_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            AppData.ScrollHandled = true;
        }
    }
}
