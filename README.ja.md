# Aloe.Utils.Win32.Drawing

[![NuGet Version](https://img.shields.io/nuget/v/Aloe.Utils.Win32.Drawing.svg)](https://www.nuget.org/packages/Aloe.Utils.Win32.Drawing)
[![NuGet Downloads](https://img.shields.io/nuget/dt/Aloe.Utils.Win32.Drawing.svg)](https://www.nuget.org/packages/Aloe.Utils.Win32.Drawing)
[![License](https://img.shields.io/github/license/ted-sharp/aloe-utils-win32-drawing.svg)](LICENSE)
[![.NET](https://img.shields.io/badge/.NET-9.0-blue.svg)](https://dotnet.microsoft.com/download/dotnet/9.0)

`Aloe.Utils.Win32.Drawing` は、Windowsの描画関連のWin32 APIを.NETアプリケーションから直接呼び出すためのライブラリです。
グラフィックス処理や描画操作をプログラムから行う必要がある場合に使用できます。

## 主な機能

* Windowsの描画APIの直接呼び出し
* グラフィックス処理のサポート

## 対応環境

* .NET 9 以降
* Windows OS

## インストール

NuGet パッケージマネージャーからインストール：

```cmd
Install-Package Aloe.Utils.Win32.Drawing
```

または、.NET CLI で：

```cmd
dotnet add package Aloe.Utils.Win32.Drawing
```

## 使用例

```csharp
using System.Drawing;
using Aloe.Utils.Win32.Drawing;

// 画像ファイルの読み込み(メモリに読み込むのでファイルロックなし)
var image = ImageLoader.Load("path/to/image.png");

// 画像からアイコンへの変換
var icon = image.ToIcon();

// アイコンの使用例
using var drawing = new Win32Drawing();

// ウィンドウの作成
var hwnd = drawing.CreateWindow(
    className: "MyWindowClass",
    windowName: "アイコン表示テスト",
    width: 400,
    height: 300);

// 描画コンテキストの取得
using var dc = drawing.GetDC(hwnd);

// アイコンの描画
drawing.DrawIcon(dc, 100, 100, icon.Handle);

// 描画の更新
drawing.UpdateWindow(hwnd);

// リソースの解放
icon.Dispose();
image.Dispose();
```

## ライセンス

MIT License

## 貢献

バグ報告や機能リクエストはGitHub Issuesを通じてお願いします。プルリクエストも歓迎します。 