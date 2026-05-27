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
    public partial class UserControlClass : UserControl
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public UserControlClass()
        {
            InitializeComponent();
        }

        private void UserControlClass_Load(object sender, EventArgs e)
        {
            LoadClassTable();
        }

        private void LoadClassTable()
        {
            List<LopHoc> clList = db.LopHocs.ToList();
            table_Class.DataSource = clList;

            table_Class.Columns["id"].HeaderText = "Mã ID";
            table_Class.Columns["MaLop"].HeaderText = "Mã lớp";
            table_Class.Columns["TenLop"].HeaderText = "Tên lớp";
            table_Class.Columns["Note"].HeaderText = "Ghi chú";
        }

        private void ClearData()
        {
            txt_MaID.Clear();
            txt_MaLop.Clear();
            txt_TenLop.Clear();
            txt_searchCl.Clear();
            txt_Note.Clear();
        }

        private void table_Class_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = table_Class.Rows[e.RowIndex];
            txt_MaID.Text = row.Cells["id"].Value.ToString();
            txt_MaLop.Text = row.Cells["MaLop"].Value.ToString();
            txt_TenLop.Text = row.Cells["TenLop"].Value.ToString();
            txt_Note.Text = row.Cells["Note"].Value?.ToString() ?? "";
        }

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

        private void btn_updateCl_Click(object sender, EventArgs e)
        {
            LopHoc cl = db.LopHocs.FirstOrDefault(x => x.id == int.Parse(txt_MaID.Text.Trim()));

            if (cl == null)
            {
                return;
            }

            cl.MaLop = txt_MaLop.Text.Trim();
            cl.TenLop = txt_TenLop.Text.Trim();
            cl.Note = txt_Note.Text.Trim();

            db.SubmitChanges();

            LoadClassTable();
            ClearData();
        }

        private void btn_deleteCl_Click(object sender, EventArgs e)
        {
            LopHoc cl = db.LopHocs.FirstOrDefault(x => x.id == int.Parse(txt_MaID.Text.Trim()));

            if (cl == null)
            {
                return;
            }

            db.LopHocs.DeleteOnSubmit(cl);
            db.SubmitChanges();

            LoadClassTable();
            ClearData();
        }

        private void btn_renewCl_Click(object sender, EventArgs e)
        {
            LoadClassTable();
            ClearData();
        }

        private void btn_searchCl_Click(object sender, EventArgs e)
        {
            string keyword = txt_searchCl.Text.Trim();

            List<LopHoc> clList = db.LopHocs
                .Where(cl => cl.id.ToString().Contains(keyword)
                          || cl.MaLop.Contains(keyword)
                          || cl.TenLop.Contains(keyword))
                .ToList();

            table_Class.DataSource = clList;
        }

        private void btn_viewCl_Click(object sender, EventArgs e)
        {
            LopHoc cl = db.LopHocs.FirstOrDefault(x => x.MaLop == txt_MaLop.Text.Trim());

            if (cl == null)
            {
                return;
            }

            string maLop = txt_MaLop.Text.Trim();
            UserControlStudent ucSV = new UserControlStudent();
            ucSV.LoadStudentByClass(maLop);

            this.Controls.Clear();
            this.Controls.Add(ucSV);

            ucSV.Dock = DockStyle.Fill;
        }
    }
}
