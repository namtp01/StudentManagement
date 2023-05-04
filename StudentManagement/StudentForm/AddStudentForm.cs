using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagement.Entity;

namespace StudentManagement.StudentForm
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
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

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
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

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "SELECT Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                StudentImagePictureBox.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
