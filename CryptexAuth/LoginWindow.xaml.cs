using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using CryptexAuth.Models;

namespace CryptexAuth
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        User user;
        // initialise static objects

        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            // login
            user = login(txtUsername.Text,txtPassword.Password);
        }


        private User login( string username, string password)
        {
            User _user = new User();
            // Connect to Data Provider

            // do password verification

            // save data to user object

            // retrieve api key data and save to user object
            getApiKeys(ref _user);

            // retrieve products and save to user exchanges
            getProducts(ref _user);

            return _user;
        }

        private void getApiKeys(ref User user)
        {
            // Connect to Data provider and grab the api Keys from User exchanges object
            user.Exchanges.Add(new UserExchange());
        }

        private void getProducts(ref User user)
        {
            // Connect to Data provider and grab the products associated with userexchanges
            user.Exchanges.Add(new UserExchange());
        }
    }
}
