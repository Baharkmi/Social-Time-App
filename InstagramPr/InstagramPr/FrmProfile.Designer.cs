namespace InstagramPr
{
    partial class FrmProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.اطلاعاتشخصیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.لیستپستهایمنToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.جستجوToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ارسالپستToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lnklblFollow = new System.Windows.Forms.LinkLabel();
            this.lblNameFamily = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.لیستکلپستهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اطلاعاتشخصیToolStripMenuItem,
            this.لیستکلپستهاToolStripMenuItem,
            this.لیستپستهایمنToolStripMenuItem,
            this.جستجوToolStripMenuItem,
            this.ارسالپستToolStripMenuItem,
            this.خروجToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(935, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // اطلاعاتشخصیToolStripMenuItem
            // 
            this.اطلاعاتشخصیToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.اطلاعاتشخصیToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.اطلاعاتشخصیToolStripMenuItem.Name = "اطلاعاتشخصیToolStripMenuItem";
            this.اطلاعاتشخصیToolStripMenuItem.Size = new System.Drawing.Size(87, 32);
            this.اطلاعاتشخصیToolStripMenuItem.Text = "Profile";
            this.اطلاعاتشخصیToolStripMenuItem.Click += new System.EventHandler(this.اطلاعاتشخصیToolStripMenuItem_Click);
            // 
            // لیستپستهایمنToolStripMenuItem
            // 
            this.لیستپستهایمنToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.لیستپستهایمنToolStripMenuItem.Name = "لیستپستهایمنToolStripMenuItem";
            this.لیستپستهایمنToolStripMenuItem.Size = new System.Drawing.Size(78, 32);
            this.لیستپستهایمنToolStripMenuItem.Text = "My Posts";
            this.لیستپستهایمنToolStripMenuItem.Click += new System.EventHandler(this.لیستپستهایمنToolStripMenuItem_Click);
            // 
            // جستجوToolStripMenuItem
            // 
            this.جستجوToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.جستجوToolStripMenuItem.Name = "جستجوToolStripMenuItem";
            this.جستجوToolStripMenuItem.Size = new System.Drawing.Size(65, 32);
            this.جستجوToolStripMenuItem.Text = "Search";
            this.جستجوToolStripMenuItem.Click += new System.EventHandler(this.جستجوToolStripMenuItem_Click);
            // 
            // ارسالپستToolStripMenuItem
            // 
            this.ارسالپستToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ارسالپستToolStripMenuItem.Name = "ارسالپستToolStripMenuItem";
            this.ارسالپستToolStripMenuItem.Size = new System.Drawing.Size(85, 32);
            this.ارسالپستToolStripMenuItem.Text = "Send Post";
            this.ارسالپستToolStripMenuItem.Click += new System.EventHandler(this.ارسالپستToolStripMenuItem_Click);
            // 
            // خروجToolStripMenuItem
            // 
            this.خروجToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            this.خروجToolStripMenuItem.Size = new System.Drawing.Size(74, 32);
            this.خروجToolStripMenuItem.Text = "Log Out";
            this.خروجToolStripMenuItem.Click += new System.EventHandler(this.خروجToolStripMenuItem_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(168, 282);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView2.Size = new System.Drawing.Size(460, 110);
            this.dataGridView2.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(168, 150);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(460, 110);
            this.dataGridView1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 282);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Followers";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Followings";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lnklblFollow
            // 
            this.lnklblFollow.AutoSize = true;
            this.lnklblFollow.Location = new System.Drawing.Point(45, 93);
            this.lnklblFollow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnklblFollow.Name = "lnklblFollow";
            this.lnklblFollow.Size = new System.Drawing.Size(47, 17);
            this.lnklblFollow.TabIndex = 9;
            this.lnklblFollow.TabStop = true;
            this.lnklblFollow.Text = "Follow";
            this.lnklblFollow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblFollow_LinkClicked);
            // 
            // lblNameFamily
            // 
            this.lblNameFamily.AutoSize = true;
            this.lblNameFamily.Location = new System.Drawing.Point(39, 50);
            this.lblNameFamily.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameFamily.Name = "lblNameFamily";
            this.lblNameFamily.Size = new System.Drawing.Size(46, 17);
            this.lblNameFamily.TabIndex = 8;
            this.lblNameFamily.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.lblNameFamily);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.lnklblFollow);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(93, 80);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(761, 425);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bio";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // لیستکلپستهاToolStripMenuItem
            // 
            this.لیستکلپستهاToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.لیستکلپستهاToolStripMenuItem.Name = "لیستکلپستهاToolStripMenuItem";
            this.لیستکلپستهاToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.لیستکلپستهاToolStripMenuItem.Size = new System.Drawing.Size(76, 32);
            this.لیستکلپستهاToolStripMenuItem.Text = "All Posts";
            this.لیستکلپستهاToolStripMenuItem.Click += new System.EventHandler(this.لیستکلپستهاToolStripMenuItem_Click);
            // 
            // FrmProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 535);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmProfile";
            this.Text = "SocialTime";
            this.Load += new System.EventHandler(this.FrmProfile_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem اطلاعاتشخصیToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ارسالپستToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem لیستپستهایمنToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem جستجوToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem خروجToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnklblFollow;
        private System.Windows.Forms.Label lblNameFamily;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem لیستکلپستهاToolStripMenuItem;
    }
}