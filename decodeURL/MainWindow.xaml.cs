using System.Diagnostics;
using System.Web;
using System.Windows;

namespace decodeURL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// MCASが有効か
        /// </summary>
        /// <param name="url"></param>
        /// <returns>true: 有効 false: 無効</returns>
        private static bool Rewrite(string url)
        {
            if (url.Contains(".mcas"))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 不要なURIを削除
        /// </summary>
        /// <param name="url"></param>
        /// <returns>URL</returns>
        private static string SubUrl(string url)
        {
            var repUrl = url;
            var tailPos = repUrl.LastIndexOf("?");
            if (tailPos > 0)
            {
                 repUrl = repUrl.Substring(0, tailPos);
            }

            var headPos = repUrl.IndexOf(".mcas");
            var bottomPos = repUrl.LastIndexOf("=/");
            if (bottomPos < 0)
            {
                return repUrl;
            }
            return repUrl.Remove(headPos, bottomPos - headPos + 1);
        }

        /// <summary>
        /// デコード済みか
        /// </summary>
        /// <returns>true: 済み false: 未済</returns>
        private bool UrlDecoded()
        {
            return outputBox.Text != "" ? true : false;
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void DoDecode(object sender, RoutedEventArgs e)
        {
            var decodeUrl = HttpUtility.UrlDecode(inputBox.Text);
            if (Rewrite(decodeUrl))
            {
                outputBox.Text = SubUrl(decodeUrl);
            }
            else
            {
                outputBox.Text = decodeUrl;
            }
        }

        private void DoClear(object sender, RoutedEventArgs e)
        {
            inputBox.Text = "";
            outputBox.Text = "";
            messageBox.Text = "";
        }

        private void DoCopy(object sender, RoutedEventArgs e)
        {
            if (UrlDecoded())
            {
                Clipboard.SetText(outputBox.Text);
                messageBox.Text = "Copied!";
            }
        }

        private void InputSample(object sender, RoutedEventArgs e)
        {
            inputBox.Text = "https://www.bing.com/travel/place-information?q=%E3%82%A2%E3%83%AB%E3%82%B6%E3%82%B9%E5%9C%B0%E5%9F%9F%E5%9C%8F";
        }

        private void DoExit(object sender, RoutedEventArgs e)
        {
            Close();
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
    }
}
