using System;
using System.Collections.Generic;
using System.Configuration;
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
using System.Windows.Shapes;
using Dapper;

namespace Login
{
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString);

        public Window3()
        {
            InitializeComponent();
        }

        private void BTN_Register_Click(object sender, RoutedEventArgs e)
        {
            string myPassword = password.Password;
            string mySalt = BCrypt.Net.BCrypt.GenerateSalt();
            string myHash = BCrypt.Net.BCrypt.HashPassword(myPassword, mySalt);
            var affectedRows = sqlConnection.Execute("INSERT INTO TB_M_Login (username, password) VALUES (@username,@password)",
                new { username = username.Text, password = myHash });
            if (affectedRows < 0)
            {
                MessageBox.Show("Failed To Register");
            }
            else
            {
                MessageBox.Show("Success To Register");
            }
        }
    }
}
