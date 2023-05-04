
namespace StudentManagement.StudentForm
{
    partial class ManageStudentForm
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
            this.components = new System.ComponentModel.Container();
            this.txtMajor = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.majorLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.studentIdLabel = new System.Windows.Forms.Label();
            this.femaleRBtn = new System.Windows.Forms.RadioButton();
            this.maleRBtn = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCitizenId = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.citizenIdLabel = new System.Windows.Forms.Label();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.StudentImagePictureBox = new System.Windows.Forms.PictureBox();
            this.pictureLabel = new System.Windows.Forms.Label();
            this.removeBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.downloadBtn = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.editBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.qLSVDBDataSet = new StudentManagement.QLSVDBDataSet();
            this.qLSVDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stdTableAdapter = new StudentManagement.QLSVDBDataSetTableAdapters.stdTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.StudentImagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMajor
            // 
            this.txtMajor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMajor.Location = new System.Drawing.Point(160, 148);
            this.txtMajor.Name = "txtMajor";
            this.txtMajor.Size = new System.Drawing.Size(282, 30);
            this.txtMajor.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(160, 104);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(282, 30);
            this.txtLastName.TabIndex = 7;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(160, 59);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(282, 30);
            this.txtFirstName.TabIndex = 8;
            // 
            // txtStudentId
            // 
            this.txtStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentId.Location = new System.Drawing.Point(160, 18);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(282, 30);
            this.txtStudentId.TabIndex = 9;
            // 
            // majorLabel
            // 
            this.majorLabel.AutoSize = true;
            this.majorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.majorLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.majorLabel.Location = new System.Drawing.Point(76, 151);
            this.majorLabel.Name = "majorLabel";
            this.majorLabel.Size = new System.Drawing.Size(67, 25);
            this.majorLabel.TabIndex = 2;
            this.majorLabel.Text = "Major:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.lastNameLabel.Location = new System.Drawing.Point(31, 107);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(112, 25);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.firstNameLabel.Location = new System.Drawing.Point(31, 62);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(112, 25);
            this.firstNameLabel.TabIndex = 4;
            this.firstNameLabel.Text = "First Name:";
            // 
            // studentIdLabel
            // 
            this.studentIdLabel.AutoSize = true;
            this.studentIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIdLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.studentIdLabel.Location = new System.Drawing.Point(33, 21);
            this.studentIdLabel.Name = "studentIdLabel";
            this.studentIdLabel.Size = new System.Drawing.Size(110, 25);
            this.studentIdLabel.TabIndex = 5;
            this.studentIdLabel.Text = "Student ID:";
            // 
            // femaleRBtn
            // 
            this.femaleRBtn.AutoSize = true;
            this.femaleRBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleRBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.femaleRBtn.Location = new System.Drawing.Point(269, 285);
            this.femaleRBtn.Name = "femaleRBtn";
            this.femaleRBtn.Size = new System.Drawing.Size(98, 29);
            this.femaleRBtn.TabIndex = 19;
            this.femaleRBtn.TabStop = true;
            this.femaleRBtn.Text = "Female";
            this.femaleRBtn.UseVisualStyleBackColor = true;
            // 
            // maleRBtn
            // 
            this.maleRBtn.AutoSize = true;
            this.maleRBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleRBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.maleRBtn.Location = new System.Drawing.Point(160, 285);
            this.maleRBtn.Name = "maleRBtn";
            this.maleRBtn.Size = new System.Drawing.Size(76, 29);
            this.maleRBtn.TabIndex = 20;
            this.maleRBtn.TabStop = true;
            this.maleRBtn.Text = "Male";
            this.maleRBtn.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(160, 196);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(282, 30);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(160, 375);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(282, 30);
            this.txtPhone.TabIndex = 15;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(160, 329);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(282, 30);
            this.txtEmail.TabIndex = 16;
            // 
            // txtCitizenId
            // 
            this.txtCitizenId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCitizenId.Location = new System.Drawing.Point(162, 243);
            this.txtCitizenId.Name = "txtCitizenId";
            this.txtCitizenId.Size = new System.Drawing.Size(282, 30);
            this.txtCitizenId.TabIndex = 17;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.phoneLabel.Location = new System.Drawing.Point(68, 378);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(75, 25);
            this.phoneLabel.TabIndex = 10;
            this.phoneLabel.Text = "Phone:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.emailLabel.Location = new System.Drawing.Point(77, 332);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(66, 25);
            this.emailLabel.TabIndex = 11;
            this.emailLabel.Text = "Email:";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.genderLabel.Location = new System.Drawing.Point(60, 287);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(83, 25);
            this.genderLabel.TabIndex = 12;
            this.genderLabel.Text = "Gender:";
            // 
            // citizenIdLabel
            // 
            this.citizenIdLabel.AutoSize = true;
            this.citizenIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citizenIdLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.citizenIdLabel.Location = new System.Drawing.Point(41, 246);
            this.citizenIdLabel.Name = "citizenIdLabel";
            this.citizenIdLabel.Size = new System.Drawing.Size(102, 25);
            this.citizenIdLabel.TabIndex = 13;
            this.citizenIdLabel.Text = "Citizen ID:";
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.birthdayLabel.Location = new System.Drawing.Point(39, 201);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(104, 25);
            this.birthdayLabel.TabIndex = 14;
            this.birthdayLabel.Text = "BIrth Date:";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(160, 420);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(282, 82);
            this.txtAddress.TabIndex = 22;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.addressLabel.Location = new System.Drawing.Point(52, 423);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(91, 25);
            this.addressLabel.TabIndex = 21;
            this.addressLabel.Text = "Address:";
            // 
            // StudentImagePictureBox
            // 
            this.StudentImagePictureBox.BackColor = System.Drawing.Color.Tan;
            this.StudentImagePictureBox.Location = new System.Drawing.Point(160, 512);
            this.StudentImagePictureBox.Name = "StudentImagePictureBox";
            this.StudentImagePictureBox.Size = new System.Drawing.Size(282, 184);
            this.StudentImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StudentImagePictureBox.TabIndex = 24;
            this.StudentImagePictureBox.TabStop = false;
            // 
            // pictureLabel
            // 
            this.pictureLabel.AutoSize = true;
            this.pictureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.pictureLabel.Location = new System.Drawing.Point(65, 512);
            this.pictureLabel.Name = "pictureLabel";
            this.pictureLabel.Size = new System.Drawing.Size(78, 25);
            this.pictureLabel.TabIndex = 23;
            this.pictureLabel.Text = "Picture:";
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.Color.Red;
            this.removeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.removeBtn.Location = new System.Drawing.Point(1253, 717);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(167, 69);
            this.removeBtn.TabIndex = 27;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.addBtn.Location = new System.Drawing.Point(489, 717);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(167, 69);
            this.addBtn.TabIndex = 26;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // uploadBtn
            // 
            this.uploadBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.uploadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.uploadBtn.Location = new System.Drawing.Point(160, 702);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(139, 41);
            this.uploadBtn.TabIndex = 25;
            this.uploadBtn.Text = "Upload";
            this.uploadBtn.UseVisualStyleBackColor = false;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // downloadBtn
            // 
            this.downloadBtn.BackColor = System.Drawing.Color.OliveDrab;
            this.downloadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.downloadBtn.Location = new System.Drawing.Point(305, 702);
            this.downloadBtn.Name = "downloadBtn";
            this.downloadBtn.Size = new System.Drawing.Size(137, 41);
            this.downloadBtn.TabIndex = 25;
            this.downloadBtn.Text = "Download";
            this.downloadBtn.UseVisualStyleBackColor = false;
            this.downloadBtn.Click += new System.EventHandler(this.downloadBtn_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.searchLabel.Location = new System.Drawing.Point(484, 42);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(225, 25);
            this.searchLabel.TabIndex = 5;
            this.searchLabel.Text = "Enter a Value to Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(743, 39);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(510, 30);
            this.txtSearch.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(489, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(931, 539);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.editBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.editBtn.Location = new System.Drawing.Point(758, 717);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(167, 69);
            this.editBtn.TabIndex = 26;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.resetBtn.Location = new System.Drawing.Point(1026, 717);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(167, 69);
            this.resetBtn.TabIndex = 26;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.DarkOrchid;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.searchBtn.Location = new System.Drawing.Point(1277, 34);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(113, 41);
            this.searchBtn.TabIndex = 25;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.BackColor = System.Drawing.Color.Crimson;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.totalLabel.Location = new System.Drawing.Point(1107, 646);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(313, 50);
            this.totalLabel.TabIndex = 23;
            this.totalLabel.Text = "Total Students:";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // qLSVDBDataSet
            // 
            this.qLSVDBDataSet.DataSetName = "QLSVDBDataSet";
            this.qLSVDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLSVDBDataSetBindingSource
            // 
            this.qLSVDBDataSetBindingSource.DataSource = this.qLSVDBDataSet;
            this.qLSVDBDataSetBindingSource.Position = 0;
            // 
            // stdBindingSource
            // 
            this.stdBindingSource.DataMember = "std";
            this.stdBindingSource.DataSource = this.qLSVDBDataSetBindingSource;
            // 
            // stdTableAdapter
            // 
            this.stdTableAdapter.ClearBeforeFill = true;
            // 
            // ManageStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1432, 815);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.downloadBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.uploadBtn);
            this.Controls.Add(this.StudentImagePictureBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.pictureLabel);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.femaleRBtn);
            this.Controls.Add(this.maleRBtn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCitizenId);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.citizenIdLabel);
            this.Controls.Add(this.birthdayLabel);
            this.Controls.Add(this.txtMajor);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.majorLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.studentIdLabel);
            this.Name = "ManageStudentForm";
            this.Text = "ManageStudentForm";
            this.Load += new System.EventHandler(this.ManageStudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentImagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMajor;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Label majorLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label studentIdLabel;
        private System.Windows.Forms.RadioButton femaleRBtn;
        private System.Windows.Forms.RadioButton maleRBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCitizenId;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label citizenIdLabel;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.PictureBox StudentImagePictureBox;
        private System.Windows.Forms.Label pictureLabel;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.Button downloadBtn;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.BindingSource qLSVDBDataSetBindingSource;
        private QLSVDBDataSet qLSVDBDataSet;
        private System.Windows.Forms.BindingSource stdBindingSource;
        private QLSVDBDataSetTableAdapters.stdTableAdapter stdTableAdapter;
    }
}