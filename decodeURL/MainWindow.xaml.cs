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
        /// MCASが有効か確認
        /// </summary>
        /// <param name="url"></param>
        /// <returns>true: 有効 false: 無効</returns>
        private bool Rewrite(string url)
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
        private string SubUrl(string url)
        {
            var _repUrl = url;
            var _tailPos = _repUrl.LastIndexOf("?");
            if (_tailPos > 0)
            {
                 _repUrl = _repUrl.Substring(0, _tailPos);
            }

            var _headPos = _repUrl.IndexOf(".mcas");
            var _bottomPos = _repUrl.LastIndexOf("=/");
            if (_bottomPos < 0)
            {
                return _repUrl;
            }
            
            return _repUrl.Remove(_headPos, _bottomPos - _headPos + 1);
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void doConvert(object sender, RoutedEventArgs e)
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

        private void doClear(object sender, RoutedEventArgs e)
        {
            inputBox.Text = "";
            outputBox.Text = "";
            messageBox.Text = "";
        }

        private void doCopy(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(outputBox.Text);
            messageBox.Text = "コピーしました！";
        }

        private void inputSample(object sender, RoutedEventArgs e)
        {
            inputBox.Text = "https://www.bing.com/travel/place-information?q=%E3%82%A2%E3%83%AB%E3%82%B6%E3%82%B9%E5%9C%B0%E5%9F%9F%E5%9C%8F";
        }

        private void doExit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void openBrowser(object sender, RoutedEventArgs e)
        {
            if (outputBox.Text != "")
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = outputBox.Text,
                    UseShellExecute = true
                });
            }
        }
    }
}