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
    /// Interaction logic for Donatepage.xaml
    /// </summary>
    public partial class Donatepage : Window
    {
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }
        string uberr;
        string bner;
        string pder;
        string aner;
        public Donatepage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ubna.Text == "")
            {
                bner = "Book name required!";
                bnaer.Content = bner;
            }
            else
            {
                bnaer.Content = "";
            }
            if (updt.Text == "")
            {
                pder = "Published date required!";
                pbter.Content = pder;
            }
            else
            {
                pbter.Content = "";
            }

            if (uaun.Text == "")
            {
                aner = "Author's name required!";
                auner.Content = aner;
            }
            else
            {
                auner.Content = "";
            }
            if (ue.Text == "")
            {
                uberr = "Author's name required!";
                uber.Content = uberr;
            }
            else
            {
                uber.Content = "";
            }
            if (ubna.Text != "" && updt.Text != "" && uaun.Text != "" && ue.Text != "")
            {

                if (combobox2.SelectedItem == Horror)
                {
                    SqlConnection sqod = new SqlConnection(@"Data Source=DESKTOP\SQLEXPRESS;Initial Catalog=Libraryuser;Integrated Security=True");
                    try
                    {
                        sqod.Open();
                        SqlCommand sqlcmp = new SqlCommand("Insert into [Books] (Bname,bauthor,bpbdate,bprice,Cid) values ('" + ubna.Text + "', '" + uaun.Text + "','" + updt.Text + "', '" + ue.Text + "', '" + 1 + "') ", sqod);
                        MessageBox.Show(sqlcmp.CommandText);
                        sqlcmp.ExecuteNonQuery();
                        MessageBox.Show("Saved");
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
                else if (combobox2.SelectedItem == Biography)
                {
                    SqlConnection sqqo = new SqlConnection(@"Data Source=DESKTOP\SQLEXPRESS;Initial Catalog=Libraryuser;Integrated Security=True");
                    try
                    {
                        sqqo.Open();
                        SqlCommand cvb = new SqlCommand("Insert into [Books] (Bname,bauthor,bpbdate,bprice,Cid) values ('" + ubna.Text + "', '" + uaun.Text + "','" + updt.Text + "', '" + ue.Text + "', '" + 2 + "') ", sqqo);
                        MessageBox.Show(cvb.CommandText);
                        cvb.ExecuteNonQuery();
                        MessageBox.Show("Saved");
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
                else if (combobox2.SelectedItem == Documentary)
                {
                    SqlConnection fff = new SqlConnection(@"Data Source=DESKTOP\SQLEXPRESS;Initial Catalog=Libraryuser;Integrated Security=True");
                    try
                    {
                        fff.Open();
                        SqlCommand pp = new SqlCommand("Insert into [Books] (Bname,bauthor,bpbdate,bprice,Cid) values ('" + ubna.Text + "', '" + uaun.Text + "','" + updt.Text + "', '" + ue.Text + "', '" + 3 + "') ", fff);
                        MessageBox.Show(pp.CommandText);
                        pp.ExecuteNonQuery();
                        MessageBox.Show("Saved");
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
                else if (combobox2.SelectedItem == Thriller)
                {
                    SqlConnection fgh = new SqlConnection(@"Data Source=DESKTOP\SQLEXPRESS;Initial Catalog=Libraryuser;Integrated Security=True");
                    try
                    {
                        fgh.Open();
                        SqlCommand pk = new SqlCommand("Insert into [Books] (Bname,bauthor,bpbdate,bprice,Cid) values ('" + ubna.Text + "', '" + uaun.Text + "','" + updt.Text + "', '" + ue.Text + "', '" + 4 + "') ", fgh);
                        MessageBox.Show(pk.CommandText);
                        pk.ExecuteNonQuery();
                        MessageBox.Show("Saved");
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
                else if (combobox2.SelectedItem == Comedy)
                {
                    SqlConnection fij = new SqlConnection(@"Data Source=DESKTOP\SQLEXPRESS;Initial Catalog=Libraryuser;Integrated Security=True");
                    try
                    {
                        fij.Open();
                        SqlCommand pj = new SqlCommand("Insert into [Books] (Bname,bauthor,bpbdate,bprice,Cid) values ('" + ubna.Text + "', '" + uaun.Text + "','" + updt.Text + "', '" + ue.Text + "', '" + 5 + "') ", fij);
                        MessageBox.Show(pj.CommandText);
                        pj.ExecuteNonQuery();
                        MessageBox.Show("Saved");
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
                else if (combobox2.SelectedItem == Poem)
                {
                    SqlConnection kkk = new SqlConnection(@"Data Source=DESKTOP\SQLEXPRESS;Initial Catalog=Libraryuser;Integrated Security=True");
                    try
                    {
                        kkk.Open();
                        SqlCommand ii = new SqlCommand("Insert into [Books] (Bname,bauthor,bpbdate,bprice,Cid) values ('" + ubna.Text + "', '" + uaun.Text + "','" + updt.Text + "', '" + ue.Text + "', '" + 6 + "') ", kkk);
                        MessageBox.Show(ii.CommandText);
                        ii.ExecuteNonQuery();
                        MessageBox.Show("Saved");
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
                else if (combobox2.SelectedItem == SciFi)
                {
                    SqlConnection jj = new SqlConnection(@"Data Source=DESKTOP\SQLEXPRESS;Initial Catalog=Libraryuser;Integrated Security=True");
                    try
                    {
                        jj.Open();
                        SqlCommand vv = new SqlCommand("Insert into [Books] (Bname,bauthor,bpbdate,bprice,Cid) values ('" + ubna.Text + "', '" + uaun.Text + "','" + updt.Text + "', '" + ue.Text + "', '" + 7 + "') ", jj);
                        MessageBox.Show(vv.CommandText);
                        vv.ExecuteNonQuery();
                        MessageBox.Show("Saved");
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
                else if (combobox2.SelectedItem == Mystry)
                {
                    SqlConnection kw = new SqlConnection(@"Data Source=DESKTOP\SQLEXPRESS;Initial Catalog=Libraryuser;Integrated Security=True");
                    try
                    {
                        kw.Open();
                        SqlCommand sa = new SqlCommand("Insert into [Books] (Bname,bauthor,bpbdate,bprice,Cid) values ('" + ubna.Text + "', '" + uaun.Text + "','" + updt.Text + "', '" + ue.Text + "', '" + 8 + "') ", kw);
                        MessageBox.Show(sa.CommandText);
                        sa.ExecuteNonQuery();
                        MessageBox.Show("Saved");
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
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow Mn = new MainWindow();
            Mn.Show();
            this.Hide();
        }
    }
}
