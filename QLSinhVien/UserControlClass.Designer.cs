namespace QLSinhVien
{
    partial class UserControlClass
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btn_searchCl = new System.Windows.Forms.Button();
            this.txt_searchCl = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ctn_Class)).BeginInit();
            this.ctn_Class.Panel1.SuspendLayout();
            this.ctn_Class.Panel2.SuspendLayout();
            this.ctn_Class.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_Class)).BeginInit();
            this.SuspendLayout();
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
            this.ctn_Class.Size = new System.Drawing.Size(987, 481);
            this.ctn_Class.SplitterDistance = 288;
            this.ctn_Class.TabIndex = 1;
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
            this.btn_viewCl.Click += new System.EventHandler(this.btn_viewCl_Click);
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
            this.btn_renewCl.Click += new System.EventHandler(this.btn_renewCl_Click);
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
            this.btn_deleteCl.Click += new System.EventHandler(this.btn_deleteCl_Click);
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
            this.btn_updateCl.Click += new System.EventHandler(this.btn_updateCl_Click);
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
            this.btn_addCl.Click += new System.EventHandler(this.btn_addCl_Click);
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
            this.txt_Note.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txt_Note.Location = new System.Drawing.Point(10, 197);
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.Size = new System.Drawing.Size(269, 21);
            this.txt_Note.TabIndex = 13;
            // 
            // txt_TenLop
            // 
            this.txt_TenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txt_TenLop.Location = new System.Drawing.Point(10, 147);
            this.txt_TenLop.Name = "txt_TenLop";
            this.txt_TenLop.Size = new System.Drawing.Size(269, 21);
            this.txt_TenLop.TabIndex = 12;
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.SystemColors.ControlDark;
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
            this.txt_MaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
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
            this.btn_goLastCl.Click += new System.EventHandler(this.btn_goLastCl_Click);
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
            this.btn_goUpCl.Click += new System.EventHandler(this.btn_goUpCl_Click);
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
            this.btn_goBackCl.Click += new System.EventHandler(this.btn_goBackCl_Click);
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
            this.btn_goFirstCl.Click += new System.EventHandler(this.btn_goFirstCl_Click);
            // 
            // table_Class
            // 
            this.table_Class.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table_Class.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_Class.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.table_Class.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_Class.Location = new System.Drawing.Point(11, 80);
            this.table_Class.Name = "table_Class";
            this.table_Class.RowHeadersVisible = false;
            this.table_Class.Size = new System.Drawing.Size(662, 304);
            this.table_Class.TabIndex = 4;
            this.table_Class.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_Class_CellClick);
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
            this.btn_searchCl.Click += new System.EventHandler(this.btn_searchCl_Click);
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
            // UserControlClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctn_Class);
            this.Name = "UserControlClass";
            this.Size = new System.Drawing.Size(987, 481);
            this.Load += new System.EventHandler(this.UserControlClass_Load);
            this.ctn_Class.Panel1.ResumeLayout(false);
            this.ctn_Class.Panel2.ResumeLayout(false);
            this.ctn_Class.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctn_Class)).EndInit();
            this.ctn_Class.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_Class)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer ctn_Class;
        private System.Windows.Forms.Button btn_viewCl;
        private System.Windows.Forms.Button btn_renewCl;
        private System.Windows.Forms.Button btn_deleteCl;
        private System.Windows.Forms.Button btn_updateCl;
        private System.Windows.Forms.Button btn_addCl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Note;
        private System.Windows.Forms.TextBox txt_TenLop;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_MaLop;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_MaID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_goLastCl;
        private System.Windows.Forms.Button btn_goUpCl;
        private System.Windows.Forms.Label classCount;
        private System.Windows.Forms.Button btn_goBackCl;
        private System.Windows.Forms.Button btn_goFirstCl;
        private System.Windows.Forms.DataGridView table_Class;
        private System.Windows.Forms.Button btn_searchCl;
        private System.Windows.Forms.TextBox txt_searchCl;
        private System.Windows.Forms.Label label13;
    }
}
