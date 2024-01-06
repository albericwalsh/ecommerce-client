using System.Windows;
using e_commerce_client.windows;

namespace e_commerce_client.functions;

public class log_func
{

    //make a hashmap for stock the user's data
    public static Dictionary<string, string> user_data = new();

    public static bool Login_func(string user, string password)
    {
        user_data = json.json_load();
        if (user_data != null)
        {
            if (user_data.ContainsKey(user))
            {
                if (user_data[user] == hash.Hash_func(password))
                {
                    var window = new MasterWindow();
                    window.Show();
                    return true;
                }
                else
                {
                    MessageBox.Show("Username or Password Wrong");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Username or Password Wrong");
                return false;
            }
        }
        else
        {
            MessageBox.Show("Username or Password Wrong");
            return false;
        }
    }

    public static bool Register_func(string user, string password)
    {
        if (user_data.ContainsKey(user))
        {
            MessageBox.Show("Username already exist");
            return false;
        }
        else
        {
            user_data.Add(user, hash.Hash_func(password));
            MessageBox.Show("Account created");
            json.json_save(user_data);
            return true;
        }
    }
}