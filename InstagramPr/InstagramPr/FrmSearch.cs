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
    public partial class FrmSearch : Form
    {
        SqlConnection a = new SqlConnection("Data Source=DESKTOP-E1K6H03;Initial Catalog=InstagramDB;Integrated Security=True");
        DataSet ds = new DataSet();
        int SrcUid;
        String Uname;
        String Ufamily;
        public FrmSearch(int SrcUid, String Uname, String Ufamily)
        {
            InitializeComponent();
            this.SrcUid = SrcUid;
            this.Uname = Uname;
            this.Ufamily = Ufamily;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                a.Open();
                if (txtUsername.Text != "")
                {
                    SqlCommand com = new SqlCommand("SearchUsername", a);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@Username", txtUsername.Text);                    
                    SqlDataReader sdr = com.ExecuteReader();
                    
                    if (sdr.HasRows)
                    {
                        a.Close();
                        a.Open();
                        String StrQuery = string.Concat("select Uid, Uname, Ufamily from Users where Username = '" + txtUsername.Text + "'"); 
                        SqlDataAdapter sda = new SqlDataAdapter(StrQuery, a);
                        sda.Fill(ds, "UidFind");
                        int DestUid = Convert.ToInt32(ds.Tables["UidFind"].Rows[0]["Uid"].ToString());
                        String Uname = ds.Tables["UidFind"].Rows[0]["Uname"].ToString();
                        String Ufamily = ds.Tables["UidFind"].Rows[0]["Ufamily"].ToString();                        
                        FrmProfile frm = new FrmProfile(SrcUid, DestUid, Uname, Ufamily);
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("wrong information, try again!");
                        txtUsername.Clear();                        
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
                MessageBox.Show("please try again!");
            }

        }

        private void FrmSearch_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
