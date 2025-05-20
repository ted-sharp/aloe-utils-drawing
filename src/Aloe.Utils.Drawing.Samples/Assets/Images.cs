using System.Drawing;
using System.IO;
using Aloe.Utils.Drawing;

namespace Aloe.Medock.Reservation.AloeMedockResvServerMonitor.Assets;

public static class Images
{
    public static Lazy<Image> Aloe = new(() => Images.Get("Aloe"));

    public static readonly Dictionary<string, Lazy<Image>> ByName = new()
    {
        ["Aloe"] = new(() => ImageLoader.Load(
            Path.Combine(AppContext.BaseDirectory, @"Assets\Aloe.png")
        )),
    };

    public static Image Get(string key) => Images.ByName[key].Value;
}
