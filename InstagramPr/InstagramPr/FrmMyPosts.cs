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
    public partial class FrmMyPosts : Form
    {
        SqlConnection a = new SqlConnection("Data Source=DESKTOP-E1K6H03;Initial Catalog=InstagramDB;Integrated Security=True");
        DataSet ds = new DataSet();
        DataSet ds2 = new DataSet();
        DataSet ds3 = new DataSet();
        int DestUid;
        int SrcUid;
        String Uname;
        String Ufamily;
        int row;
        
        public FrmMyPosts()
        {
            InitializeComponent();
        }

        public FrmMyPosts(int Uid, String Uname, String Ufamily)
        {
            InitializeComponent();
            this.DestUid = Uid;
            this.Uname = Uname;
            this.Ufamily = Ufamily;
        }

        public FrmMyPosts(int SrcUid, int DestUid, String Uname, String Ufamily)
        {
            InitializeComponent();
            this.SrcUid = SrcUid;
            this.DestUid = DestUid;
            this.Uname = Uname;
            this.Ufamily = Ufamily;
        }
        private void FrmMyPosts_Load(object sender, EventArgs e)
        {
            try
            {
                a.Open();             
                String StrQuery = string.Concat("select Pid, Uname as نام, Ufamily as فامیل, Date as تاریخ, Picture as تصویر from Posts, Users where Users.Uid = Posts.Uid and Posts.Uid = ", DestUid, " order by Date");                  
                SqlDataAdapter sdi = new SqlDataAdapter(StrQuery, a);
                sdi.Fill(ds2, "Posts");
                dataGridView1.DataSource = ds2.Tables["Posts"];
                dataGridView1.Refresh();
                a.Close();                
            }
            catch
            {
                MessageBox.Show("can not show the post");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure you want to delete this post ?", "warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                a.Open();               
                SqlCommand com = new SqlCommand("DeletePost", a);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Pid", Convert.ToInt32(textBox1.Text));
                com.ExecuteNonQuery();
                ds2.Tables["Posts"].Rows[row].Delete();
                dataGridView1.DataSource = ds2.Tables["Posts"];
                dataGridView1.Refresh();
                a.Close();
                
            }
            else
            {
                MessageBox.Show("select a post!");
            }

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            row = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1[0, row].Value.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
