using System;
using StudentManagement.Entity;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace StudentManagement.StudentForm
{
    public partial class ManageStudentForm : Form
    {
        public ManageStudentForm()
        {
            InitializeComponent();
        }

        STUDENT student = new STUDENT();
        MY_DB conn = new MY_DB();

        private void ManageStudentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVDBDataSet.std' table. You can move, or remove it, as needed.
            //this.stdTableAdapter.Fill(this.qLSVDBDataSet.std);
            FillGrid(new SqlCommand("SELECT * FROM std"));
            totalLabel.Text = ("Total Students: " + dataGridView1.Rows.Count);
        }

        public void FillGrid(SqlCommand command)
        {
            //this.stdTableAdapter.Fill(this.qLSVDBDataSet.std);
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            // column 11 is position of the picture column in std
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[11];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtStudentId.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtFirstName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtLastName.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtMajor.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            dateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells[5].Value;

            txtCitizenId.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            if (dataGridView1.CurrentRow.Cells[7].Value.ToString() == "Female")
            {
                femaleRBtn.Checked = true;
            }
            else
            {
                maleRBtn.Checked = true;
            }
            txtEmail.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtPhone.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtAddress.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();

            byte[] pic;
            pic = (byte[])dataGridView1.CurrentRow.Cells[11].Value;
            MemoryStream picture = new MemoryStream(pic);
            StudentImagePictureBox.Image = Image.FromStream(picture);
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            txtStudentId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtMajor.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            txtCitizenId.Text = "";
            maleRBtn.Checked = true;
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            StudentImagePictureBox.Image = null;
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "SELECT Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                StudentImagePictureBox.Image = Image.FromFile(opf.FileName);
            }
        }

        private void downloadBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();

            svf.FileName = "Student_" + txtStudentId.Text;

            if (StudentImagePictureBox.Image == null)
            {
                MessageBox.Show("No Image In The PictureBox");
            }
            else if (svf.ShowDialog() == DialogResult.OK)
            {
                StudentImagePictureBox.Image.Save(svf.FileName + ("." + ImageFormat.Jpeg.ToString()));
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM std WHERE CONCAT(fname,lname,address) LIKE '%" + txtSearch.Text + "%'", conn.getConnection);
            FillGrid(command);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT();
            string sid = txtStudentId.Text;
            string fname = txtFirstName.Text;
            string lname = txtLastName.Text;
            string major = txtMajor.Text;
            DateTime bdate = dateTimePicker1.Value;
            string czid = txtCitizenId.Text;
            string gender = "Male";
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;

            if (femaleRBtn.Checked)
            {
                gender = "Female";
            }

            MemoryStream studentPic = new MemoryStream();
            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;

            if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
            {
                MessageBox.Show("The student age must be between 10 and 100 year", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
                StudentImagePictureBox.Image.Save(studentPic, StudentImagePictureBox.Image.RawFormat);
                if (student.insertStudent(sid, fname, lname, major, bdate, czid, gender, email, phone, address, studentPic))
                {
                    MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        bool verif()
        {
            if ((txtFirstName.Text.Trim() == "")
                || (txtLastName.Text.Trim() == "")
                || (txtMajor.Text.Trim() == "")
                || (txtCitizenId.Text.Trim() == "")
                || (txtEmail.Text.Trim() == "")
                || (txtPhone.Text.Trim() == "")
                || (txtAddress.Text.Trim() == "")
                || (StudentImagePictureBox.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT();
            string sid = txtStudentId.Text;
            string fname = txtFirstName.Text;
            string lname = txtLastName.Text;
            string major = txtMajor.Text;
            DateTime bdate = dateTimePicker1.Value;
            string czid = txtCitizenId.Text;
            string gender = "Male";
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;

            if (femaleRBtn.Checked)
            {
                gender = "Female";
            }

            MemoryStream studentPic = new MemoryStream();
            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;

            if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
            {
                MessageBox.Show("The student age must be between 10 and 100 year", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
                StudentImagePictureBox.Image.Save(studentPic, StudentImagePictureBox.Image.RawFormat);
                if (student.updateStudent(sid, fname, lname, major, bdate, czid, gender, email, phone, address, studentPic))
                {
                    MessageBox.Show("Student Information Updated", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            string sid = txtStudentId.Text;
            STUDENT student = new STUDENT();

            if (MessageBox.Show("Are You Sure You Want To Delete This Student", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (student.deleteStudent(sid))
                {
                    MessageBox.Show("Student Deleted", "Deleted Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtStudentId.Text = "";
                    txtFirstName.Text = "";
                    txtLastName.Text = "";
                    txtMajor.Text = "";
                    dateTimePicker1.Value = DateTime.Now;
                    txtCitizenId.Text = "";
                    txtEmail.Text = "";
                    txtPhone.Text = "";
                    txtAddress.Text = "";
                    StudentImagePictureBox.Image = null;
                }
                else
                {
                    MessageBox.Show("Student Not Deleted", "Deleted Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
