using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhVien
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ShowStudentPage();
        }

        private void ResetMenuStyle()
        {
            QLSinhVienPage.Font = new Font(QLSinhVienPage.Font, FontStyle.Regular);
            QLLopHocPage.Font = new Font(QLLopHocPage.Font, FontStyle.Regular);
        }

        private void ShowStudentPage()
        {
            pnl_Student.Visible = true;
            pnl_Class.Visible = false;

            ResetMenuStyle();
            QLSinhVienPage.Font = new Font(QLSinhVienPage.Font, FontStyle.Bold);
        }

        private void ShowClassPage()
        {
            pnl_Student.Visible = false;
            pnl_Class.Visible = true;

            ResetMenuStyle();
            QLLopHocPage.Font = new Font(QLLopHocPage.Font, FontStyle.Bold);
        }
        private void QLSinhVienPage_Click(object sender, EventArgs e)
        {
            ShowStudentPage();
        }

        private void QLLopHocPage_Click(object sender, EventArgs e)
        {
            ShowClassPage();
        }

        private void LogoutPage_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn đăng xuất không?",
                "Đăng xuất",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }
        }
    }
}
