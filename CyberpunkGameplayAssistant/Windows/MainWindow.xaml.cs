using CyberpunkGameplayAssistant.Toolbox;
using CyberpunkGameplayAssistant.ViewModels;
using System;
using System.Windows;
using System.Windows.Input;

namespace CyberpunkGameplayAssistant.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void Window_LocationChanged(object sender, EventArgs e)
        {

        }
        private void Window_Deactivated(object sender, EventArgs e)
        {

        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                if ((DataContext as MainViewModel) == null) { return; } // Startup crash
                Application.Current.Shutdown();
            }
            catch (Exception ex)
            {
                HelperMethods.WriteToLogFile(ex.Message, true);
            }
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left && e.ButtonState == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void ToggleMaximize_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
            }
            else
            {
                this.WindowState = WindowState.Maximized;
            }
        }
        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            TitleBar.Width = this.ActualWidth;
        }
    }
}
