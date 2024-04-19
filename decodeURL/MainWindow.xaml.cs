using System.Text;
using System.Web;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace decodeURL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void doConvert(object sender, RoutedEventArgs e)
        {
            textBlock.Text = HttpUtility.UrlDecode(textBox.Text);
        }

        private void doClear(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            textBlock.Text = "";
            messageBox.Text = "";
        }

        private void doCopy(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(textBox.Text);
            messageBox.Text = "コピーしました！";
        }

        private void inputSample(object sender, RoutedEventArgs e)
        {
            textBox.Text = "https://www.bing.com/travel/place-information?q=%E3%82%A2%E3%83%AB%E3%82%B6%E3%82%B9%E5%9C%B0%E5%9F%9F%E5%9C%8F";
        }

        private void doExit(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}