﻿using System;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void signupBTN_Click2(object sender, RoutedEventArgs e)
        {
            user U = new user();
            U.Show();
            this.Close();
        }

        private void signinBTN_Click1(object sender, RoutedEventArgs e)
        {
            if (User_NameBOX.Text == "admin" && Password_login.Password == "AdminLib123")
            {
                Admin A = new Admin();
                A.Show();
                this.Close();
            }
            if (User_NameBOX.Text == "admin" && Password_login.Password == "123")
            {
                Login_members L = new Login_members();
                L.Show();
                this.Close();
            }
            if (User_NameBOX.Text == "admin" && Password_login.Password == "456")
            {
                Employee L = new Employee();
                L.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("your password or user_name is wrong");
            }
        }
    }
}
