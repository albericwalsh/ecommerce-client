using e_commerce_client.functions;
using System.Windows;
using System.Windows.Controls;

namespace e_commerce_client.windows;

public partial class LoginWindow : Window
{
    public LoginWindow()
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

    private void login_clic(object sender, RoutedEventArgs e)
    {
        if (log_func.Login_func(user, password))
        {
            this.Close();
        }
    }
}