# decodeURL

## URL エンコードされたリンクを日本語にデコードします

### 主な機能

1. SharePoint Online (SPO) のアドレスを、Power Automate for Desktop (PAD) の SharePoint アクションで使用するためのアドレスに変換します。
2. SPO 以外のサイトは、デコードのみ行います。

### 使用方法

1. ブラウザーから SPO のフォルダーを開き、ブラウザーの URL 欄からテキストをまるごとコピーして貼り付けます。

### サンプル

- `https://hogehoge.sharepoint.com/sites/example/Shared%20Documents/Forms/AllItems.aspx?RootFolder=%2Fsites%2Fexample%2FShared%20Documents%2F%E3%81%93%E3%81%AE%E3%83%95%E3%82%A9%E3%83%AB%E3%83%80%E3%83%BC%E5%90%8D%E3%81%AF%E3%83%80%E3%83%9F%E3%83%BC%E3%81%A7%E3%81%99&FolderCTID=0000000000000000000000000000000000000000`

- `https://hogehoge.sharepoint.com.mcas.ms/sites/example/Shared%20Documents/Forms/AllItems.aspx?RootFolder=%2Fsites%2Fexample%2FShared%20Documents%2F%E3%81%93%E3%81%AE%E3%83%95%E3%82%A9%E3%83%AB%E3%83%80%E3%83%BC%E5%90%8D%E3%81%AF%E3%83%80%E3%83%9F%E3%83%BC%E3%81%A7%E3%81%99&FolderCTID=0000000000000000000000000000000000000000`

- `https://hogehoge.sharepoint.com.mcas.ms/sites/example/Shared%20Documents/Forms/AllItems.aspx?id=%2Fsites%2Fexample%2FShared%20Documents%2F%E3%81%93%E3%81%AE%E3%83%95%E3%82%A9%E3%83%AB%E3%83%80%E3%83%BC%E5%90%8D%E3%81%AF%E3%83%80%E3%83%9F%E3%83%BC%E3%81%A7%E3%81%99&viewid=0000f000%000000%000000%000000%00000000000000`

　↓

- `https://hogehoge.sharepoint.com/sites/example/Shared Documents/このフォルダー名はダミーです`
