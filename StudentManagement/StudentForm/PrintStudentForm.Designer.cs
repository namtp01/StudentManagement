
namespace StudentManagement.StudentForm
{
    partial class PrintStudentForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.printBtn = new System.Windows.Forms.Button();
            this.allRBtn = new System.Windows.Forms.RadioButton();
            this.maleRBtn = new System.Windows.Forms.RadioButton();
            this.femaleRBtn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateBetweenLabel = new System.Windows.Forms.Label();
            this.useDateLabel = new System.Windows.Forms.Label();
            this.noRBtn = new System.Windows.Forms.RadioButton();
            this.yesRBtn = new System.Windows.Forms.RadioButton();
            this.goBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1062, 449);
            this.dataGridView1.TabIndex = 0;
            // 
            // printBtn
            // 
            this.printBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.printBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.printBtn.Location = new System.Drawing.Point(348, 585);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(468, 51);
            this.printBtn.TabIndex = 7;
            this.printBtn.Text = "Print To Text File";
            this.printBtn.UseVisualStyleBackColor = false;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // allRBtn
            // 
            this.allRBtn.AutoSize = true;
            this.allRBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allRBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.allRBtn.Location = new System.Drawing.Point(44, 41);
            this.allRBtn.Name = "allRBtn";
            this.allRBtn.Size = new System.Drawing.Size(55, 29);
            this.allRBtn.TabIndex = 8;
            this.allRBtn.TabStop = true;
            this.allRBtn.Text = "All";
            this.allRBtn.UseVisualStyleBackColor = true;
            // 
            // maleRBtn
            // 
            this.maleRBtn.AutoSize = true;
            this.maleRBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleRBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.maleRBtn.Location = new System.Drawing.Point(117, 41);
            this.maleRBtn.Name = "maleRBtn";
            this.maleRBtn.Size = new System.Drawing.Size(76, 29);
            this.maleRBtn.TabIndex = 8;
            this.maleRBtn.TabStop = true;
            this.maleRBtn.Text = "Male";
            this.maleRBtn.UseVisualStyleBackColor = true;
            // 
            // femaleRBtn
            // 
            this.femaleRBtn.AutoSize = true;
            this.femaleRBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleRBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.femaleRBtn.Location = new System.Drawing.Point(211, 41);
            this.femaleRBtn.Name = "femaleRBtn";
            this.femaleRBtn.Size = new System.Drawing.Size(98, 29);
            this.femaleRBtn.TabIndex = 8;
            this.femaleRBtn.TabStop = true;
            this.femaleRBtn.Text = "Female";
            this.femaleRBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DimGray;
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateBetweenLabel);
            this.groupBox1.Controls.Add(this.useDateLabel);
            this.groupBox1.Controls.Add(this.noRBtn);
            this.groupBox1.Controls.Add(this.yesRBtn);
            this.groupBox1.Location = new System.Drawing.Point(337, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 103);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.CustomFormat = "dd-mm-yyyy";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(417, 58);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(117, 26);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CustomFormat = "dd-mm-yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(214, 58);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(126, 26);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(351, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "And";
            // 
            // dateBetweenLabel
            // 
            this.dateBetweenLabel.AutoSize = true;
            this.dateBetweenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBetweenLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.dateBetweenLabel.Location = new System.Drawing.Point(6, 59);
            this.dateBetweenLabel.Name = "dateBetweenLabel";
            this.dateBetweenLabel.Size = new System.Drawing.Size(184, 25);
            this.dateBetweenLabel.TabIndex = 0;
            this.dateBetweenLabel.Text = "Birth Date Between:";
            // 
            // useDateLabel
            // 
            this.useDateLabel.AutoSize = true;
            this.useDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useDateLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.useDateLabel.Location = new System.Drawing.Point(6, 20);
            this.useDateLabel.Name = "useDateLabel";
            this.useDateLabel.Size = new System.Drawing.Size(161, 25);
            this.useDateLabel.TabIndex = 0;
            this.useDateLabel.Text = "Use Date Range:";
            // 
            // noRBtn
            // 
            this.noRBtn.AutoSize = true;
            this.noRBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noRBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.noRBtn.Location = new System.Drawing.Point(282, 18);
            this.noRBtn.Name = "noRBtn";
            this.noRBtn.Size = new System.Drawing.Size(58, 29);
            this.noRBtn.TabIndex = 8;
            this.noRBtn.TabStop = true;
            this.noRBtn.Text = "No";
            this.noRBtn.UseVisualStyleBackColor = true;
            this.noRBtn.CheckedChanged += new System.EventHandler(this.noRBtn_CheckedChanged);
            // 
            // yesRBtn
            // 
            this.yesRBtn.AutoSize = true;
            this.yesRBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesRBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.yesRBtn.Location = new System.Drawing.Point(193, 18);
            this.yesRBtn.Name = "yesRBtn";
            this.yesRBtn.Size = new System.Drawing.Size(67, 29);
            this.yesRBtn.TabIndex = 8;
            this.yesRBtn.TabStop = true;
            this.yesRBtn.Text = "Yes";
            this.yesRBtn.UseVisualStyleBackColor = true;
            this.yesRBtn.CheckedChanged += new System.EventHandler(this.yesRBtn_CheckedChanged);
            // 
            // goBtn
            // 
            this.goBtn.BackColor = System.Drawing.Color.Red;
            this.goBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.goBtn.Location = new System.Drawing.Point(922, 37);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(148, 58);
            this.goBtn.TabIndex = 10;
            this.goBtn.Text = "Go";
            this.goBtn.UseVisualStyleBackColor = false;
            this.goBtn.Click += new System.EventHandler(this.goBtn_Click);
            // 
            // PrintStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1147, 648);
            this.Controls.Add(this.goBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.femaleRBtn);
            this.Controls.Add(this.maleRBtn);
            this.Controls.Add(this.allRBtn);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PrintStudentForm";
            this.Text = "PrintStudentForm";
            this.Load += new System.EventHandler(this.PrintStudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.RadioButton allRBtn;
        private System.Windows.Forms.RadioButton maleRBtn;
        private System.Windows.Forms.RadioButton femaleRBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label dateBetweenLabel;
        private System.Windows.Forms.Label useDateLabel;
        private System.Windows.Forms.RadioButton noRBtn;
        private System.Windows.Forms.RadioButton yesRBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button goBtn;
    }
}