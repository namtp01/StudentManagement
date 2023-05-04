using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using StudentManagement.Entity;
using System.IO;
using System.Drawing;

namespace StudentManagement.StudentForm
{
    public partial class StudentListForm : Form
    {
        public StudentListForm()
        {
            InitializeComponent();
        }

        STUDENT student = new STUDENT();

        private void StudentListForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVDBDataSet.std' table. You can move, or remove it, as needed.
            this.stdTableAdapter.Fill(this.qLSVDBDataSet.std);
            SqlCommand command = new SqlCommand("SELECT * FROM std");
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            // column 11 is position of the picture column in std
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[11];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            UpdateDeleteStudentForm updateDeleteStdF = new UpdateDeleteStudentForm();
            updateDeleteStdF.txtStudentId.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            updateDeleteStdF.txtFirstName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            updateDeleteStdF.txtLastName.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            updateDeleteStdF.txtMajor.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            updateDeleteStdF.dateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells[5].Value;
            updateDeleteStdF.txtCitizenId.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[7].Value.ToString() == "Female")
            {
                updateDeleteStdF.femaleRBtn.Checked = true;
            }
            else
            {
                updateDeleteStdF.maleRBtn.Checked = true;
            }
            updateDeleteStdF.txtEmail.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            updateDeleteStdF.txtPhone.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            updateDeleteStdF.txtAddress.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();

            byte[] pic;
            pic = (byte[])dataGridView1.CurrentRow.Cells[11].Value;
            MemoryStream picture = new MemoryStream(pic);
            updateDeleteStdF.StudentImagePictureBox.Image = Image.FromStream(picture);
            updateDeleteStdF.Show();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            this.stdTableAdapter.Fill(this.qLSVDBDataSet.std);
            SqlCommand command = new SqlCommand("SELECT * FROM std");
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            // column 11 is position of the picture column in std
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[11];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }
    }
}
