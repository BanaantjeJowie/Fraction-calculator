using System;
using System.Windows;
using System.Diagnostics;
using FractionLibrary;
using System.Windows.Navigation;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Media.Imaging;
using System.Windows.Input;
using System.Windows.Documents;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Media.Media3D;
using System.Windows.Media.Effects;


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
            OpenLink("https://www.linkedin.com/in/joë-boone-1b99402a9/");
        }

        private void VIVESButton_Click(object sender, RoutedEventArgs e)
        {
            // Open the VIVES page for the project
            OpenLink("https://www.vives.be/");
        }

        private void READMEButton_Click(object sender, RoutedEventArgs e)
        {
            // Open the README page for the project
            OpenLink("https://github.com/BanaantjeJowie/Fraction-calculator/blob/master/README.md");
        }

    }
}
