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
    /// Interaction logic for Adminpage.xaml
    /// </summary>
    public partial class Adminpage : Window
    {
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }
        string userr;
        string pserr;
        public Adminpage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (uN.Text == "")
            {
                userr = "Username is required!";
                usrerr.Content = userr;
            }
            else
            {
                usrerr.Content = "";
            }
            if (uP.Password == "")
            {
                pserr = "Password is required!";
                paserr.Content = pserr;
            }
            else
            {
                paserr.Content = "";
            }
            if (uN.Text != "" && uP.Password != "")
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP\SQLEXPRESS;Initial Catalog=Libraryuser;Integrated Security=True");
                try
                {
                    conn.Open();
                    string query = "Select count(*) from [Admin] where Username= '" + uN.Text + "' AND password= '" + uP.Password + "'   ";
                    SqlCommand sqlcmd = new SqlCommand(query, conn);
                    int a = Convert.ToInt32(sqlcmd.ExecuteScalar());
                    if (a == 1)
                    {
                        Adminchoice adc = new Adminchoice();
                        adc.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username / password!");
                    }
                }
                catch(Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }
                finally
                {
                    conn.Close();
                }
            }

        }
    }
}
