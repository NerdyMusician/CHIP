using CyberpunkGameplayAssistant.Toolbox;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace CyberpunkGameplayAssistant.Windows
{
    public partial class ObjectSelectionDialog : Window
    {
        // Constructors
        public ObjectSelectionDialog()
        {
            InitializeComponent();

        }
        public ObjectSelectionDialog(List<NamedRecord> records, string header)
        {
            InitializeComponent();
            DialogHeader.Text = header;
            ObjectSelectDropdown.ItemsSource = records;
        }

        // Properties
        public object SelectedObject
        {
            get
            {
                return ObjectSelectDropdown.SelectedItem;
            }
        }

        // Private Methods
        private void Window_Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Submit_Clicked(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left && e.ButtonState == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

    }
}
