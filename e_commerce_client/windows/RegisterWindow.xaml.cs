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

namespace e_commerce_client.windows
{
    /// <summary>
    /// Logique d'interaction pour RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void User_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            user = ((TextBox)sender).Text;
        }

        private void Password_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            password = ((TextBox)sender).Text;
        }

        public string user { get; set; }
        public string password { get; set; }

        private void register_clic(object sender, RoutedEventArgs e)
        {
            if (user != null && password != null)
            {
                if (functions.log_func.Register_func(user, password))
                {
                    MainWindow main = new MainWindow();
                    main.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Fill all lines");
            }
        }
    }
}
