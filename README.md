# DecodeURL

## URL �G���R�[�h���ꂽ�����N����{��Ƀf�R�[�h���܂�

- WPF �A�v��

### ���s��

- .NET 8.0 �ɂ������Ȃ̂ŁARuntime �܂��� SDK ���K�v
- https://dotnet.microsoft.com/download

### ��ȋ@�\

1. SharePoint Online (SPO) �̃A�h���X���APower Automate for Desktop (PAD) �� SharePoint �A�N�V�����Ŏg�p���邽�߂̃A�h���X�ɕϊ����܂��B
2. SPO �ȊO�̃T�C�g�́A�f�R�[�h�̂ݍs���܂��B

### �g�p���@

1. �u���E�U�[���� SPO �̃t�H���_�[���J���A�u���E�U�[�� URL ������e�L�X�g���܂邲�ƃR�s�[���ē\��t���܂��B

### �T���v��

- �ȉ��̂悤�ȃ����N����s�v�ȃp�����[�^�[���폜

```text: example
https://hogehoge.sharepoint.com.mcas.ms/sites/example/Shared%20Documents/Forms/AllItems.aspx?id=%2Fsites%2Fexample%2FShared%20Documents%2F%...&viewid=0000f000%000000%000000%000000%00000000000000
https://hogehoge.sharepoint.com/sites/example/Shared%20Documents/Forms/AllItems.aspx?RootFolder=%2Fsites%2Fexample%2FShared%20Documents%2F...&FolderCTID=0000000000000000000000000000000000000000
```

- `https://hogehoge.sharepoint.com/sites/example/Shared%20Documents/Forms/AllItems.aspx?id=%2Fsites%2Fexample%2FShared%20Documents%2F%E3%81%93%E3%81%AE%E3%83%95%E3%82%A9%E3%83%AB%E3%83%80%E3%83%BC%E5%90%8D%E3%81%AF%E3%83%80%E3%83%9F%E3%83%BC%E3%81%A7%E3%81%99&FolderCTID=0000000000000000000000000000000000000000`

- `https://hogehoge.sharepoint.com/sites/example/Shared%20Documents/Forms/AllItems.aspx?ga=1&id=%2Fsites%2Fexample%2FShared%20Documents%2F%E3%81%93%E3%81%AE%E3%83%95%E3%82%A9%E3%83%AB%E3%83%80%E3%83%BC%E5%90%8D%E3%81%AF%E3%83%80%E3%83%9F%E3%83%BC%E3%81%A7%E3%81%99&viewid=0000f000%000000%000000%000000%00000000000000`

- `https://hogehoge.sharepoint.com/sites/example/Shared%20Documents/Forms/AllItems.aspx?RootFolder=%2Fsites%2Fexample%2FShared%20Documents%2F%E3%81%93%E3%81%AE%E3%83%95%E3%82%A9%E3%83%AB%E3%83%80%E3%83%BC%E5%90%8D%E3%81%AF%E3%83%80%E3%83%9F%E3%83%BC%E3%81%A7%E3%81%99&FolderCTID=0000000000000000000000000000000000000000`

- `https://hogehoge.sharepoint.com.mcas.ms/sites/example/Shared%20Documents/Forms/AllItems.aspx?csf=1&web=1&e=000000&cid=00000000%2D0000%2D0000%2D0000%2D000000000000&RootFolder=%2Fsites%2Fexample%2FShared%20Documents%2F%E3%81%93%E3%81%AE%E3%83%95%E3%82%A9%E3%83%AB%E3%83%80%E3%83%BC%E5%90%8D%E3%81%AF%E3%83%80%E3%83%9F%E3%83%BC%E3%81%A7%E3%81%99&viewid=0000f000%000000%000000%000000%00000000000000`

��

### �o�͌���

- `https://hogehoge.sharepoint.com/sites/example/Shared Documents/���̃t�H���_�[���̓_�~�[�ł�`


## �X�V����

## 0.1.0

- First beta release
