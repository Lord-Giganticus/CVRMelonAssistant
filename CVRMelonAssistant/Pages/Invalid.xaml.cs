using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace CVRMelonAssistant.Pages
{
    /// <summary>
    /// Interaction logic for Invalid.xaml
    /// </summary>
    public partial class Invalid : Page
    {
        public static Invalid Instance = new();
        public string InstallDirectory { get; set; }

        public Invalid()
        {
            InitializeComponent();
            InstallDirectory = App.ChilloutInstallDirectory;
            DirectoryTextBlock.Text = InstallDirectory;
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

        private void SelectDirButton_Click(object sender, RoutedEventArgs e)
        {
            InstallDirectory = Utils.GetManualDir();
            DirectoryTextBlock.Text = InstallDirectory;
        }
    }
}
