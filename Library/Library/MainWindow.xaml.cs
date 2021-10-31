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

namespace Library
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Logout Lt = new Logout();
            Lt.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            BoughtBooks bk = new BoughtBooks();
            bk.Show();
            this.Hide();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            BorrowBooks b = new BorrowBooks();
            b.Show();
            this.Hide();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Donatepage Dp = new Donatepage();
            Dp.Show();
            this.Hide();
        }
    }
}
