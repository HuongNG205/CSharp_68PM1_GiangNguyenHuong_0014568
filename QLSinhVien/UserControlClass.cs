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
    public partial class UserControlClass : UserControl
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        private const int pageSize = 13;
        private int currentPage = 1;
        private List<LopHoc> currentList = new List<LopHoc>();

        public UserControlClass()
        {
            InitializeComponent();
        }

        private void UserControlClass_Load(object sender, EventArgs e)
        {
            LoadClassTable();
        }

        private void LoadClassTable(string keyword = "")
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                currentList = db.LopHocs.Where(cl => cl.MaLop != "NONE").ToList();
            }
            else
            {
                string kw = keyword.Trim().ToLower();
                currentList = db.LopHocs
                    .Where(cl => cl.MaLop != "NONE" &&
                                (cl.id.ToString().Contains(kw)
                              || cl.MaLop.ToLower().Contains(kw)
                              || cl.TenLop.ToLower().Contains(kw)))
                    .ToList();
            }

            currentPage = 1;
            ShowCurrentPage();
        }

        private void ShowCurrentPage()
        {
            int totalRecords = currentList.Count;
            int totalPages = Math.Max(1, (int)Math.Ceiling((double)totalRecords / pageSize));

            if (currentPage < 1) currentPage = 1;
            if (currentPage > totalPages) currentPage = totalPages;

            List<LopHoc> pageData = currentList
                            .Skip((currentPage - 1) * pageSize)
                            .Take(pageSize)
                            .ToList();

            table_Class.DataSource = pageData;

            if (table_Class.Columns.Contains("SinhViens"))
                table_Class.Columns["SinhViens"].Visible = false;

            table_Class.Columns["id"].HeaderText = "Mã ID";
            table_Class.Columns["MaLop"].HeaderText = "Mã lớp";
            table_Class.Columns["TenLop"].HeaderText = "Tên lớp";
            table_Class.Columns["Note"].HeaderText = "Ghi chú";

            classCount.Text = $"Trang {currentPage}/{totalPages} | {totalRecords} bản ghi";

            btn_goFirstCl.Enabled = currentPage > 1;
            btn_goBackCl.Enabled = currentPage > 1;
            btn_goUpCl.Enabled = currentPage < totalPages;
            btn_goLastCl.Enabled = currentPage < totalPages;
        }

        private void ClearData()
        {
            txt_MaID.Clear();
            txt_MaLop.Clear();
            txt_TenLop.Clear();
            txt_searchCl.Clear();
            txt_Note.Clear();
        }

        //private void table_Class_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex < 0)
        //    {
        //        return;
        //    }

        //    DataGridViewRow row = table_Class.Rows[e.RowIndex];
        //    txt_MaID.Text = row.Cells["id"].Value.ToString();
        //    txt_MaLop.Text = row.Cells["MaLop"].Value.ToString();
        //    txt_TenLop.Text = row.Cells["TenLop"].Value.ToString();
        //    txt_Note.Text = row.Cells["Note"].Value?.ToString() ?? "";
        //}

        private void btn_addCl_Click(object sender, EventArgs e)
        {
            LopHoc cl = new LopHoc();

            cl.MaLop = txt_MaLop.Text.Trim();
            cl.TenLop = txt_TenLop.Text.Trim();
            cl.Note = txt_Note.Text.Trim();

            db.LopHocs.InsertOnSubmit(cl);
            db.SubmitChanges();

            LoadClassTable();
            ClearData();
        }

        //private void btn_updateCl_Click(object sender, EventArgs e)
        //{
        //    LopHoc cl = db.LopHocs.FirstOrDefault(x => x.id == int.Parse(txt_MaID.Text.Trim()));
        //    if (cl == null)
        //    {
        //        return;
        //    }

        //    cl.MaLop = txt_MaLop.Text.Trim();
        //    cl.TenLop = txt_TenLop.Text.Trim();
        //    cl.Note = txt_Note.Text.Trim();

        //    db.SubmitChanges();

        //    LoadClassTable();
        //    ClearData();
        //}

        //private void btn_deleteCl_Click(object sender, EventArgs e)
        //{
        //    LopHoc cl = db.LopHocs.FirstOrDefault(x => x.id == int.Parse(txt_MaID.Text.Trim()));
        //    if (cl == null)
        //    {
        //        return;
        //    }

        //    List<SinhVien> studentList = db.SinhViens.Where(sv => sv.MaLop == cl.MaLop).ToList();
        //    //foreach (SinhVien sv in studentList)
        //    //{
        //    //    sv.MaLop = "NONE";
        //    //}
        //    if (studentList.Count > 0)
        //    {
        //        return;
        //    }

        //    db.LopHocs.DeleteOnSubmit(cl);
        //    db.SubmitChanges();

        //    LoadClassTable();
        //    ClearData();
        //}

        private void btn_renewCl_Click(object sender, EventArgs e)
        {
            LoadClassTable();
            ClearData();
        }

        //private void btn_searchCl_Click(object sender, EventArgs e)
        //{
        //    LoadClassTable(txt_searchCl.Text);
        //}

        //private void btn_viewCl_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(txt_MaLop.Text))
        //    {
        //        return;
        //    }

        //    //string maLop = txt_MaLop.Text.Trim();

        //    //UserControlStudent ucSV = new UserControlStudent();

        //    //Home homeForm = this.FindForm() as Home;
        //    //if (homeForm == null) return;

        //    //homeForm.showStudentbyClass(ucSV);

        //    //ucSV.LoadStudentByClass(maLop);
        //}

        private void btn_goFirstCl_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            ShowCurrentPage();
        }

        private void btn_goBackCl_Click(object sender, EventArgs e)
        {
            currentPage--;
            ShowCurrentPage();
        }

        private void btn_goUpCl_Click(object sender, EventArgs e)
        {
            currentPage++;
            ShowCurrentPage();
        }

        private void btn_goLastCl_Click(object sender, EventArgs e)
        {
            int totalPages = Math.Max(1, (int)Math.Ceiling((double)currentList.Count / pageSize));
            currentPage = totalPages;
            ShowCurrentPage();
        }
    }
}
