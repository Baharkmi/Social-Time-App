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
    public partial class FrmProfile : Form
    {
        SqlConnection a = new SqlConnection("Data Source=DESKTOP-E1K6H03;Initial Catalog=InstagramDB;Integrated Security=True");
        DataSet ds1 = new DataSet();
        DataSet ds2 = new DataSet();          
        String Username;
        String Uname;
        String Ufamily;
        
        int DestUid;
        int SrcUid;
        public FrmProfile(String Username, int Uid, String Uname, String Ufamily)
        {
            InitializeComponent();
            this.Username = Username;
            this.DestUid = Uid;
            this.SrcUid = Uid;
            this.Uname = Uname;
            this.Ufamily = Ufamily;            

        }

        public FrmProfile(int SrcUid, int DestUid, String Uname, String Ufamily)
        {
            InitializeComponent();
            this.SrcUid = SrcUid;
            this.DestUid = DestUid;
            this.Uname = Uname;
            this.Ufamily = Ufamily;
        } 

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmProfile_Load(object sender, EventArgs e)
        {
            try
            {
                lblNameFamily.Text = String.Concat(Uname, " ", Ufamily);
                a.Open();
                String StrQuery = string.Concat("select Uname, Ufamily, Username from FriendView where Uid in (select " +
                "Uid2 from Friends where Uid1= ", DestUid, ")");
                SqlDataAdapter sda = new SqlDataAdapter(StrQuery, a);
                sda.Fill(ds1, "Users");

                dataGridView1.DataSource = ds1.Tables["Users"];
                dataGridView1.Refresh();
                a.Close();


                a.Open();
                StrQuery = string.Concat("select Uname, Ufamily, Username from FriendView where Uid in (select " +
                "Uid1 from Friends where Uid2= ", DestUid, ")");

                sda = new SqlDataAdapter(StrQuery, a);
                sda.Fill(ds2, "Users");

                dataGridView2.DataSource = ds2.Tables["Users"];
                dataGridView2.Refresh();
                a.Close();
            }
            catch
            {
                MessageBox.Show("there is a problem in showing");
            }
        }

        private void lnklblFollow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (SrcUid == DestUid)
                {
                    MessageBox.Show("you can not follow yourself");
                }
                else
                {
                    a.Open();
                    SqlCommand com = new SqlCommand("Follow", a);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@Uid1", SrcUid);
                    com.Parameters.AddWithValue("@Uid2", DestUid);
                    com.ExecuteReader();
                    MessageBox.Show("you were added to this person's followers!");
                    a.Close();
                    a.Open();

                    String StrQuery = string.Concat("select Uname, Ufamily, Username from Users where Uid in (select " +
                    "Uid1 from Friends where Uid2= ", DestUid, ")");
                    ds2.Tables["Users"].Clear();
                    SqlDataAdapter sda = new SqlDataAdapter(StrQuery, a);
                    sda.Fill(ds2, "Users");
                    dataGridView2.DataSource = ds2.Tables["Users"];
                    dataGridView2.Refresh();
                    a.Close();

                    /*a.Open();
                    String StrQuery2 = string.Concat("select Uname, Ufamily, Username from Users where Uid in (select " +
                    "Uid2 from Friends where Uid1= ", SrcUid, ")");
                    ds1.Tables["Users"].Clear();
                    SqlDataAdapter sda2 = new SqlDataAdapter(StrQuery2, a);
                    sda2.Fill(ds1, "Users");
                    dataGridView2.DataSource = ds1.Tables["Users"];
                    dataGridView2.Refresh();*/
                }
            }
            catch
            {
                MessageBox.Show("there is a problem in showing!");
            }

        }

        private void ارسالپستToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSendPost frm = new FrmSendPost(DestUid);
            frm.Show();            
        }

        private void جستجوToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSearch frm = new FrmSearch(DestUid, Uname, Ufamily);
            frm.Show();
            //this.Close();
        }

        private void لیستپستهایمنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMyPosts frm = new FrmMyPosts(DestUid, Uname, Ufamily);
            frm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void اطلاعاتشخصیToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void لیستکلپستهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMyFriendPosts frm = new FrmMyFriendPosts(DestUid, Uname, Ufamily);
            frm.Show();
        }
    }
}
