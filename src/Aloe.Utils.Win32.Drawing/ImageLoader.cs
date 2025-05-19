// <copyright file="ImageLoader.cs" company="ted-sharp">
// Copyright (c) ted-sharp. All rights reserved.
// </copyright>

using System.Drawing;
using System.Runtime.Versioning;

namespace Aloe.Utils.Win32.Drawing;

/// <summary>
/// GDI+を利用して画像ファイルを読み込むためのクラス
/// </summary>
[SupportedOSPlatform("windows")]
public static class ImageLoader
{
    /// <summary>
    /// ファイルシステム上の画像ファイルからファイルロックしない形で Image を生成します。
    /// PNG, JPEG, BMP, GIF, TIFF等に対応しています。
    /// </summary>
    /// <param name="filePath">画像ファイルのパス</param>
    /// <returns>生成された Image</returns>
    public static Image Load(string filePath)
    {
        var imageData = File.ReadAllBytes(filePath);
        using var ms = new MemoryStream(imageData);
        return Image.FromStream(ms);
    }
}
