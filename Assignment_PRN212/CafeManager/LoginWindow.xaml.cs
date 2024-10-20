using CafeManager.BLL.Services;
using CafeManager.DAL.Models;
using Microsoft.IdentityModel.Tokens;
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

namespace CafeManager
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private AccountService _accountService = new();
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // check ng dung khong nhap j
            if (txtEmail.Text.IsNullOrEmpty() || txtPassword.Password.IsNullOrEmpty())
            {
                MessageBox.Show("Email and Password can not empty", "Wrong credentials", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;

            }
            // Login thanh cong moi goi man hinh home
            Account? account = _accountService.Authenticate(txtEmail.Text, txtPassword.Password);
            // account co the null
            if (account == null)
            {
                MessageBox.Show("Invalid Email or wrong Password", "Wrong credentials", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            HomeWindow homeWindow = new HomeWindow();
            homeWindow.Show();
            this.Hide();

        }
    }
}
