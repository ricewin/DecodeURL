using System.Diagnostics;
using System.Web;
using System.Windows;

namespace DecodeURL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();

        private void DoDecode(object sender, RoutedEventArgs e)
        {
            var decodeUrl = HttpUtility.UrlDecode(inputBox.Text);
            var isCut = tailCut.IsChecked == true;

            outputBox.Text = Decode.Rewrite(decodeUrl)
                ? Decode.SubUrl(decodeUrl, isCut)
                : decodeUrl;
        }

        private void OpenBrowser(object sender, RoutedEventArgs e)
        {
            if (Decode.UrlDecoded(outputBox.Text))
            {
                _ = Process.Start(new ProcessStartInfo
                {
                    FileName = outputBox.Text,
                    UseShellExecute = true
                });
            }
        }

        private void DoCopy(object sender, RoutedEventArgs e)
        {
            if (Decode.UrlDecoded(outputBox.Text))
            {
                Clipboard.SetText(outputBox.Text);
                messageBox.Text = "Copied!";
            }
        }

        private void DoClear(object sender, RoutedEventArgs e)
        {
            inputBox.Text = "";
            outputBox.Text = "";
            messageBox.Text = "";
        }

        private void DoExit(object sender, RoutedEventArgs e) => Close();

        private void InputSample(object sender, RoutedEventArgs e)
        {
            inputBox.Text = "https://www.bing.com/travel/place-information?q=%E3%82%A2%E3%83%AB%E3%82%B6%E3%82%B9%E5%9C%B0%E5%9F%9F%E5%9C%8F";
        }
    }
}
