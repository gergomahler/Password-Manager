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

namespace Password_Manager
{
    /// <summary>
    /// Interaction logic for AddNewAccount.xaml
    /// </summary>
    public partial class AddNewAccount : Window
    {
        public AddNewAccount()
        {
            InitializeComponent();
        }

        private void Close_Btn(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Generate_Btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Add_Btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ShowPassword_Checked(object sender, RoutedEventArgs e)
        {
            PasswordTextBox.Text = PasswordBox.Password;
            PasswordBox.Visibility = Visibility.Collapsed;
            PasswordTextBox.Visibility = Visibility.Visible;

            PasswordTextBox.Focus();
        }

        private void ShowPassword_Unchecked(object sender, RoutedEventArgs e)
        {
            PasswordBox.Password = PasswordTextBox.Text;
            PasswordTextBox.Visibility = Visibility.Collapsed;
            PasswordBox.Visibility = Visibility.Visible;

            PasswordBox.Focus();

        }
    }
}
