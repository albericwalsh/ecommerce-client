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

namespace e_commerce_client;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    
    private void Login_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("login");
    }
    
    private void Register_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("register");
    }
    
    public double WindowWidth { get; set; } = SystemParameters.PrimaryScreenWidth;
}