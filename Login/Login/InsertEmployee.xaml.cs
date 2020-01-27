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
    /// Interaction logic for InsertEmployee.xaml
    /// </summary>
    public partial class InsertEmployee : UserControl
    {
        SqlConnection SqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString);

        public InsertEmployee()
        {
            InitializeComponent();
        }

        public void clear()
        {
            name.Text = "";
            phone.Text = "";
            email.Text = "";
            address.Text = "";
            placebirth.Text = "";
            birthdate.Text = "";
            nik.Text = "";
            religion.Text = "";
            npwp.Text = "";
            bachelor.Text = "";
            university.Text = "";
            joindate.Text = "";
        }

        private void BTN_Save_Click(object sender, RoutedEventArgs e)
        {
            {
                var check = SqlCon.ExecuteAsync("exec SP_Retrieve_Employee @name,@phone,@email,@address,@placebirth,@birthdate,@nik,@religion,@npwp,@bachelor,@university,@joindate",
                  new { name = name.Text, phone = phone.Text, email = email.Text, address = address.Text, placebirth = placebirth.Text, birthdate = birthdate.SelectedDate, nik = nik.Text, religion = religion.Text, npwp = npwp.Text, bachelor = bachelor.Text, university = university.Text, joindate = joindate.SelectedDate });
                MessageBox.Show("Data has been entered");
                clear();
            }
        }
    }
}
