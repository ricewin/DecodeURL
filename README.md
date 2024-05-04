# DecodeURL

## URL エンコードされたリンクを日本語にデコードします

- WPF アプリ

### 実行環境

- .NET 8.0 による実装なので、Runtime または SDK が必要
- https://dotnet.microsoft.com/download

### 主な機能

1. SharePoint Online (SPO) のアドレスを、Power Automate for desktop (PAD) の SharePoint アクションで使用するためのアドレスに変換します。
2. SPO 以外のサイトは、デコードのみ行います。

### 使用方法

1. ブラウザーから SPO のフォルダーを開き、ブラウザーの URL 欄からテキストをまるごとコピーして貼り付けます。

### サンプル

- 以下のようなリンクから不要なパラメーターを削除

```text: example
https://hogehoge.sharepoint.com.mcas.ms/sites/example/Shared%20Documents/Forms/AllItems.aspx?id=%2Fsites%2Fexample%2FShared%20Documents%2F%...&viewid=0000f000%000000%000000%000000%00000000000000
https://hogehoge.sharepoint.com/sites/example/Shared%20Documents/Forms/AllItems.aspx?RootFolder=%2Fsites%2Fexample%2FShared%20Documents%2F...&FolderCTID=0000000000000000000000000000000000000000
```

- `https://hogehoge.sharepoint.com/sites/example/Shared%20Documents/Forms/AllItems.aspx?id=%2Fsites%2Fexample%2FShared%20Documents%2F%E3%81%93%E3%81%AE%E3%83%95%E3%82%A9%E3%83%AB%E3%83%80%E3%83%BC%E5%90%8D%E3%81%AF%E3%83%80%E3%83%9F%E3%83%BC%E3%81%A7%E3%81%99&FolderCTID=0000000000000000000000000000000000000000`
- `https://hogehoge.sharepoint.com/sites/example/Shared%20Documents/Forms/AllItems.aspx?ga=1&id=%2Fsites%2Fexample%2FShared%20Documents%2F%E3%81%93%E3%81%AE%E3%83%95%E3%82%A9%E3%83%AB%E3%83%80%E3%83%BC%E5%90%8D%E3%81%AF%E3%83%80%E3%83%9F%E3%83%BC%E3%81%A7%E3%81%99&viewid=0000f000%000000%000000%000000%00000000000000`
- `https://hogehoge.sharepoint.com/sites/example/Shared%20Documents/Forms/AllItems.aspx?RootFolder=%2Fsites%2Fexample%2FShared%20Documents%2F%E3%81%93%E3%81%AE%E3%83%95%E3%82%A9%E3%83%AB%E3%83%80%E3%83%BC%E5%90%8D%E3%81%AF%E3%83%80%E3%83%9F%E3%83%BC%E3%81%A7%E3%81%99&FolderCTID=0000000000000000000000000000000000000000`
- `https://hogehoge.sharepoint.com.mcas.ms/sites/example/Shared%20Documents/Forms/AllItems.aspx?csf=1&web=1&e=000000&cid=00000000%2D0000%2D0000%2D0000%2D000000000000&RootFolder=%2Fsites%2Fexample%2FShared%20Documents%2F%E3%81%93%E3%81%AE%E3%83%95%E3%82%A9%E3%83%AB%E3%83%80%E3%83%BC%E5%90%8D%E3%81%AF%E3%83%80%E3%83%9F%E3%83%BC%E3%81%A7%E3%81%99&viewid=0000f000%000000%000000%000000%00000000000000`

↓

### 出力結果

- `https://hogehoge.sharepoint.com/sites/example/Shared Documents/このフォルダー名はダミーです`

---

## 更新履歴

### 0.1.0

- First beta release
