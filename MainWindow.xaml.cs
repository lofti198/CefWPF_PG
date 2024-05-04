using CefSharp;
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

namespace CefWPF_PG;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        browser.LoadUrlAsync("https://www.youtube.com/results?search_query=llm");
    }

    protected override void OnClosed(EventArgs e)
    {
        // Clean up CefSharp resources explicitly
        Cef.Shutdown();
        base.OnClosed(e);
    }
}