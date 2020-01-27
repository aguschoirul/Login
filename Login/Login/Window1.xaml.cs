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
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DetailEmployee Detail = new DetailEmployee();
            SPContent.Children.Clear();
            SPContent.Children.Add(Detail);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            InsertEmployee HalamanInsert = new InsertEmployee();
            SPContent.Children.Clear();
            SPContent.Children.Add(HalamanInsert);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            InsertDepartment InsertDepartment = new InsertDepartment();
            SPContent.Children.Clear();
            SPContent.Children.Add(InsertDepartment);
        }
    }
}
