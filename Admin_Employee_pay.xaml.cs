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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Admin_Employee_pay.xaml
    /// </summary>
    public partial class Admin_Employee_pay : Window
    {
        public Admin_Employee_pay()
        {
            InitializeComponent();
        }

        private void enter_Click_01(object sender, RoutedEventArgs e)
        {
            if(password_pay01.Password=="AdminLib123")
            {
                MessageBox.Show("successful !");
                this.Close();
            }
            else
            {
                MessageBox.Show("invalid !");
            }
        }
    }
}
