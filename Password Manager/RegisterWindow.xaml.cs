using System;
using System.Collections.Generic;
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
using System.Data;
using System.Data.SqlClient;

namespace Password_Manager
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void Register_Btn_Click(object sender, RoutedEventArgs e)
        {
            //check if info is used
            //check if input is correct
            //save the new account to database
            string email = RegEmail.Text;
            string username = RegUsername.Text;
            string password = RegPassword.Password;


            this.Close();
        }
    }
}
