namespace QLSinhVien
{
    partial class studentsInClassList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.table_StudentInClass = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ClassName = new System.Windows.Forms.Label();
            this.txt_StudentNumber = new System.Windows.Forms.Label();
            this.btn_renewCl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table_StudentInClass)).BeginInit();
            this.SuspendLayout();
            // 
            // table_StudentInClass
            // 
            this.table_StudentInClass.AllowUserToResizeColumns = false;
            this.table_StudentInClass.AllowUserToResizeRows = false;
            this.table_StudentInClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table_StudentInClass.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_StudentInClass.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.table_StudentInClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_StudentInClass.Location = new System.Drawing.Point(52, 84);
            this.table_StudentInClass.Name = "table_StudentInClass";
            this.table_StudentInClass.RowHeadersVisible = false;
            this.table_StudentInClass.Size = new System.Drawing.Size(662, 309);
            this.table_StudentInClass.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(49, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên Lớp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(49, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sĩ Số:";
            // 
            // txt_ClassName
            // 
            this.txt_ClassName.AutoSize = true;
            this.txt_ClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txt_ClassName.Location = new System.Drawing.Point(128, 15);
            this.txt_ClassName.Name = "txt_ClassName";
            this.txt_ClassName.Size = new System.Drawing.Size(46, 15);
            this.txt_ClassName.TabIndex = 8;
            this.txt_ClassName.Text = "MaLop";
            // 
            // txt_StudentNumber
            // 
            this.txt_StudentNumber.AutoSize = true;
            this.txt_StudentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txt_StudentNumber.Location = new System.Drawing.Point(128, 48);
            this.txt_StudentNumber.Name = "txt_StudentNumber";
            this.txt_StudentNumber.Size = new System.Drawing.Size(94, 15);
            this.txt_StudentNumber.TabIndex = 9;
            this.txt_StudentNumber.Text = "StudentNumber";
            // 
            // btn_renewCl
            // 
            this.btn_renewCl.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_renewCl.FlatAppearance.BorderSize = 0;
            this.btn_renewCl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_renewCl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_renewCl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_renewCl.Location = new System.Drawing.Point(319, 399);
            this.btn_renewCl.Name = "btn_renewCl";
            this.btn_renewCl.Size = new System.Drawing.Size(124, 39);
            this.btn_renewCl.TabIndex = 10;
            this.btn_renewCl.Text = "Đóng";
            this.btn_renewCl.UseVisualStyleBackColor = false;
            this.btn_renewCl.Click += new System.EventHandler(this.btn_renewCl_Click);
            // 
            // studentsInClassList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 450);
            this.Controls.Add(this.btn_renewCl);
            this.Controls.Add(this.txt_StudentNumber);
            this.Controls.Add(this.txt_ClassName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.table_StudentInClass);
            this.Name = "studentsInClassList";
            this.Text = "Danh sách sinh viên";
            ((System.ComponentModel.ISupportInitialize)(this.table_StudentInClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView table_StudentInClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_ClassName;
        private System.Windows.Forms.Label txt_StudentNumber;
        private System.Windows.Forms.Button btn_renewCl;
    }
}