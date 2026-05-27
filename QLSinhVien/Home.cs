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
    public partial class Home : Form
    {
        UserControlStudent ucStudent = new UserControlStudent();
        UserControlClass ucClass = new UserControlClass();
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
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
            pnl_main.Controls.Clear();
            ucStudent.Dock = DockStyle.Fill;
            pnl_main.Controls.Add(ucStudent);

            ResetMenuStyle();
            QLSinhVienPage.Font = new Font(QLSinhVienPage.Font, FontStyle.Bold);
        }

        public void showStudentbyClass (UserControlStudent ucSV)
        {
            pnl_main.Controls.Clear();
            ucStudent.Dock = DockStyle.Fill;
            pnl_main.Controls.Add(ucSV);

            ResetMenuStyle();
            QLSinhVienPage.Font = new Font(QLSinhVienPage.Font, FontStyle.Bold);
        }

        private void ShowClassPage()
        {
            pnl_main.Controls.Clear();
            ucClass.Dock = DockStyle.Fill;
            pnl_main.Controls.Add(ucClass);

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
                Login f1 = new Login();
                f1.Show();
                this.Hide();
            }
        }


    }
}
