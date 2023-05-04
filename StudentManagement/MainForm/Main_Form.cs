using System;
using System.Windows.Forms;
using StudentManagement.StudentForm;

namespace StudentManagement.MainForm
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm addStdF = new AddStudentForm();
            addStdF.Show(this);
        }

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentListForm stdLF = new StudentListForm();
            stdLF.Show(this);
        }

        private void editRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDeleteStudentForm updateDeleteStdF = new UpdateDeleteStudentForm();
            updateDeleteStdF.Show(this);
        }

        private void staticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticsForm staticsForm = new StaticsForm();
            staticsForm.Show(this);
        }

        private void manageStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageStudentForm manageStudentForm = new ManageStudentForm();
            manageStudentForm.Show(this);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintStudentForm printStdF = new PrintStudentForm();
            printStdF.Show(this);
        }
    }
}
