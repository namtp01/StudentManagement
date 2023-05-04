using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using StudentManagement.Entity;
using System.IO;
using System.Data.SqlClient;

namespace StudentManagement.StudentForm
{
    public partial class UpdateDeleteStudentForm : Form
    {
        public UpdateDeleteStudentForm()
        {
            InitializeComponent();
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

        private void removeBtn_Click(object sender, EventArgs e)
        {
            string sid = txtStudentId.Text;
            STUDENT student = new STUDENT();

            if (MessageBox.Show("Are You Sure You Want To Delete This Student","Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        private void findBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MY_DB conn = new MY_DB();
                STUDENT student = new STUDENT();
                string sid = txtStudentId.Text;
                SqlCommand command = new SqlCommand("SELECT studentId, fname, lname, major, bdate, citizenId, gender, email, phone, address, picture FROM std WHERE studentId='" + sid + "' ", conn.getConnection);
                DataTable table = student.getStudents(command);

                if (table.Rows.Count > 0)
                {
                    txtFirstName.Text = table.Rows[0]["fname"].ToString();
                    txtFirstName.Text = table.Rows[0]["lname"].ToString();
                    txtFirstName.Text = table.Rows[0]["major"].ToString();
                    txtFirstName.Text = table.Rows[0]["citizenId"].ToString();
                    txtFirstName.Text = table.Rows[0]["email"].ToString();
                    txtFirstName.Text = table.Rows[0]["phone"].ToString();
                    txtFirstName.Text = table.Rows[0]["address"].ToString();
                    dateTimePicker1.Value = (DateTime)table.Rows[0]["bdate"];

                    if (table.Rows[0]["gender"].ToString() == "Female")
                    {
                        femaleRBtn.Checked = true;
                    }
                    else
                    {
                        maleRBtn.Checked = true;
                    }

                    byte[] pic = (byte[])table.Rows[0]["picture"];
                    MemoryStream picture = new MemoryStream(pic);
                    StudentImagePictureBox.Image = Image.FromStream(picture);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Enter a Valid String", "Invalid String", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
