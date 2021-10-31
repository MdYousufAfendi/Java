using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace Library
{
    /// <summary>
    /// Interaction logic for Adminchoice.xaml
    /// </summary>
    public partial class Adminchoice : Window
    {
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }
        public Adminchoice()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Logout lgt = new Logout();
            lgt.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AdminEntry ade = new AdminEntry();
            ade.Show();
            this.Hide();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            BookList bl = new BookList();
            bl.Show();
            this.Hide();
        }
    }
}
