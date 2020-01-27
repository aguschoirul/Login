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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        SqlConnection SqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString);

        public Window2()
        {
            InitializeComponent();
        }

        private void Employee_Loaded(object sender, RoutedEventArgs e)
        {
            var check = SqlCon.QueryAsync<Insert>("exec SP_Retrieve_DataEmployee").Result.ToList();
            var grid = sender as DataGrid;
            grid.ItemsSource = check;
        }
    }
}
