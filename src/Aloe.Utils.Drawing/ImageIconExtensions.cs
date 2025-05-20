// <copyright file="ImageIconExtensions.cs" company="ted-sharp">
// Copyright (c) ted-sharp. All rights reserved.
// </copyright>

using System.Drawing;
using System.Runtime.Versioning;

namespace Aloe.Utils.Drawing;

/// <summary>
/// Image から Icon への変換拡張メソッドを提供します。
/// </summary>
[SupportedOSPlatform("windows")]
public static class ImageIconExtensions
{
    /// <summary>
    /// 既存の Image 型（実体が Bitmap として扱えるもの）から単一サイズの Icon を生成します。
    /// </summary>
    /// <param name="image">変換元の Image オブジェクト</param>
    /// <returns>変換後の Icon オブジェクト</returns>
    public static Icon ToIcon(this Image image)
    {
        var bmp = image as Bitmap ?? new Bitmap(image);
        var hIcon = bmp.GetHicon();
        var tempIcon = Icon.FromHandle(hIcon);
        var newIcon = (Icon)tempIcon.Clone();
        _ = NativeMethods.DestroyIcon(hIcon);
        return newIcon;
    }
}
