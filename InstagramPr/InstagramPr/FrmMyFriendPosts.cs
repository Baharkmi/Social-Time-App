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
    public partial class FrmMyFriendPosts : Form
    {
        SqlConnection a = new SqlConnection("server=.;database=InstagramDB;integrated security=true;");
        DataSet ds2 = new DataSet();
        int DestUid;
        int SrcUid;
        String Uname;
        String Ufamily;
        public FrmMyFriendPosts()
        {
            InitializeComponent();
        }
        public FrmMyFriendPosts(int Uid, String Uname, String Ufamily)
        {
            InitializeComponent();
            this.DestUid = Uid;
            this.Uname = Uname;
            this.Ufamily = Ufamily;
        }

        private void FrmMyFriendPosts_Load(object sender, EventArgs e)
        {
            try
            {
                a.Open();                
                String StrQuery = string.Concat("select Pid, Uname as نام, Ufamily as فامیل, Date as تاریخ, Picture as تصویر from Posts, Users where Users.Uid = Posts.Uid and (Posts.Uid = ", DestUid);
                StrQuery = string.Concat(StrQuery, " or Posts.Uid in (select Uid1 from Friends)) order by Date");
                SqlDataAdapter sdi = new SqlDataAdapter(StrQuery, a);
                sdi.Fill(ds2, "Posts");
                dataGridView1.DataSource = ds2.Tables["Posts"];
                dataGridView1.Refresh();
                a.Close();
            }
            catch
            {
                MessageBox.Show("نمایش با مشکل مواجه است!");
            }
        }
    }
}
