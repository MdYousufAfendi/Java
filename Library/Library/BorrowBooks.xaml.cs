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
    /// Interaction logic for BorrowBooks.xaml
    /// </summary>
    public partial class BorrowBooks : Window
    {
        string booket;
        public BorrowBooks()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (combo4.SelectedItem == Horror)
            {
                SqlConnection sqod = new SqlConnection(@"Data Source=DESKTOP\SQLEXPRESS;Initial Catalog=Libraryuser;Integrated Security=True");
                try
                {
                    sqod.Open();
                    SqlCommand sqlcmp = new SqlCommand(" Select * from [Books] where cid=('" + 1 + "')  ", sqod);
                    MessageBox.Show(sqlcmp.CommandText);
                    sqlcmp.ExecuteNonQuery();
                    sqlcmp.CommandType = CommandType.Text;
                    DataTable dt = new DataTable();
                    SqlDataAdapter datadp = new SqlDataAdapter(sqlcmp);
                    datadp.Fill(dt);
                    dta.ItemsSource = dt.DefaultView;


                }
                catch (Exception we)
                {
                    MessageBox.Show(we.Message);
                }
                finally
                {
                    sqod.Close();
                }
            }
            else if (combo4.SelectedItem == Biography)
            {
                SqlConnection sqqo = new SqlConnection(@"Data Source=DESKTOP\SQLEXPRESS;Initial Catalog=Libraryuser;Integrated Security=True");
                try
                {
                    sqqo.Open();
                    SqlCommand cvb = new SqlCommand("Select * from [Books] where cid= ('" + 2 + "') ", sqqo);
                    MessageBox.Show(cvb.CommandText);
                    cvb.ExecuteNonQuery();
                    cvb.CommandType = CommandType.Text;
                    DataTable dt = new DataTable();
                    SqlDataAdapter datadp = new SqlDataAdapter(cvb);
                    datadp.Fill(dt);
                    dta.ItemsSource = dt.DefaultView;

                }
                catch (Exception wm)
                {
                    MessageBox.Show(wm.Message);
                }
                finally
                {
                    sqqo.Close();
                }

            }
            else if (combo4.SelectedItem == Documentary)
            {
                SqlConnection fff = new SqlConnection(@"Data Source=DESKTOP\SQLEXPRESS;Initial Catalog=Libraryuser;Integrated Security=True");
                try
                {
                    fff.Open();
                    SqlCommand pp = new SqlCommand("Select * from [Books] where cid= ( '" + 3 + "') ", fff);
                    MessageBox.Show(pp.CommandText);
                    pp.ExecuteNonQuery();
                    pp.CommandType = CommandType.Text;
                    DataTable dt = new DataTable();
                    SqlDataAdapter datadp = new SqlDataAdapter(pp);
                    datadp.Fill(dt);
                    dta.ItemsSource = dt.DefaultView;

                }
                catch (Exception wm)
                {
                    MessageBox.Show(wm.Message);
                }
                finally
                {
                    fff.Close();
                }

            }
            else if (combo4.SelectedItem == Thriller)
            {
                SqlConnection fgh = new SqlConnection(@"Data Source=DESKTOP\SQLEXPRESS;Initial Catalog=Libraryuser;Integrated Security=True");
                try
                {
                    fgh.Open();
                    SqlCommand pk = new SqlCommand("Select * from [Books] where cid= ( '" + 4 + "') ", fgh);
                    MessageBox.Show(pk.CommandText);
                    pk.ExecuteNonQuery();
                    pk.CommandType = CommandType.Text;
                    DataTable dt = new DataTable();
                    SqlDataAdapter datadp = new SqlDataAdapter(pk);
                    datadp.Fill(dt);
                    dta.ItemsSource = dt.DefaultView;

                }
                catch (Exception wm)
                {
                    MessageBox.Show(wm.Message);
                }
                finally
                {
                    fgh.Close();
                }

            }
            else if (combo4.SelectedItem == Comedy)
            {
                SqlConnection fij = new SqlConnection(@"Data Source=DESKTOP\SQLEXPRESS;Initial Catalog=Libraryuser;Integrated Security=True");
                try
                {
                    fij.Open();
                    SqlCommand pj = new SqlCommand("Select * from [Books] where cid= ( '" + 5 + "') ", fij);
                    MessageBox.Show(pj.CommandText);
                    pj.ExecuteNonQuery();
                    pj.CommandType = CommandType.Text;
                    DataTable dt = new DataTable();
                    SqlDataAdapter datadp = new SqlDataAdapter(pj);
                    datadp.Fill(dt);
                    dta.ItemsSource = dt.DefaultView;
                }
                catch (Exception wm)
                {
                    MessageBox.Show(wm.Message);
                }
                finally
                {
                    fij.Close();
                }

            }
            else if (combo4.SelectedItem == Poem)
            {
                SqlConnection kkk = new SqlConnection(@"Data Source=DESKTOP\SQLEXPRESS;Initial Catalog=Libraryuser;Integrated Security=True");
                try
                {
                    kkk.Open();
                    SqlCommand ii = new SqlCommand("Select * from [Books] where cid= (  '" + 6 + "') ", kkk);
                    MessageBox.Show(ii.CommandText);
                    ii.ExecuteNonQuery();
                    ii.CommandType = CommandType.Text;
                    DataTable dt = new DataTable();
                    SqlDataAdapter datadp = new SqlDataAdapter(ii);
                    datadp.Fill(dt);
                    dta.ItemsSource = dt.DefaultView;
                }
                catch (Exception wm)
                {
                    MessageBox.Show(wm.Message);
                }
                finally
                {
                    kkk.Close();
                }

            }
            else if (combo4.SelectedItem == SciFi)
            {
                SqlConnection jj = new SqlConnection(@"Data Source=DESKTOP\SQLEXPRESS;Initial Catalog=Libraryuser;Integrated Security=True");
                try
                {
                    jj.Open();
                    SqlCommand vv = new SqlCommand("Select * from [Books] where cid= ('" + 7 + "') ", jj);
                    MessageBox.Show(vv.CommandText);
                    vv.ExecuteNonQuery();
                    vv.CommandType = CommandType.Text;
                    DataTable dt = new DataTable();
                    SqlDataAdapter datadp = new SqlDataAdapter(vv);
                    datadp.Fill(dt);
                    dta.ItemsSource = dt.DefaultView;

                }
                catch (Exception wm)
                {
                    MessageBox.Show(wm.Message);
                }
                finally
                {
                    jj.Close();
                }

            }
            else if (combo4.SelectedItem == Mystry)
            {
                SqlConnection kw = new SqlConnection(@"Data Source=DESKTOP\SQLEXPRESS;Initial Catalog=Libraryuser;Integrated Security=True");
                try
                {
                    kw.Open();
                    SqlCommand sa = new SqlCommand("Select * from [Books] where cid= ( '" + 8 + "') ", kw);
                    MessageBox.Show(sa.CommandText);
                    sa.ExecuteNonQuery();
                    sa.CommandType = CommandType.Text;
                    DataTable dt = new DataTable();
                    SqlDataAdapter datadp = new SqlDataAdapter(sa);
                    datadp.Fill(dt);
                    dta.ItemsSource = dt.DefaultView;
                }
                catch (Exception wm)
                {
                    MessageBox.Show(wm.Message);
                }
                finally
                {
                    kw.Close();
                }

            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (ubna.Text == "")
            {
                booket = "book name required";
                boerror.Content = booket;
            }
            else
            {
                boerror.Content = "";
            }
            if (ubna.Text != "")
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP\SQLEXPRESS;Initial Catalog=Libraryuser;Integrated Security=True");
                try
                {
                    con.Open();
                    SqlCommand ql = new SqlCommand(@"DELETE FROM [Books] where bname=('" + ubna.Text + "') ", con);
                    MessageBox.Show(ql.CommandText);
                    ql.ExecuteNonQuery();
                    MessageBox.Show("Book Purchased Successfully");
                }
                catch (Exception bl)
                {
                    MessageBox.Show(bl.Message);

                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow nop = new MainWindow();
            nop.Show();
            this.Hide();
        }
    }
}
