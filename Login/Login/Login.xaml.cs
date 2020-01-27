using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Dapper;
using System.Configuration;
using BCrypt.Net;

namespace Login
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BTN_Login_Click(object sender, RoutedEventArgs e)
        {
            string myPassword = password.Password;
            var getPassword = sqlConnection.Query<Class1>("SELECT * FROM TB_M_Login WHERE username = @username",
              new {username = username.Text}).SingleOrDefault();
            var result = BCrypt.Net.BCrypt.Verify(myPassword, getPassword.password);
            if (result)
            {
              this.Hide();
              new Window1().Show();
                 MessageBox.Show(this, "Welcome to The Jungle", "Message");
            }
            else
                MessageBox.Show(this, "Username Atau Password Salah", "Message");
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            new Window3().Show();
        }
    }
}