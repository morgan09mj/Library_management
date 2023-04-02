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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Admin_Bank.xaml
    /// </summary>
    public partial class Admin_Bank : Window
    {
        public Admin_Bank()
        {
            InitializeComponent();
            BANKBALANCE.Text = "0";
            BANKDONATION.Text="0";
        }


        private void BANKENTER_Click(object sender, RoutedEventArgs e)
        {
            mainpayment MP = new mainpayment();
            MP.Show();
            this.Close();
        }
    }
}
