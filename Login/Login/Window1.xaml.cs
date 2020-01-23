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
using Dapper;
using System.Windows.Shapes;

namespace Login
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        SqlConnection SqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString);

        public Window1()
        {
            InitializeComponent();
        }

        private void BTN_Save_Click(object sender, RoutedEventArgs e)
        {
            var check = SqlCon.QueryAsync<Insert>("exec SP_Retrieve_Employee @id,@name,@phone,@email,@address",
              new { id = id.Text , name = name.Text, phone = phone.Text, email = email.Text, address = address.Text }).Result.SingleOrDefault();
            MessageBox.Show("Data has been entered");
        }

        private void BTN_Update_Click(object sender, RoutedEventArgs e)
        {
            var check = SqlCon.QueryAsync<Insert>("exec SP_Retrieve_Update @id,@name,@phone,@email,@address",
              new { id = id.Text, name = name.Text, phone = phone.Text, email = email.Text, address = address.Text }).Result.SingleOrDefault();
            MessageBox.Show("Data has been Changed");
        }
    }
}
