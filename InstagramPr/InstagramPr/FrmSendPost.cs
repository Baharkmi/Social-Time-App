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
using System.IO;

namespace InstagramPr
{
    public partial class FrmSendPost : Form
    {
        SqlConnection a = new SqlConnection("Data Source=DESKTOP-E1K6H03;Initial Catalog=InstagramDB;Integrated Security=True");      
        int Uid, Flag = 0;        
        byte[] t;
        public FrmSendPost(int Uid)
        {
            InitializeComponent();
            this.Uid = Uid;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSendPost_Load(object sender, EventArgs e)
        {
            //this.image_UploadTableAdapter
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (richTextBox1.Text != "" && Flag == 0)
                {

                    a.Open();
                    SqlCommand com = new SqlCommand("SendTextPost", a);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@Post", richTextBox1.Text);
                    com.Parameters.AddWithValue("@Date", DateTime.Today);
                    com.Parameters.AddWithValue("@Uid", Uid);
                    com.ExecuteNonQuery();
                    a.Close();
                    MessageBox.Show("post sent succussfuly!");
                    richTextBox1.Clear();
                }
                else if (richTextBox1.Text != "" && Flag == 1)
                {

                    a.Open();
                    SqlCommand com = new SqlCommand("SendTextPicPost", a);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@Post", richTextBox1.Text);
                    com.Parameters.AddWithValue("@Date", DateTime.Today);
                    com.Parameters.AddWithValue("@Picture", t);
                    com.Parameters.AddWithValue("@Uid", Uid);
                    com.ExecuteNonQuery();
                    a.Close();
                    MessageBox.Show("post sent succussfuly!");
                    richTextBox1.Clear();
                }
                else
                {
                    MessageBox.Show("fill out all the required fields!");
                }
            }
            catch
            {
                MessageBox.Show("please try again!");
            }
        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }


        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                Flag = 1;
                // open file dialog 
                OpenFileDialog open = new OpenFileDialog();
                // image filters
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                DialogResult dr = open.ShowDialog();
                pictureBox1.Image = Image.FromFile(open.FileName);
                t = imageToByteArray(Image.FromFile(open.FileName));
                textBox1.Text = open.FileName;
            }
            catch
            {
                MessageBox.Show("Try again!");
            }
            
        }
    }
}
