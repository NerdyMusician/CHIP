using CyberpunkGameplayAssistant.Models;
using CyberpunkGameplayAssistant.Toolbox;
using CyberpunkGameplayAssistant.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace CyberpunkGameplayAssistant.Windows
{
    public partial class MultiObjectSelectionDialog : Window
    {
        // Constructors
        public MultiObjectSelectionDialog(List<Combatant> combatants)
        {
            InitializeComponent();
            WindowTitle.Text = "Combatant Selection";
            DataContext = new MultiObjectSelectionViewModel(combatants);

            SourceItems.SetBinding(ItemsControl.ItemsSourceProperty, new Binding
            {
                Source = (DataContext as MultiObjectSelectionViewModel).FilteredSourceCombatants
            });

            SelectedItems.SetBinding(ItemsControl.ItemsSourceProperty, new Binding
            {
                Source = (DataContext as MultiObjectSelectionViewModel).SelectedCombatants
            });

        }

        // Private Methods
        private void AddItem_Clicked(object sender, RoutedEventArgs e)
        {
            Type objectType = (sender as Button).DataContext.GetType();
            if (objectType == typeof(Combatant))
            {
                Combatant combatant = (sender as Button).DataContext as Combatant;
                Combatant newCombatant = combatant.DeepClone();
                newCombatant.QuantityToAdd = 1;
                (DataContext as MultiObjectSelectionViewModel).SelectedCombatants.Add(newCombatant);
            }
        }
        private void RemoveItem_Clicked(object sender, RoutedEventArgs e)
        {
            Type objectType = (sender as Button).DataContext.GetType();
            if (objectType == typeof(Combatant))
            {
                Combatant combatant = (sender as Button).DataContext as Combatant;
                combatant.QuantityToAdd--;
                if (combatant.QuantityToAdd <= 0)
                {
                    (DataContext as MultiObjectSelectionViewModel).SelectedCombatants.Remove(combatant);
                }
            }
        }
        private void EraserButton_Clicked(object sender, RoutedEventArgs e)
        {
            (DataContext as MultiObjectSelectionViewModel).SourceTextSearch = "";
        }
        private void Submit_Clicked(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
        private void Cancel_Clicked(object sender, RoutedEventArgs e)
        {
            this.Close();
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
