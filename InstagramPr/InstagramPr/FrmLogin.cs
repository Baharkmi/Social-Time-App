using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InstagramPr
{
    public partial class FrmLogin : Form
    {
        SqlConnection a = new SqlConnection("Data Source=DESKTOP-E1K6H03;Initial Catalog=InstagramDB;Integrated Security=True");
        DataSet ds = new DataSet();
        int Uid;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                a.Open();
                if (txtUsername.Text != "" && txtPassword.Text != "")
                {
                    SqlCommand com = new SqlCommand("SearchUser", a);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@Username", txtUsername.Text);
                    com.Parameters.AddWithValue("@Password", txtPassword.Text);
                    SqlDataReader sdr = com.ExecuteReader();
                    
                    if (sdr.HasRows)
                    {
                        a.Close();
                        a.Open();
                        String StrQuery = string.Concat("select Uid, Uname, Ufamily from Users where Username = '", txtUsername.Text, "'");
                        SqlDataAdapter da = new SqlDataAdapter(StrQuery, a);
                        da.Fill(ds, "UidFind");
                        String U = ds.Tables["UidFind"].Rows[0]["Uid"].ToString();
                        Uid = Convert.ToInt32(U);
                        String Uname = ds.Tables["UidFind"].Rows[0]["Uname"].ToString();
                        String Ufamily = ds.Tables["UidFind"].Rows[0]["Ufamily"].ToString();

                        FrmProfile frm = new FrmProfile(txtUsername.Text, Uid, Uname, Ufamily);
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("wrong information! try again!");
                        txtUsername.Clear();
                        txtPassword.Clear();
                    }                    

                }
                else
                {
                    MessageBox.Show("fill out all the fields!");
                }
                a.Close();
            }
            catch
            {
                MessageBox.Show("try again!");
            }

        }


        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
