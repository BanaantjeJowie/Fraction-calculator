using System;
using System.Windows;
using System.Diagnostics;
using FractionLibrary;
using System.Windows.Navigation;
namespace WPFFractionCalculator
{
    /// <summary>
    /// Interaction logic for AboutWindow.xaml
    /// </summary>
    public partial class AboutWindow : Window
    {
        public AboutWindow()
        {
            InitializeComponent();

        }

        private void CLoseButton_CLick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        static void OpenLink(string url)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };

            Process.Start(psi);
        }


        private void GitHubButton_Click(object sender, RoutedEventArgs e)
        {
            // Open the GitHub page for the project
            
            OpenLink("https://github.com/BanaantjeJowie/Fraction-calculator");

        }


        private void LinkedIn_Click(object sender, RoutedEventArgs e)
        {

            // Open the LinkedIn page for the project
            OpenLink("https://www.linkedin.com/in/jowie-van-put-7b1b3b1b4/");
        }

        private void VIVESButton_Click(object sender, RoutedEventArgs e)
        {
            // Open the VIVES page for the project
            OpenLink("https://www.vives.be/");
        }

        private void READMEButton_Click(object sender, RoutedEventArgs e)
        {
            // Open the README page for the project
            Process.St");
        }

    }
}
