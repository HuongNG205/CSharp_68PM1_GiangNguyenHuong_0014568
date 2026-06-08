using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhVien
{
    public partial class UserControlStudent : UserControl
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        string oldMaSV;

        private const int pageSize = 13;
        private int currentPage = 1;
        private List<SinhVien> currentList = new List<SinhVien>();

        public UserControlStudent()
        {
            InitializeComponent();
        }

        private void UserControlStudent_Load(object sender, EventArgs e)
        {
            LoadStudentTable();
            LoadCombobox();
        }

        private void table_Student_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = table_Student.Rows[e.RowIndex];
            txt_MaSV.Text = row.Cells["MaSV"].Value.ToString();
            txt_TenSV.Text = row.Cells["HoTen"].Value.ToString();
            txt_Gender.Text = row.Cells["Gender"].Value.ToString();
            txt_Class.Text = row.Cells["MaLop"].Value.ToString();
            oldMaSV = row.Cells["MaSV"].Value.ToString();

            if (row.Cells["Birth"].Value != null)
            {
                txt_Birth.Value = Convert.ToDateTime(row.Cells["Birth"].Value);
            }
        }

        private void LoadCombobox()
        {
            txt_Class.DataSource = db.LopHocs.ToList();
            txt_Class.DisplayMember = "MaLop";
            txt_Class.ValueMember = "MaLop";
            txt_Class.SelectedIndex = -1;
        }
        private void LoadStudentTable(string keyword = "")
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                currentList = db.SinhViens.ToList();
            }
            else
            {
                string kw = keyword.Trim().ToLower();
                currentList = db.SinhViens
                    .Where(sv => sv.MaSV.ToLower().Contains(kw)
                              || sv.HoTen.ToLower().Contains(kw)
                              || sv.MaLop.ToLower().Contains(kw))
                    .ToList();
            }

            currentPage = 1;
            ShowCurrentPage();
        }

        public void LoadStudentByClass(string maLop)
        {
            currentList = db.SinhViens
                .Where(s => s.MaLop == maLop)
                .ToList();

            currentPage = 1;
            ShowCurrentPage();
        }

        private void ShowCurrentPage()
        {
            int totalRecords = currentList.Count;
            int totalPages = Math.Max(1, (int)Math.Ceiling((double)totalRecords / pageSize));

            if (currentPage < 1) currentPage = 1;
            if (currentPage > totalPages) currentPage = totalPages;

            var pageData = currentList
                .Skip((currentPage - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            table_Student.DataSource = pageData;

            if (table_Student.Columns.Contains("LopHoc"))
                table_Student.Columns["LopHoc"].Visible = false;

            table_Student.Columns["MaSV"].HeaderText = "Mã sinh viên";
            table_Student.Columns["HoTen"].HeaderText = "Họ tên";
            table_Student.Columns["Gender"].HeaderText = "Giới tính";
            table_Student.Columns["Birth"].HeaderText = "Ngày sinh";
            table_Student.Columns["MaLop"].HeaderText = "Lớp";
            table_Student.Columns["Birth"].DefaultCellStyle.Format = "dd/MM/yyyy";

            studentCount.Text = $"Trang {currentPage}/{totalPages} | {totalRecords} bản ghi";

            btn_goFirstSt.Enabled = currentPage > 1;
            btn_goBackSt.Enabled = currentPage > 1;
            btn_goUpSt.Enabled = currentPage < totalPages;
            btn_goLastSt.Enabled = currentPage < totalPages;
        }

        private void ClearData()
        {
            txt_MaSV.Clear();
            txt_TenSV.Clear();
            txt_searchSt.Clear();
            txt_Gender.SelectedIndex = -1;
            txt_Class.SelectedIndex = -1;
            txt_Birth.Value = DateTime.Now;
            oldMaSV = null;
        }

        private void btn_addSt_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();

            sv.MaSV = txt_MaSV.Text.Trim();
            sv.HoTen = txt_TenSV.Text.Trim();
            sv.Gender = txt_Gender.Text;
            sv.Birth = txt_Birth.Value;
            sv.MaLop = txt_Class.Text;

            db.SinhViens.InsertOnSubmit(sv);
            db.SubmitChanges();

            LoadStudentTable();
            ClearData();
        }

        private void btn_updateSt_Click(object sender, EventArgs e)
        {
            SinhVien sv = db.SinhViens.FirstOrDefault(x => x.MaSV == oldMaSV);
            if (sv == null)
            {
                return;
            }

            sv.MaSV = txt_MaSV.Text.Trim();
            sv.HoTen = txt_TenSV.Text.Trim();
            sv.Gender = txt_Gender.Text;
            sv.Birth = txt_Birth.Value;
            sv.MaLop = txt_Class.Text;

            db.SubmitChanges();

            LoadStudentTable();
            ClearData();
        }

        private void btn_deleteSt_Click(object sender, EventArgs e)
        {
            SinhVien sv = db.SinhViens.FirstOrDefault(x => x.MaSV == txt_MaSV.Text.Trim());
            if (sv == null)
            {
                return;
            }

            db.SinhViens.DeleteOnSubmit(sv);
            db.SubmitChanges();

            LoadStudentTable();
            ClearData();
        }

        private void btn_renewSt_Click(object sender, EventArgs e)
        {
            LoadStudentTable();
            ClearData();
        }

        private void btn_searchSt_Click(object sender, EventArgs e)
        {
            LoadStudentTable(txt_searchSt.Text);
        }

        private void btn_goFirstSt_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            ShowCurrentPage();
        }

        private void btn_goBackSt_Click(object sender, EventArgs e)
        {
            currentPage--;
            ShowCurrentPage();
        }

        private void btn_goUpSt_Click(object sender, EventArgs e)
        {
            currentPage++;
            ShowCurrentPage();
        }

        private void btn_goLastSt_Click(object sender, EventArgs e)
        {
            int totalPages = Math.Max(1, (int)Math.Ceiling((double)currentList.Count / pageSize));
            currentPage = totalPages;
            ShowCurrentPage();
        }
    }
}
