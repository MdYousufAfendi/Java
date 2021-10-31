using System;
using System.Collections.Generic;
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
    /// Interaction logic for UserFirstView.xaml
    /// </summary>
    public partial class UserFirstView : Window
    {
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }
        public UserFirstView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Loginpage l = new Loginpage();
            l.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Singuppage sp = new Singuppage();
            sp.Show();
            this.Hide();
        }
    }
}
