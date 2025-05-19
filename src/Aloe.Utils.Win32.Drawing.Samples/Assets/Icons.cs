using Aloe.Utils.Win32.Drawing;
using System.Drawing;
using System.IO;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Aloe.Medock.Reservation.AloeMedockResvServerMonitor.Assets;

public static class Icons
{
    public static Lazy<Icon> Aloe = new(() => Images.Aloe.Value.ToIcon());

    public static ImageSource ToImageSource(this Icon icon)
    {
        using var ms = new MemoryStream();
        icon.Save(ms);
        ms.Seek(0, SeekOrigin.Begin);

        var decoder = new IconBitmapDecoder(ms, BitmapCreateOptions.None, BitmapCacheOption.OnLoad);
        return decoder.Frames[0];
    }
}
