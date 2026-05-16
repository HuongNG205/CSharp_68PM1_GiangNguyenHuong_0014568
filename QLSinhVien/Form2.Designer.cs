using System.Windows.Forms;

namespace QLSinhVien
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.QLSinhVienPage = new System.Windows.Forms.ToolStripMenuItem();
            this.QLLopHocPage = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoutPage = new System.Windows.Forms.ToolStripMenuItem();
            this.QLSinhVienPage.Click += new System.EventHandler(this.QLSinhVienPage_Click);
            this.QLLopHocPage.Click += new System.EventHandler(this.QLLopHocPage_Click);
            this.LogoutPage.Click += new System.EventHandler(this.LogoutPage_Click);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.pnl_Student = new System.Windows.Forms.Panel();
            this.ctn_Student = new System.Windows.Forms.SplitContainer();
            this.btn_renewSt = new System.Windows.Forms.Button();
            this.btn_deleteSt = new System.Windows.Forms.Button();
            this.btn_updateSt = new System.Windows.Forms.Button();
            this.btn_addSt = new System.Windows.Forms.Button();
            this.box_Student = new System.Windows.Forms.GroupBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.txt_Class = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Gender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Birth = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TenSV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_goLastSt = new System.Windows.Forms.Button();
            this.btn_goUpSt = new System.Windows.Forms.Button();
            this.studentCount = new System.Windows.Forms.Label();
            this.btn_goBackSt = new System.Windows.Forms.Button();
            this.btn_goFirstSt = new System.Windows.Forms.Button();
            this.table_Student = new System.Windows.Forms.DataGridView();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_searchSt = new System.Windows.Forms.Button();
            this.txt_searchSt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnl_Class = new System.Windows.Forms.Panel();
            this.ctn_Class = new System.Windows.Forms.SplitContainer();
            this.btn_viewCl = new System.Windows.Forms.Button();
            this.btn_renewCl = new System.Windows.Forms.Button();
            this.btn_deleteCl = new System.Windows.Forms.Button();
            this.btn_updateCl = new System.Windows.Forms.Button();
            this.btn_addCl = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Note = new System.Windows.Forms.TextBox();
            this.txt_TenLop = new System.Windows.Forms.TextBox();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_MaLop = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_MaID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_goLastCl = new System.Windows.Forms.Button();
            this.btn_goUpCl = new System.Windows.Forms.Button();
            this.classCount = new System.Windows.Forms.Label();
            this.btn_goBackCl = new System.Windows.Forms.Button();
            this.btn_goFirstCl = new System.Windows.Forms.Button();
            this.table_Class = new System.Windows.Forms.DataGridView();
            this.MaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_searchCl = new System.Windows.Forms.Button();
            this.txt_searchCl = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.pnl_Student.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctn_Student)).BeginInit();
            this.ctn_Student.Panel1.SuspendLayout();
            this.ctn_Student.Panel2.SuspendLayout();
            this.ctn_Student.SuspendLayout();
            this.box_Student.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_Student)).BeginInit();
            this.pnl_Class.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctn_Class)).BeginInit();
            this.ctn_Class.Panel1.SuspendLayout();
            this.ctn_Class.Panel2.SuspendLayout();
            this.ctn_Class.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_Class)).BeginInit();
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
            // 
            // QLLopHocPage
            // 
            this.QLLopHocPage.Name = "QLLopHocPage";
            this.QLLopHocPage.Size = new System.Drawing.Size(110, 20);
            this.QLLopHocPage.Text = "Quản Lý Lớp Học";
            // 
            // LogoutPage
            // 
            this.LogoutPage.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.LogoutPage.ForeColor = System.Drawing.Color.Tomato;
            this.LogoutPage.Name = "LogoutPage";
            this.LogoutPage.Size = new System.Drawing.Size(73, 20);
            this.LogoutPage.Text = "Đăng xuất";
            // 
            // pnl_Student
            // 
            this.pnl_Student.Controls.Add(this.ctn_Student);
            this.pnl_Student.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Student.Location = new System.Drawing.Point(0, 24);
            this.pnl_Student.Name = "pnl_Student";
            this.pnl_Student.Size = new System.Drawing.Size(974, 488);
            this.pnl_Student.TabIndex = 1;
            // 
            // ctn_Student
            // 
            this.ctn_Student.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctn_Student.Location = new System.Drawing.Point(0, 0);
            this.ctn_Student.Name = "ctn_Student";
            // 
            // ctn_Student.Panel1
            // 
            this.ctn_Student.Panel1.Controls.Add(this.btn_renewSt);
            this.ctn_Student.Panel1.Controls.Add(this.btn_deleteSt);
            this.ctn_Student.Panel1.Controls.Add(this.btn_updateSt);
            this.ctn_Student.Panel1.Controls.Add(this.btn_addSt);
            this.ctn_Student.Panel1.Controls.Add(this.box_Student);
            // 
            // ctn_Student.Panel2
            // 
            this.ctn_Student.Panel2.Controls.Add(this.btn_goLastSt);
            this.ctn_Student.Panel2.Controls.Add(this.btn_goUpSt);
            this.ctn_Student.Panel2.Controls.Add(this.studentCount);
            this.ctn_Student.Panel2.Controls.Add(this.btn_goBackSt);
            this.ctn_Student.Panel2.Controls.Add(this.btn_goFirstSt);
            this.ctn_Student.Panel2.Controls.Add(this.table_Student);
            this.ctn_Student.Panel2.Controls.Add(this.btn_searchSt);
            this.ctn_Student.Panel2.Controls.Add(this.txt_searchSt);
            this.ctn_Student.Panel2.Controls.Add(this.label6);
            this.ctn_Student.Size = new System.Drawing.Size(974, 488);
            this.ctn_Student.SplitterDistance = 285;
            this.ctn_Student.TabIndex = 0;
            // 
            // btn_renewSt
            // 
            this.btn_renewSt.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_renewSt.FlatAppearance.BorderSize = 0;
            this.btn_renewSt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_renewSt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_renewSt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_renewSt.Location = new System.Drawing.Point(155, 390);
            this.btn_renewSt.Name = "btn_renewSt";
            this.btn_renewSt.Size = new System.Drawing.Size(124, 39);
            this.btn_renewSt.TabIndex = 4;
            this.btn_renewSt.Text = "Làm mới";
            this.btn_renewSt.UseVisualStyleBackColor = false;
            // 
            // btn_deleteSt
            // 
            this.btn_deleteSt.BackColor = System.Drawing.Color.IndianRed;
            this.btn_deleteSt.FlatAppearance.BorderSize = 0;
            this.btn_deleteSt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteSt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_deleteSt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_deleteSt.Location = new System.Drawing.Point(12, 390);
            this.btn_deleteSt.Name = "btn_deleteSt";
            this.btn_deleteSt.Size = new System.Drawing.Size(124, 39);
            this.btn_deleteSt.TabIndex = 3;
            this.btn_deleteSt.Text = "Xóa";
            this.btn_deleteSt.UseVisualStyleBackColor = false;
            // 
            // btn_updateSt
            // 
            this.btn_updateSt.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_updateSt.FlatAppearance.BorderSize = 0;
            this.btn_updateSt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateSt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_updateSt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_updateSt.Location = new System.Drawing.Point(155, 345);
            this.btn_updateSt.Name = "btn_updateSt";
            this.btn_updateSt.Size = new System.Drawing.Size(124, 39);
            this.btn_updateSt.TabIndex = 2;
            this.btn_updateSt.Text = "Sửa";
            this.btn_updateSt.UseVisualStyleBackColor = false;
            // 
            // btn_addSt
            // 
            this.btn_addSt.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_addSt.FlatAppearance.BorderSize = 0;
            this.btn_addSt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addSt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_addSt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_addSt.Location = new System.Drawing.Point(10, 345);
            this.btn_addSt.Name = "btn_addSt";
            this.btn_addSt.Size = new System.Drawing.Size(124, 39);
            this.btn_addSt.TabIndex = 1;
            this.btn_addSt.Text = "Thêm";
            this.btn_addSt.UseVisualStyleBackColor = false;
            // 
            // box_Student
            // 
            this.box_Student.Controls.Add(this.splitter1);
            this.box_Student.Controls.Add(this.txt_Class);
            this.box_Student.Controls.Add(this.label5);
            this.box_Student.Controls.Add(this.txt_Gender);
            this.box_Student.Controls.Add(this.label4);
            this.box_Student.Controls.Add(this.txt_Birth);
            this.box_Student.Controls.Add(this.label3);
            this.box_Student.Controls.Add(this.txt_TenSV);
            this.box_Student.Controls.Add(this.label2);
            this.box_Student.Controls.Add(this.txt_MaSV);
            this.box_Student.Controls.Add(this.label1);
            this.box_Student.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.box_Student.Location = new System.Drawing.Point(0, 0);
            this.box_Student.Name = "box_Student";
            this.box_Student.Size = new System.Drawing.Size(285, 338);
            this.box_Student.TabIndex = 0;
            this.box_Student.TabStop = false;
            this.box_Student.Text = "Thông tin sinh viên";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(3, 332);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(279, 3);
            this.splitter1.TabIndex = 11;
            this.splitter1.TabStop = false;
            // 
            // txt_Class
            // 
            this.txt_Class.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txt_Class.FormattingEnabled = true;
            this.txt_Class.Location = new System.Drawing.Point(10, 247);
            this.txt_Class.Name = "txt_Class";
            this.txt_Class.Size = new System.Drawing.Size(269, 23);
            this.txt_Class.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.Location = new System.Drawing.Point(7, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Lớp:";
            // 
            // txt_Gender
            // 
            this.txt_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txt_Gender.FormattingEnabled = true;
            this.txt_Gender.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.txt_Gender.Location = new System.Drawing.Point(10, 197);
            this.txt_Gender.Name = "txt_Gender";
            this.txt_Gender.Size = new System.Drawing.Size(269, 23);
            this.txt_Gender.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(7, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Giới tính:";
            // 
            // txt_Birth
            // 
            this.txt_Birth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txt_Birth.Location = new System.Drawing.Point(10, 147);
            this.txt_Birth.Name = "txt_Birth";
            this.txt_Birth.Size = new System.Drawing.Size(269, 21);
            this.txt_Birth.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(7, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày sinh:";
            // 
            // txt_TenSV
            // 
            this.txt_TenSV.Location = new System.Drawing.Point(10, 97);
            this.txt_TenSV.Name = "txt_TenSV";
            this.txt_TenSV.Size = new System.Drawing.Size(269, 21);
            this.txt_TenSV.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(7, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ và tên:";
            // 
            // txt_MaSV
            // 
            this.txt_MaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txt_MaSV.Location = new System.Drawing.Point(10, 47);
            this.txt_MaSV.Name = "txt_MaSV";
            this.txt_MaSV.Size = new System.Drawing.Size(269, 21);
            this.txt_MaSV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên:";
            // 
            // btn_goLastSt
            // 
            this.btn_goLastSt.BackColor = System.Drawing.Color.Transparent;
            this.btn_goLastSt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_goLastSt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_goLastSt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_goLastSt.Location = new System.Drawing.Point(532, 402);
            this.btn_goLastSt.Name = "btn_goLastSt";
            this.btn_goLastSt.Size = new System.Drawing.Size(60, 60);
            this.btn_goLastSt.TabIndex = 9;
            this.btn_goLastSt.Text = ">>";
            this.btn_goLastSt.UseVisualStyleBackColor = false;
            // 
            // btn_goUpSt
            // 
            this.btn_goUpSt.BackColor = System.Drawing.Color.Transparent;
            this.btn_goUpSt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_goUpSt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_goUpSt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_goUpSt.Location = new System.Drawing.Point(466, 402);
            this.btn_goUpSt.Name = "btn_goUpSt";
            this.btn_goUpSt.Size = new System.Drawing.Size(60, 60);
            this.btn_goUpSt.TabIndex = 8;
            this.btn_goUpSt.Text = ">";
            this.btn_goUpSt.UseVisualStyleBackColor = false;
            // 
            // studentCount
            // 
            this.studentCount.AutoSize = true;
            this.studentCount.Location = new System.Drawing.Point(286, 426);
            this.studentCount.Name = "studentCount";
            this.studentCount.Size = new System.Drawing.Size(116, 13);
            this.studentCount.TabIndex = 7;
            this.studentCount.Text = "Đây là label phân trang";
            // 
            // btn_goBackSt
            // 
            this.btn_goBackSt.BackColor = System.Drawing.Color.Transparent;
            this.btn_goBackSt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_goBackSt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_goBackSt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_goBackSt.Location = new System.Drawing.Point(167, 402);
            this.btn_goBackSt.Name = "btn_goBackSt";
            this.btn_goBackSt.Size = new System.Drawing.Size(60, 60);
            this.btn_goBackSt.TabIndex = 6;
            this.btn_goBackSt.Text = "<";
            this.btn_goBackSt.UseVisualStyleBackColor = false;
            // 
            // btn_goFirstSt
            // 
            this.btn_goFirstSt.BackColor = System.Drawing.Color.Transparent;
            this.btn_goFirstSt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_goFirstSt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_goFirstSt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_goFirstSt.Location = new System.Drawing.Point(101, 402);
            this.btn_goFirstSt.Name = "btn_goFirstSt";
            this.btn_goFirstSt.Size = new System.Drawing.Size(60, 60);
            this.btn_goFirstSt.TabIndex = 5;
            this.btn_goFirstSt.Text = "<<";
            this.btn_goFirstSt.UseVisualStyleBackColor = false;
            // 
            // table_Student
            // 
            this.table_Student.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table_Student.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_Student.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.table_Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_Student.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.TenSV,
            this.Gender,
            this.birth,
            this.Class});
            this.table_Student.Location = new System.Drawing.Point(11, 80);
            this.table_Student.Name = "table_Student";
            this.table_Student.RowHeadersVisible = false;
            this.table_Student.Size = new System.Drawing.Size(662, 304);
            this.table_Student.TabIndex = 4;
            // 
            // MaSV
            // 
            this.MaSV.FillWeight = 65F;
            this.MaSV.HeaderText = "Mã SV";
            this.MaSV.Name = "MaSV";
            // 
            // TenSV
            // 
            this.TenSV.HeaderText = "Họ và Tên";
            this.TenSV.Name = "TenSV";
            // 
            // Gender
            // 
            this.Gender.FillWeight = 45F;
            this.Gender.HeaderText = "Giới Tính";
            this.Gender.Name = "Gender";
            // 
            // birth
            // 
            this.birth.FillWeight = 70F;
            this.birth.HeaderText = "Ngày Sinh";
            this.birth.Name = "birth";
            // 
            // Class
            // 
            this.Class.FillWeight = 35F;
            this.Class.HeaderText = "Lớp";
            this.Class.Name = "Class";
            // 
            // btn_searchSt
            // 
            this.btn_searchSt.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_searchSt.FlatAppearance.BorderSize = 0;
            this.btn_searchSt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchSt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_searchSt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_searchSt.Location = new System.Drawing.Point(304, 14);
            this.btn_searchSt.Name = "btn_searchSt";
            this.btn_searchSt.Size = new System.Drawing.Size(124, 39);
            this.btn_searchSt.TabIndex = 3;
            this.btn_searchSt.Text = "Tìm";
            this.btn_searchSt.UseVisualStyleBackColor = false;
            // 
            // txt_searchSt
            // 
            this.txt_searchSt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txt_searchSt.Location = new System.Drawing.Point(11, 22);
            this.txt_searchSt.Name = "txt_searchSt";
            this.txt_searchSt.Size = new System.Drawing.Size(277, 21);
            this.txt_searchSt.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label6.Location = new System.Drawing.Point(8, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tìm kiếm (Tên / Mã SV / Lớp):";
            // 
            // pnl_Class
            // 
            this.pnl_Class.Controls.Add(this.ctn_Class);
            this.pnl_Class.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Class.Location = new System.Drawing.Point(0, 24);
            this.pnl_Class.Name = "pnl_Class";
            this.pnl_Class.Size = new System.Drawing.Size(974, 488);
            this.pnl_Class.TabIndex = 2;
            // 
            // ctn_Class
            // 
            this.ctn_Class.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctn_Class.Location = new System.Drawing.Point(0, 0);
            this.ctn_Class.Name = "ctn_Class";
            // 
            // ctn_Class.Panel1
            // 
            this.ctn_Class.Panel1.Controls.Add(this.btn_viewCl);
            this.ctn_Class.Panel1.Controls.Add(this.btn_renewCl);
            this.ctn_Class.Panel1.Controls.Add(this.btn_deleteCl);
            this.ctn_Class.Panel1.Controls.Add(this.btn_updateCl);
            this.ctn_Class.Panel1.Controls.Add(this.btn_addCl);
            this.ctn_Class.Panel1.Controls.Add(this.groupBox1);
            // 
            // ctn_Class.Panel2
            // 
            this.ctn_Class.Panel2.Controls.Add(this.btn_goLastCl);
            this.ctn_Class.Panel2.Controls.Add(this.btn_goUpCl);
            this.ctn_Class.Panel2.Controls.Add(this.classCount);
            this.ctn_Class.Panel2.Controls.Add(this.btn_goBackCl);
            this.ctn_Class.Panel2.Controls.Add(this.btn_goFirstCl);
            this.ctn_Class.Panel2.Controls.Add(this.table_Class);
            this.ctn_Class.Panel2.Controls.Add(this.btn_searchCl);
            this.ctn_Class.Panel2.Controls.Add(this.txt_searchCl);
            this.ctn_Class.Panel2.Controls.Add(this.label13);
            this.ctn_Class.Size = new System.Drawing.Size(974, 488);
            this.ctn_Class.SplitterDistance = 285;
            this.ctn_Class.TabIndex = 0;
            // 
            // btn_viewCl
            // 
            this.btn_viewCl.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_viewCl.FlatAppearance.BorderSize = 0;
            this.btn_viewCl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewCl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_viewCl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_viewCl.Location = new System.Drawing.Point(12, 435);
            this.btn_viewCl.Name = "btn_viewCl";
            this.btn_viewCl.Size = new System.Drawing.Size(267, 39);
            this.btn_viewCl.TabIndex = 5;
            this.btn_viewCl.Text = "Xem danh sách sinh viên";
            this.btn_viewCl.UseVisualStyleBackColor = false;
            // 
            // btn_renewCl
            // 
            this.btn_renewCl.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_renewCl.FlatAppearance.BorderSize = 0;
            this.btn_renewCl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_renewCl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_renewCl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_renewCl.Location = new System.Drawing.Point(155, 390);
            this.btn_renewCl.Name = "btn_renewCl";
            this.btn_renewCl.Size = new System.Drawing.Size(124, 39);
            this.btn_renewCl.TabIndex = 4;
            this.btn_renewCl.Text = "Làm mới";
            this.btn_renewCl.UseVisualStyleBackColor = false;
            // 
            // btn_deleteCl
            // 
            this.btn_deleteCl.BackColor = System.Drawing.Color.IndianRed;
            this.btn_deleteCl.FlatAppearance.BorderSize = 0;
            this.btn_deleteCl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteCl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_deleteCl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_deleteCl.Location = new System.Drawing.Point(12, 390);
            this.btn_deleteCl.Name = "btn_deleteCl";
            this.btn_deleteCl.Size = new System.Drawing.Size(124, 39);
            this.btn_deleteCl.TabIndex = 3;
            this.btn_deleteCl.Text = "Xóa";
            this.btn_deleteCl.UseVisualStyleBackColor = false;
            // 
            // btn_updateCl
            // 
            this.btn_updateCl.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_updateCl.FlatAppearance.BorderSize = 0;
            this.btn_updateCl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateCl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_updateCl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_updateCl.Location = new System.Drawing.Point(155, 345);
            this.btn_updateCl.Name = "btn_updateCl";
            this.btn_updateCl.Size = new System.Drawing.Size(124, 39);
            this.btn_updateCl.TabIndex = 2;
            this.btn_updateCl.Text = "Sửa";
            this.btn_updateCl.UseVisualStyleBackColor = false;
            // 
            // btn_addCl
            // 
            this.btn_addCl.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_addCl.FlatAppearance.BorderSize = 0;
            this.btn_addCl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addCl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_addCl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_addCl.Location = new System.Drawing.Point(10, 345);
            this.btn_addCl.Name = "btn_addCl";
            this.btn_addCl.Size = new System.Drawing.Size(124, 39);
            this.btn_addCl.TabIndex = 1;
            this.btn_addCl.Text = "Thêm";
            this.btn_addCl.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Note);
            this.groupBox1.Controls.Add(this.txt_TenLop);
            this.groupBox1.Controls.Add(this.splitter2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_MaLop);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_MaID);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 338);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lớp học";
            // 
            // txt_Note
            // 
            this.txt_Note.Location = new System.Drawing.Point(10, 197);
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.Size = new System.Drawing.Size(269, 21);
            this.txt_Note.TabIndex = 13;
            // 
            // txt_TenLop
            // 
            this.txt_TenLop.Location = new System.Drawing.Point(10, 147);
            this.txt_TenLop.Name = "txt_TenLop";
            this.txt_TenLop.Size = new System.Drawing.Size(269, 21);
            this.txt_TenLop.TabIndex = 12;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter2.Location = new System.Drawing.Point(3, 332);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(279, 3);
            this.splitter2.TabIndex = 11;
            this.splitter2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label8.Location = new System.Drawing.Point(7, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ghi chú";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label9.Location = new System.Drawing.Point(7, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Tên lớp";
            // 
            // txt_MaLop
            // 
            this.txt_MaLop.Location = new System.Drawing.Point(10, 97);
            this.txt_MaLop.Name = "txt_MaLop";
            this.txt_MaLop.Size = new System.Drawing.Size(269, 21);
            this.txt_MaLop.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label10.Location = new System.Drawing.Point(7, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Mã lớp:";
            // 
            // txt_MaID
            // 
            this.txt_MaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txt_MaID.Location = new System.Drawing.Point(10, 47);
            this.txt_MaID.Name = "txt_MaID";
            this.txt_MaID.ReadOnly = true;
            this.txt_MaID.Size = new System.Drawing.Size(269, 21);
            this.txt_MaID.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label11.Location = new System.Drawing.Point(7, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Mã ID:";
            // 
            // btn_goLastCl
            // 
            this.btn_goLastCl.BackColor = System.Drawing.Color.Transparent;
            this.btn_goLastCl.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_goLastCl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_goLastCl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_goLastCl.Location = new System.Drawing.Point(532, 402);
            this.btn_goLastCl.Name = "btn_goLastCl";
            this.btn_goLastCl.Size = new System.Drawing.Size(60, 60);
            this.btn_goLastCl.TabIndex = 9;
            this.btn_goLastCl.Text = ">>";
            this.btn_goLastCl.UseVisualStyleBackColor = false;
            // 
            // btn_goUpCl
            // 
            this.btn_goUpCl.BackColor = System.Drawing.Color.Transparent;
            this.btn_goUpCl.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_goUpCl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_goUpCl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_goUpCl.Location = new System.Drawing.Point(466, 402);
            this.btn_goUpCl.Name = "btn_goUpCl";
            this.btn_goUpCl.Size = new System.Drawing.Size(60, 60);
            this.btn_goUpCl.TabIndex = 8;
            this.btn_goUpCl.Text = ">";
            this.btn_goUpCl.UseVisualStyleBackColor = false;
            // 
            // classCount
            // 
            this.classCount.AutoSize = true;
            this.classCount.Location = new System.Drawing.Point(286, 426);
            this.classCount.Name = "classCount";
            this.classCount.Size = new System.Drawing.Size(116, 13);
            this.classCount.TabIndex = 7;
            this.classCount.Text = "Đây là label phân trang";
            // 
            // btn_goBackCl
            // 
            this.btn_goBackCl.BackColor = System.Drawing.Color.Transparent;
            this.btn_goBackCl.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_goBackCl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_goBackCl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_goBackCl.Location = new System.Drawing.Point(167, 402);
            this.btn_goBackCl.Name = "btn_goBackCl";
            this.btn_goBackCl.Size = new System.Drawing.Size(60, 60);
            this.btn_goBackCl.TabIndex = 6;
            this.btn_goBackCl.Text = "<";
            this.btn_goBackCl.UseVisualStyleBackColor = false;
            // 
            // btn_goFirstCl
            // 
            this.btn_goFirstCl.BackColor = System.Drawing.Color.Transparent;
            this.btn_goFirstCl.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_goFirstCl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_goFirstCl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_goFirstCl.Location = new System.Drawing.Point(101, 402);
            this.btn_goFirstCl.Name = "btn_goFirstCl";
            this.btn_goFirstCl.Size = new System.Drawing.Size(60, 60);
            this.btn_goFirstCl.TabIndex = 5;
            this.btn_goFirstCl.Text = "<<";
            this.btn_goFirstCl.UseVisualStyleBackColor = false;
            // 
            // table_Class
            // 
            this.table_Class.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table_Class.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_Class.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.table_Class.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_Class.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaID,
            this.MaLop,
            this.TenLop,
            this.Note});
            this.table_Class.Location = new System.Drawing.Point(11, 80);
            this.table_Class.Name = "table_Class";
            this.table_Class.RowHeadersVisible = false;
            this.table_Class.Size = new System.Drawing.Size(662, 304);
            this.table_Class.TabIndex = 4;
            // 
            // MaID
            // 
            this.MaID.FillWeight = 30F;
            this.MaID.HeaderText = "Mã ID";
            this.MaID.Name = "MaID";
            // 
            // MaLop
            // 
            this.MaLop.FillWeight = 50F;
            this.MaLop.HeaderText = "Mã lớp";
            this.MaLop.Name = "MaLop";
            // 
            // TenLop
            // 
            this.TenLop.FillWeight = 50F;
            this.TenLop.HeaderText = "Tên lớp";
            this.TenLop.Name = "TenLop";
            // 
            // Note
            // 
            this.Note.HeaderText = "Ghi chú";
            this.Note.Name = "Note";
            // 
            // btn_searchCl
            // 
            this.btn_searchCl.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_searchCl.FlatAppearance.BorderSize = 0;
            this.btn_searchCl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchCl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_searchCl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_searchCl.Location = new System.Drawing.Point(304, 14);
            this.btn_searchCl.Name = "btn_searchCl";
            this.btn_searchCl.Size = new System.Drawing.Size(124, 39);
            this.btn_searchCl.TabIndex = 3;
            this.btn_searchCl.Text = "Tìm";
            this.btn_searchCl.UseVisualStyleBackColor = false;
            // 
            // txt_searchCl
            // 
            this.txt_searchCl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txt_searchCl.Location = new System.Drawing.Point(11, 22);
            this.txt_searchCl.Name = "txt_searchCl";
            this.txt_searchCl.Size = new System.Drawing.Size(277, 21);
            this.txt_searchCl.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label13.Location = new System.Drawing.Point(8, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(238, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "Tìm kiếm (Mã ID / Mã lớp / Tên lớp):";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 512);
            this.Controls.Add(this.pnl_Student);
            this.Controls.Add(this.pnl_Class);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Quản Lý Sinh Viên";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnl_Student.ResumeLayout(false);
            this.ctn_Student.Panel1.ResumeLayout(false);
            this.ctn_Student.Panel2.ResumeLayout(false);
            this.ctn_Student.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctn_Student)).EndInit();
            this.ctn_Student.ResumeLayout(false);
            this.box_Student.ResumeLayout(false);
            this.box_Student.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_Student)).EndInit();
            this.pnl_Class.ResumeLayout(false);
            this.ctn_Class.Panel1.ResumeLayout(false);
            this.ctn_Class.Panel2.ResumeLayout(false);
            this.ctn_Class.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctn_Class)).EndInit();
            this.ctn_Class.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_Class)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem QLSinhVienPage;
        private System.Windows.Forms.ToolStripMenuItem QLLopHocPage;
        private System.Windows.Forms.ToolStripMenuItem LogoutPage;
        private System.Windows.Forms.Panel pnl_Student;
        private System.Windows.Forms.SplitContainer ctn_Student;
        private System.Windows.Forms.GroupBox box_Student;
        private System.Windows.Forms.TextBox txt_TenSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txt_Birth;
        private System.Windows.Forms.ComboBox txt_Class;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txt_Gender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_renewSt;
        private System.Windows.Forms.Button btn_deleteSt;
        private System.Windows.Forms.Button btn_updateSt;
        private System.Windows.Forms.Button btn_addSt;
        private System.Windows.Forms.Splitter splitter1;
        private Label label6;
        private Button btn_searchSt;
        private TextBox txt_searchSt;
        private DataGridView table_Student;
        private DataGridViewTextBoxColumn MaSV;
        private DataGridViewTextBoxColumn TenSV;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn birth;
        private DataGridViewTextBoxColumn Class;
        private Button btn_goFirstSt;
        private Button btn_goLastSt;
        private Button btn_goUpSt;
        private Label studentCount;
        private Button btn_goBackSt;
        private Panel pnl_Class;
        private SplitContainer ctn_Class;
        private Button btn_renewCl;
        private Button btn_deleteCl;
        private Button btn_updateCl;
        private Button btn_addCl;
        private GroupBox groupBox1;
        private Splitter splitter2;
        private Label label8;
        private Label label9;
        private TextBox txt_MaLop;
        private Label label10;
        private TextBox txt_MaID;
        private Label label11;
        private Button btn_goLastCl;
        private Button btn_goUpCl;
        private Label classCount;
        private Button btn_goBackCl;
        private Button btn_goFirstCl;
        private DataGridView table_Class;
        private Button btn_searchCl;
        private TextBox txt_searchCl;
        private Label label13;
        private TextBox txt_Note;
        private TextBox txt_TenLop;
        private Button btn_viewCl;
        private DataGridViewTextBoxColumn MaID;
        private DataGridViewTextBoxColumn MaLop;
        private DataGridViewTextBoxColumn TenLop;
        private DataGridViewTextBoxColumn Note;
        private ColorDialog colorDialog1;
    }
}