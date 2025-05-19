using Aloe.Medock.Reservation.AloeMedockResvServerMonitor.Assets;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Aloe.Utils.Win32.Drawing.Samples;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        this.InitializeComponent();
    }

    private void MainWindow_SourceInitialized(object? sender, EventArgs e)
    {
        this.Icon = Icons.Aloe.Value.ToImageSource();
    }
}
