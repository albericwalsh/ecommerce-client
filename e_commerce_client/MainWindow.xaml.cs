using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace e_commerce_client
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void login_click(object sender, RoutedEventArgs e)
        {
            windows.LoginWindow login = new windows.LoginWindow();
            login.Show();
            this.Close();
        }

        public void register_click(object sender, RoutedEventArgs e)
        {
            windows.RegisterWindow register = new windows.RegisterWindow();
            register.Show();
            this.Close();
        }
    }
}
