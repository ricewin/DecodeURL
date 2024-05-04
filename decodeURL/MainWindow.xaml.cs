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
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// SharePointか
        /// </summary>
        /// <param name="url"></param>
        /// <returns>true: 有効, false: 無効</returns>
        private static bool Rewrite(string url) => url.Contains(".sharepoint.");

        /// <summary>
        /// 不要なURIを削除
        /// </summary>
        /// <param name="url"></param>
        /// <returns>URL</returns>
        private static string SubUrl(string url)
        {
            var repUrl = url.Replace(".mcas.ms", "");
            var tailPos = repUrl.LastIndexOf('&');
            if (tailPos > 0)
                repUrl = repUrl[..tailPos];

            var topPos = repUrl.IndexOf("/sites/");
            var bottomPos = repUrl.LastIndexOf("/sites/");
            return topPos == bottomPos ? repUrl : repUrl.Remove(topPos, bottomPos - topPos);
        }

        /// <summary>
        /// デコード済みか
        /// </summary>
        /// <returns>true: 済み, false: 未済</returns>
        private bool UrlDecoded() => outputBox.Text != "";

        private void DoDecode(object sender, RoutedEventArgs e)
        {
            var decodeUrl = HttpUtility.UrlDecode(inputBox.Text);
            outputBox.Text = Rewrite(decodeUrl) ? SubUrl(decodeUrl) : decodeUrl;
        }

        private void OpenBrowser(object sender, RoutedEventArgs e)
        {
            if (UrlDecoded())
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
            if (UrlDecoded())
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
