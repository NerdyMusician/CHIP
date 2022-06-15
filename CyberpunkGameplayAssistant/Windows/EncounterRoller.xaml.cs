using CyberpunkGameplayAssistant.Toolbox;
using CyberpunkGameplayAssistant.Toolbox.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CyberpunkGameplayAssistant.Windows
{
    public partial class EncounterRoller : Window
    {
        public EncounterRoller()
        {
            InitializeComponent();
            List<string> encounterTypes = AppData.MainModelRef.EncounterTypes.DeepClone();
            encounterTypes.Insert(0, "Any");
            GCBX_EncounterTypes.ItemsSource = encounterTypes;
            List<string> threatLevels = AppData.MainModelRef.ThreatLevels.DeepClone();
            threatLevels.Insert(0, "Any");
            GCBX_ThreatLevels.ItemsSource = threatLevels;
        }
        public string EncounterType
        {
            get
            {
                if (string.IsNullOrEmpty(GCBX_EncounterTypes.Text)) { return "Any"; }
                return GCBX_EncounterTypes.Text;
            }
        }
        public string ThreatLevel
        {
            get
            {
                if (string.IsNullOrEmpty(GCBX_ThreatLevels.Text)) { return "Any"; }
                return GCBX_ThreatLevels.Text;
            }
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left && e.ButtonState == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
        private void Submit_Clicked(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
        private void Cancel_Clicked(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
