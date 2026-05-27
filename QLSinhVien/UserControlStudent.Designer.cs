namespace QLSinhVien
{
    partial class UserControlStudent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btn_searchSt = new System.Windows.Forms.Button();
            this.txt_searchSt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ctn_Student)).BeginInit();
            this.ctn_Student.Panel1.SuspendLayout();
            this.ctn_Student.Panel2.SuspendLayout();
            this.ctn_Student.SuspendLayout();
            this.box_Student.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_Student)).BeginInit();
            this.SuspendLayout();
            // 
            // ctn_Student
            // 
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
            this.ctn_Student.Size = new System.Drawing.Size(974, 500);
            this.ctn_Student.SplitterDistance = 285;
            this.ctn_Student.TabIndex = 1;
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
            this.btn_renewSt.Click += new System.EventHandler(this.btn_renewSt_Click);
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
            this.btn_deleteSt.Click += new System.EventHandler(this.btn_deleteSt_Click);
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
            this.btn_updateSt.Click += new System.EventHandler(this.btn_updateSt_Click);
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
            this.btn_addSt.Click += new System.EventHandler(this.btn_addSt_Click);
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
            this.splitter1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
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
            this.btn_goLastSt.Location = new System.Drawing.Point(512, 402);
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
            this.btn_goUpSt.Location = new System.Drawing.Point(446, 402);
            this.btn_goUpSt.Name = "btn_goUpSt";
            this.btn_goUpSt.Size = new System.Drawing.Size(60, 60);
            this.btn_goUpSt.TabIndex = 8;
            this.btn_goUpSt.Text = ">";
            this.btn_goUpSt.UseVisualStyleBackColor = false;
            // 
            // studentCount
            // 
            this.studentCount.AutoSize = true;
            this.studentCount.Location = new System.Drawing.Point(266, 426);
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
            this.btn_goBackSt.Location = new System.Drawing.Point(147, 402);
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
            this.btn_goFirstSt.Location = new System.Drawing.Point(81, 402);
            this.btn_goFirstSt.Name = "btn_goFirstSt";
            this.btn_goFirstSt.Size = new System.Drawing.Size(60, 60);
            this.btn_goFirstSt.TabIndex = 5;
            this.btn_goFirstSt.Text = "<<";
            this.btn_goFirstSt.UseVisualStyleBackColor = false;
            // 
            // table_Student
            // 
            this.table_Student.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table_Student.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table_Student.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_Student.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.table_Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_Student.Location = new System.Drawing.Point(11, 80);
            this.table_Student.Name = "table_Student";
            this.table_Student.RowHeadersVisible = false;
            this.table_Student.Size = new System.Drawing.Size(639, 304);
            this.table_Student.TabIndex = 4;
            this.table_Student.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_Student_CellClick);
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
            this.btn_searchSt.Click += new System.EventHandler(this.btn_searchSt_Click);
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
            // UserControlStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctn_Student);
            this.Name = "UserControlStudent";
            this.Size = new System.Drawing.Size(954, 481);
            this.Load += new System.EventHandler(this.UserControlStudent_Load);
            this.ctn_Student.Panel1.ResumeLayout(false);
            this.ctn_Student.Panel2.ResumeLayout(false);
            this.ctn_Student.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctn_Student)).EndInit();
            this.ctn_Student.ResumeLayout(false);
            this.box_Student.ResumeLayout(false);
            this.box_Student.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_Student)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer ctn_Student;
        private System.Windows.Forms.Button btn_renewSt;
        private System.Windows.Forms.Button btn_deleteSt;
        private System.Windows.Forms.Button btn_updateSt;
        private System.Windows.Forms.Button btn_addSt;
        private System.Windows.Forms.GroupBox box_Student;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ComboBox txt_Class;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txt_Gender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txt_Birth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TenSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_goLastSt;
        private System.Windows.Forms.Button btn_goUpSt;
        private System.Windows.Forms.Label studentCount;
        private System.Windows.Forms.Button btn_goBackSt;
        private System.Windows.Forms.Button btn_goFirstSt;
        private System.Windows.Forms.DataGridView table_Student;
        private System.Windows.Forms.Button btn_searchSt;
        private System.Windows.Forms.TextBox txt_searchSt;
        private System.Windows.Forms.Label label6;
    }
}
