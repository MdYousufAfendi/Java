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
    /// Interaction logic for Loginpage.xaml
    /// </summary>
    public partial class Loginpage : Window
    {
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }
        string userErr;
        string passErr;
        public Loginpage()
        {
            InitializeComponent();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (uName.Text == "")
            {
                userErr = "Username is required!";
                userError.Content = userErr;
            }
            else
            {
                userError.Content = "";
            }
            if (uPass.Password == "")
            {
                passErr = "Password is required!";
                passError.Content = passErr;
            }
            else
            {
                passError.Content = "";
            }
            if (uName.Text != "" && uPass.Password != "")
            {


                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP\SQLEXPRESS;Initial Catalog=Libraryuser;Integrated Security=True");

                try
                {


                    con.Open();
                    string query = "Select count(*) from [userinfo] where UserName= '" + uName.Text + "' AND Password= '" + uPass.Password + "'   ";
                    SqlCommand sqlcmd = new SqlCommand(query, con);
                    int a = Convert.ToInt32(sqlcmd.ExecuteScalar());

                    if (a == 1)
                    {
                        
                        MainWindow MW = new MainWindow();
                        MW.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username / password!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }

        }
    }
}

