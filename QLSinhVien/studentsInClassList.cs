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
    public partial class studentsInClassList : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        private List<SinhVien> currentList = new List<SinhVien>();

        public studentsInClassList()
        {
            InitializeComponent();
        }

        public void LoadStudentInClass(string maLop)
        {
            currentList = db.SinhViens
                .Where(s => s.MaLop == maLop)
                .ToList();

            table_StudentInClass.DataSource = currentList;

            if (table_StudentInClass.Columns.Contains("LopHoc"))
                table_StudentInClass.Columns["LopHoc"].Visible = false;

            table_StudentInClass.Columns["MaSV"].HeaderText = "Mã sinh viên";
            table_StudentInClass.Columns["HoTen"].HeaderText = "Họ tên";
            table_StudentInClass.Columns["Gender"].HeaderText = "Giới tính";
            table_StudentInClass.Columns["Birth"].HeaderText = "Ngày sinh";
            table_StudentInClass.Columns["MaLop"].HeaderText = "Lớp";
            table_StudentInClass.Columns["Birth"].DefaultCellStyle.Format = "dd/MM/yyyy";

            txt_ClassName.Text = maLop;
            txt_StudentNumber.Text = currentList.Count.ToString();
        }

        private void btn_renewCl_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
