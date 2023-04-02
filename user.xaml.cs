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
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Data;
using System.IO;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for user.xaml
    /// </summary>
    ///

    public partial class user : Window
    {
        private void peymentBTN_Click(object sender, RoutedEventArgs e)
        {
            int a = 0, b = 0, c = 0, d = 0;
            Regex reg_user_name = new Regex(@"^[A-Za-z0-9]{3,32}$");
            if (!reg_user_name.IsMatch(user_name.Text))
            {
                MessageBox.Show("user_name is wrong!");
            }
            else
            {
                a = 1;
            }

            Regex reg_phone_number = new Regex(@"^09[0-9]{9}$");
            if (!reg_phone_number.IsMatch(phone_number.Text))
            {
                MessageBox.Show("phone_number is wrong!");
            }
            else
            {
                b = 1;
            }

            Regex reg_email = new Regex(@"^[A-Za-z0-9_-]{1,32}@[A-Za-z0-9]{1,8}\.[A-Za-z]{1,3}$");
            if (!reg_email.IsMatch(email.Text))
            {
                MessageBox.Show("email is wrong!");
            }
            else
            {
                c = 1;
            }

            Regex reg_password = new Regex(@"(?=.*[a-z])(?=.*[A-Z])[a-zA-Z]{8,32}");
            if (!reg_password.IsMatch(password_signup.Text))
            {
                MessageBox.Show("password is wrong!");
            }
            else
            {
                d = 1;
            }

            if (a == 1 && b == 1 && c == 1 && d == 1)
            {
                SqlConnection user_con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\M.HOSEIN\Desktop\project\sql\wpf.mdf;Integrated Security=True;Connect Timeout=30");
                user_con.Open();
                string command;
                command = "insert into user_Table values('" + user_name.Text + "','" + phone_number.Text + "','" + email.Text + "','" + password_signup.Text + "')";
                SqlCommand user_com = new SqlCommand(command, user_con);
                user_com.BeginExecuteNonQuery();
                user_con.Close();
                mainpayment MP = new mainpayment();
                MP.Show();
                this.Close();
            }

        }
        public user()
        {
            InitializeComponent();
        }


        private void backBTN_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Main = new MainWindow();
            Main.Show();
            this.Close();
        }



        private void imageBTN_Click(object sender, RoutedEventArgs e)
        {

        }


    }
}
