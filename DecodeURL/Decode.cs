namespace DecodeURL
{
    internal class Decode
    {
        /// <summary>
        /// SharePointか
        /// </summary>
        /// <param name="url"></param>
        /// <returns>true: 有効, false: 無効</returns>
        internal static bool Rewrite(string url) => url.Contains(".sharepoint.");

        /// <summary>
        /// 不要なURIを削除
        /// </summary>
        /// <param name="url"></param>
        /// <returns>URL</returns>
        internal static string SubUrl(string url, bool isCut)
        {
            var repUrl = url.Replace(".mcas.ms", "");
            var tailPos = isCut ? repUrl.LastIndexOf('&') : 0;
            repUrl = tailPos > 0 ? repUrl[..tailPos] : repUrl;

            var topPos = repUrl.IndexOf("/sites/");
            var bottomPos = repUrl.LastIndexOf("/sites/");
            return topPos == bottomPos ? repUrl : repUrl.Remove(topPos, bottomPos - topPos);
        }

        /// <summary>
        /// デコード済みか
        /// </summary>
        /// <returns>true: 済み, false: 未済</returns>
        internal static bool UrlDecoded(string output) => output != "";
    }
}
