using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace licenseapp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> licenses = new List<string>() { "ajax402" };
        private string url = "https://khashayaar.ir/download/assets/images/Video_2023_07_30-2.webm";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void focus(object sender, RoutedEventArgs e)
        {
            textbox.Text = "";
        }

        private void click1(object sender, RoutedEventArgs e)
        {
            foreach (var license in licenses)
            {
                if (license == textbox.Text)
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("cmd", $"/c start {url}"));
                    return;
                }
                else
                {
                    MessageBox.Show("لایسنس اشتباه است", "خطا", MessageBoxButton.OK, MessageBoxImage.Error);
                    textbox.Text = "";

                }
            }
        }

        private void click2(object sender, RoutedEventArgs e)
        {
            foreach (var license in licenses)
            {
                if (license == textbox.Text)
                {
                    MessageBox.Show("لایسنس درست است", "موفقیت", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("لایسنس اشتباه است", "خطا", MessageBoxButton.OK, MessageBoxImage.Error);
                    textbox.Text = "";

                }
            }
        }
    }
}