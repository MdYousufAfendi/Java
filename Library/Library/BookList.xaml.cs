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
    /// Interaction logic for BookList.xaml
    /// </summary>
    public partial class BookList : Window
    {
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }
        public BookList()
        {
            InitializeComponent();
            SqlConnection sql = new SqlConnection(@"Data Source=DESKTOP\SQLEXPRESS;Initial Catalog=Libraryuser;Integrated Security=True");
            try
            {
                sql.Open();
                string query = "Select * from [Books]";
                SqlCommand sqcmd = new SqlCommand(query, sql);
                sqcmd.CommandType = CommandType.Text;
                DataTable dt = new DataTable();
                SqlDataAdapter datadp = new SqlDataAdapter(sqcmd);
                datadp.Fill(dt);
                datagd.ItemsSource = dt.DefaultView;
                
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            finally
            {
                sql.Close();
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Adminchoice sd = new Adminchoice();
            sd.Show();
            this.Hide();
        }
    }
}
