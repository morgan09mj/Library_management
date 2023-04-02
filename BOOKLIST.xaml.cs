using System;
using System.Collections.Generic;
using System.Text;
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
    /// Interaction logic for BOOKLIST.xaml
    /// </summary>
    public partial class BOOKLIST : Window
    {
        public BOOKLIST()
        {
            InitializeComponent();
        }

        private void addbookBTN_Click_01(object sender, RoutedEventArgs e)
        {
            Admin_Book AB = new Admin_Book();
            AB.Show();
            this.Close();
        }
    }
}
