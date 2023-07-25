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
    public partial class FrmRegister : Form
    {
        SqlConnection a = new SqlConnection("Data Source=DESKTOP-E1K6H03;Initial Catalog=InstagramDB;Integrated Security=True");      

        public FrmRegister()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text != "" && txtPassword.Text != "" && txtName.Text != "" && txtFamily.Text != "")
                {
                    a.Open();
                    SqlCommand com = new SqlCommand("UserSelecting", a);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@Username", txtUsername.Text);
                    SqlDataReader sdr = com.ExecuteReader();

                    if (sdr.HasRows)
                    {
                        MessageBox.Show("this username has been used");
                        txtUsername.Clear();
                        a.Close();
                    }

                    else
                    {
                        a.Close();
                        a.Open();
                        com = new SqlCommand("InsertUser", a);
                        com.CommandType = CommandType.StoredProcedure;
                        com.Parameters.AddWithValue("@Uname", txtName.Text);
                        com.Parameters.AddWithValue("@Ufamily", txtFamily.Text);
                        com.Parameters.AddWithValue("@Username", txtUsername.Text);
                        com.Parameters.AddWithValue("@Password", txtPassword.Text);
                        com.ExecuteNonQuery();
                        a.Close();
                        MessageBox.Show("signed up successfuly!");
                        txtName.Clear();
                        txtFamily.Clear();
                        txtPassword.Clear();
                        txtUsername.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("please fill out all the forms!");
                }
            }
            catch
            {
                MessageBox.Show("please try again!");
            }

            
            
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtFamily.Clear();
            txtPassword.Clear();
            txtUsername.Clear();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
