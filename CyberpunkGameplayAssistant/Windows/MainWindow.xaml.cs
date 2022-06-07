using CyberpunkGameplayAssistant.CustomControls;
using CyberpunkGameplayAssistant.Toolbox;
using CyberpunkGameplayAssistant.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;

namespace CyberpunkGameplayAssistant.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            AppData.WindowRef = this;
            AppData.PopulateData();
            InitializeComponent();
            DataContext = new MainViewModel();
            SfxPlayer.Volume = 1;
            SfxPlayer.Play();
            AppData.IsLoaded = true;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void Window_LocationChanged(object sender, EventArgs e)
        {
            ClosePopups(this);
        }
        private void Window_Deactivated(object sender, EventArgs e)
        {
            ClosePopups(this);
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                if ((DataContext as MainViewModel) == null) { return; } // Startup crash
                (DataContext as MainViewModel).SettingsView.SaveSettings();
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

        private void CopyTextblockText(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText((sender as MenuItem).CommandParameter.ToString());
        }

        private void ClosePopups(Window window)
        {
            foreach (MiniToggleButton toggleButton in FindVisualChildren<MiniToggleButton>(window))
            {
                if (toggleButton.CloseOnWindowFocusLoss == false) { continue; }
                toggleButton.IsChecked = false;
            }
            foreach (ImageToggleButton toggleButton in FindVisualChildren<ImageToggleButton>(window))
            {
                if (toggleButton.CloseOnWindowFocusLoss == false) { continue; }
                toggleButton.IsChecked = false;
            }
            foreach (GammaComboBox comboBox in FindVisualChildren<GammaComboBox>(window))
            {
                comboBox.IsDropDownOpen = false;
            }
            foreach (Popup popup in FindVisualChildren<Popup>(window))
            {
                if (popup.IsOpen == true)
                {
                    popup.IsOpen = false;
                    popup.IsOpen = true;
                }
            }
        }
        public static IEnumerable<T> FindVisualChildren<T>(DependencyObject depObj) where T : DependencyObject
        {
            if (depObj != null)
            {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depObj); i++)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(depObj, i);
                    if (child != null && child is T t)
                    {
                        yield return t;
                    }

                    foreach (T childOfChild in FindVisualChildren<T>(child))
                    {
                        yield return childOfChild;
                    }
                }
            }
        }

        private void MusicPlayer_MediaEnded(object sender, RoutedEventArgs e)
        {
            //SfxPlayer.Pause();
            //SfxPlayer.Position = TimeSpan.FromMilliseconds(1);
        }
        public void PlaySound(string filepath)
        {
            if (!AppData.IsLoaded) { return; }
            if (AppData.SkipAudio) { return; }
            if (AppData.MainModelRef.SettingsView.MuteAudio) { return; }
            SfxPlayer.Position = TimeSpan.FromMilliseconds(1);
            SfxPlayer.Source = new Uri(filepath, UriKind.Absolute);
            SfxPlayer.Volume = AppData.AudioVolume[filepath];
            SfxPlayer.Play();
        }

        private void ScrollViewer_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            if (AppData.ScrollHandled) { AppData.ScrollHandled = false; return; }
            if (e.VerticalChange == 0) { return; }
            if ((sender as ScrollViewer).Tag.ToString() != "CombatantList") { return; }
            ClosePopups(this);
        }

        private void HighlightText(object sender, KeyboardFocusChangedEventArgs e)
        {
            (sender as TextBox).SelectAll();
        }
    
    }
}
