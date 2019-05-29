using Equb_System.Model;
using Equb_System.Utilites;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Equb_System
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// controller for main window
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            if (string.IsNullOrWhiteSpace(passwordTextBlock.Password.ToString()))
            {
                passwordTextBlock.Password = "**********";
            }

            if (string.IsNullOrWhiteSpace(UserNameTextBlock.Text.ToString()))
            {
                UserNameTextBlock.Text = "User Name";
            }
        }

        private void Login(object sender, RoutedEventArgs e)
        {
            using (EqubDbContext context = new EqubDbContext())
            {
                List<Account> users = context.Account.ToList();
                bool userFound = false;

                foreach (Account userData in users)
                {
                    if (userData.username.ToString().Equals(UserNameTextBlock.Text.ToString()) && userData.password.ToString().Equals(passwordTextBlock.Password.ToString()))
                    {
                        userFound = true;
                        MessageBox.Show("Login Successful!!");
                        break;
                    }
                }

                if (userFound.Equals(false))
                {
                    MessageBox.Show("Login Failed!!");
                }
            }
        }
    }
}
