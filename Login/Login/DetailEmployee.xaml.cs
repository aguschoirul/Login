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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Dapper;

namespace Login
{
    /// <summary>
    /// Interaction logic for DetailEmployee.xaml
    /// </summary>
    public partial class DetailEmployee : UserControl
    {
        SqlConnection SqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString);

        public DetailEmployee()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void DataEmployee_Loaded(object sender, RoutedEventArgs e)
        {
            SqlConnection SqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString);

            var check = SqlCon.QueryAsync<DetailEmploye>("exec SP_Retrieve_DataEmploye").Result.ToList();

            var grid = sender as DataGrid;
            grid.ItemsSource = check;
        }
    }
}
