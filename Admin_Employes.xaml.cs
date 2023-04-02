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
    /// Interaction logic for Admin_Employes.xaml
    /// </summary>
    public partial class Admin_Employes : Window
    {
        public Admin_Employes()
        {
            InitializeComponent();
        }

        private void Admin_Employes_Add_Click_01(object sender, RoutedEventArgs e)
        {
            user U = new user();
            U.Show();
            this.Close();
        }

        private void Admin_Employes_payment_Click_01(object sender, RoutedEventArgs e)
        {
            Admin_Employee_pay AEP = new Admin_Employee_pay();
            AEP.Show();
            //this.Close();
        }

    }
}
