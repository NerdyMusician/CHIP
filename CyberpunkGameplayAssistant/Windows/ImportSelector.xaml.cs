using CyberpunkGameplayAssistant.Models;
using CyberpunkGameplayAssistant.ViewModels;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace CyberpunkGameplayAssistant.Windows
{
    public partial class ImportSelector : Window
    {
        public ImportSelector(string mode, List<Comparer> combatants)
        {
            InitializeComponent();
            Title = mode;
            DataContext = new ImporterViewModel(mode, combatants);
            ItemsToCompare.SetBinding(ItemsControl.ItemsSourceProperty, new Binding
            {
                Source = (DataContext as ImporterViewModel).ComparedItems
            });
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
