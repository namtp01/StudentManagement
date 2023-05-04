using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using StudentManagement.Entity;

namespace StudentManagement.StudentForm
{
    public partial class StaticsForm : Form
    {
        public StaticsForm()
        {
            InitializeComponent();
        }

        Color panTotalColor;
        Color panMaleColor;
        Color panFemaleColor;
        private void StaticsForm_Load(object sender, EventArgs e)
        {
            panTotalColor = totalPanel.BackColor;
            panMaleColor = malePanel.BackColor;
            panFemaleColor = femalePanel.BackColor;


            STUDENT student = new STUDENT();
            double total = Convert.ToDouble(student.totalStudent());
            double totalMaleStudents = Convert.ToDouble(student.totalMaleStudent());
            double totalFemaleStudents = Convert.ToDouble(student.totalFemaleStudent());

            double malePercentage = totalMaleStudents * 100 / total;
            double femalePercentage = totalFemaleStudents * 100 / total;

            totalLabel.Text = ("Total Students: " + total.ToString());
            maleLabel.Text = ("Male: " + (malePercentage.ToString("0.00") + "%"));
            femaleLabel.Text = ("Female: " + (femalePercentage.ToString("0.00") + "%"));
        }

        private void maleLabel_MouseEnter(object sender, EventArgs e)
        {
            malePanel.BackColor = Color.White;
            maleLabel.ForeColor = panMaleColor;
        }

        private void femaleLabel_MouseEnter(object sender, EventArgs e)
        {
            femalePanel.BackColor = Color.White;
            femaleLabel.ForeColor = panFemaleColor;
        }

        private void maleLabel_MouseLeave(object sender, EventArgs e)
        {
            malePanel.BackColor = panMaleColor;
            maleLabel.ForeColor = Color.White;
        }

        private void femaleLabel_MouseLeave(object sender, EventArgs e)
        {
            femalePanel.BackColor = panFemaleColor;
            femaleLabel.ForeColor = Color.White;
        }

        private void totalLabel_MouseEnter(object sender, EventArgs e)
        {
            totalPanel.BackColor = Color.White;
            totalLabel.ForeColor = panTotalColor;
        }

        private void totalLabel_MouseLeave(object sender, EventArgs e)
        {
            totalPanel.BackColor = panTotalColor;
            totalLabel.ForeColor = Color.White;
        }
    }
}
