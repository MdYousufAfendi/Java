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
    /// Interaction logic for Singuppage.xaml
    /// </summary>
    public partial class Singuppage : Window
    {
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }
        string userErr;
        string MobileErr;
        string EmailErr;
        string passErr;
        public Singuppage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
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

            if (Mno.Text == "")
            {
                MobileErr = "Mobile number required!";
                MnoError.Content = MobileErr;
            }
            else
            {
                MnoError.Content = "";
            }

            if (Em.Text == "")
            {
                EmailErr = "Email address required!";
                EmError.Content = EmailErr;
            }
            else
            {
                EmError.Content = "";
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
            if (uName.Text != "" && Mno.Text!="" && Em.Text != "" && uPass.Password != "" )
            {
                SqlConnection Cn = new SqlConnection(@"Data Source=DESKTOP\SQLEXPRESS;Initial Catalog=Libraryuser;Integrated Security=True");
                Cn.Open();
                SqlCommand cmd = new SqlCommand("Insert into [userinfo](UserName, Mobileno, Email, Password) values ('" + uName.Text + "'," + Mno.Text + ",'" + Em.Text + "','" + uPass.Password + "') ",Cn);
                MessageBox.Show(cmd.CommandText);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Saved");
                Loginpage Lg = new Loginpage();
                Lg.Show();
                this.Hide();
                Cn.Close();

            }
        }
    }
}
