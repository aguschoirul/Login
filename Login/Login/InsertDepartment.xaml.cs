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
    /// Interaction logic for InsertDepartment.xaml
    /// </summary>
    public partial class InsertDepartment : UserControl
    {
        SqlConnection SqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString);

        public InsertDepartment()
        {
            InitializeComponent();
        }

        public void tampil()
        {
            SqlConnection SqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString);

            var check = SqlCon.QueryAsync<Department>("exec SP_Retreive_Departement").Result.ToList();
            Department.ItemsSource = check;
        }

        public void clear()
        {
            name.Text = "";
            manager.Text = "";
        }

        private void SaveDept_Click(object sender, RoutedEventArgs e)
        {
            var check = SqlCon.ExecuteAsync("exec SP_Retrieve_InsertDepartment @name,@manager",
               new { name = name.Text, manager = manager.Text });
            MessageBox.Show("Data has been entered");
            tampil();
            clear();
        }

        private void DataDepartmenet_Loaded(object sender, RoutedEventArgs e)
        {
            SqlConnection SqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString);

            var check = SqlCon.QueryAsync<Department>("exec SP_Retreive_Departement").Result.ToList();

            var grid = sender as DataGrid;
            grid.ItemsSource = check;
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var del = SqlConnection.ExecuteAsync("Exec SP_Delete_Department @id",
                new { id = id.Text });
            MessageBox.Show("Data Deleted");
        }

        private void Department_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            object item = Department.SelectedItem;
            name.Text = (Department.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
            manager.Text = (Department.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
        }
    }
}