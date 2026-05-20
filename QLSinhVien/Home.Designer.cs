using System.Windows.Forms;

namespace QLSinhVien
{
    partial class Home
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
            this.QLSinhVienPage = new System.Windows.Forms.ToolStripMenuItem();
            this.QLLopHocPage = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoutPage = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QLSinhVienPage,
            this.QLLopHocPage,
            this.LogoutPage});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(974, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // QLSinhVienPage
            // 
            this.QLSinhVienPage.Name = "QLSinhVienPage";
            this.QLSinhVienPage.Size = new System.Drawing.Size(114, 20);
            this.QLSinhVienPage.Text = "Quản Lý Sinh Viên";
            this.QLSinhVienPage.Click += new System.EventHandler(this.QLSinhVienPage_Click);
            // 
            // QLLopHocPage
            // 
            this.QLLopHocPage.Name = "QLLopHocPage";
            this.QLLopHocPage.Size = new System.Drawing.Size(110, 20);
            this.QLLopHocPage.Text = "Quản Lý Lớp Học";
            this.QLLopHocPage.Click += new System.EventHandler(this.QLLopHocPage_Click);
            // 
            // LogoutPage
            // 
            this.LogoutPage.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.LogoutPage.ForeColor = System.Drawing.Color.Tomato;
            this.LogoutPage.Name = "LogoutPage";
            this.LogoutPage.Size = new System.Drawing.Size(73, 20);
            this.LogoutPage.Text = "Đăng xuất";
            this.LogoutPage.Click += new System.EventHandler(this.LogoutPage_Click);
            // 
            // pnl_main
            // 
            this.pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_main.Location = new System.Drawing.Point(0, 24);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(974, 488);
            this.pnl_main.TabIndex = 1;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 512);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Quản Lý Sinh Viên";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem QLSinhVienPage;
        private System.Windows.Forms.ToolStripMenuItem QLLopHocPage;
        private System.Windows.Forms.ToolStripMenuItem LogoutPage;
        private ColorDialog colorDialog1;
        private Panel pnl_main;
    }
}