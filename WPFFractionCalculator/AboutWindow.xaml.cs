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

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            static void OpenLink(string url)
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };

                Process.Start(psi);
            }
            OpenLink(e.Uri.AbsoluteUri);
        }


        private void GitHubButton_Click(object sender, RoutedEventArgs e)
        {
            // Open the GitHub page for the project
            string githubUrl = "https://github.com/BanaantjeJowie/Fraction-calculator";
            Process.Start(githubUrl);
        }


        private void LinkedIn_Click(object sender, RoutedEventArgs e)
        {

            // Open the LinkedIn page for the project
            Process.Start("");
        }

        private void VIVESButton_Click(object sender, RoutedEventArgs e)
        {
            // Open the VIVES page for the project
            Process.Start("");
        }

        private void READMEButton_Click(object sender, RoutedEventArgs e)
        {
            // Open the README page for the project
            Process.Start("");
        }

    }
}
