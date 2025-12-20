using System.Diagnostics;
using System.Web;
using System.Windows;
using System.Threading.Tasks;

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

        private async void DoCopy(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Decode.UrlDecoded(outputBox.Text))
                {
                    Clipboard.SetText(outputBox.Text);
                    messageBox.Text = "Copied!";

                    // 一定時間待ってからメッセージを消す（ここでは2000ms = 2秒）
                    await Task.Delay(2000);

                    // 他の処理でメッセージが変わっていなければ消す
                    if (messageBox.Text == "Copied!")
                    {
                        messageBox.Text = "";
                    }
                }
            }
            catch (System.Exception ex)
            {
                messageBox.Text = $"Copy failed: {ex.Message}";
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
            inputBox.Text = "https://www.bing.com/search?q=%e3%82%b3%e3%83%ab%e3%83%9e%e3%83%bc%e3%83%ab";
        }
    }
}
