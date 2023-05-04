using System;
using StudentManagement.Entity;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace StudentManagement.StudentForm
{
    public partial class PrintStudentForm : Form
    {
        public PrintStudentForm()
        {
            InitializeComponent();
        }

        STUDENT student = new STUDENT();

        private void PrintStudentForm_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("SELECT * FROM std"));
            
            if (noRBtn.Checked)
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
        }

        public void fillGrid(SqlCommand command)
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

        private void noRBtn_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }

        private void yesRBtn_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
        }

        private void goBtn_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            string query;

            if (yesRBtn.Checked)
            {
                string date1 = dateTimePicker1.Value.ToString("dd-mm-yyyy");
                string date2 = dateTimePicker2.Value.ToString("dd-mm-yyyy");

                if (maleRBtn.Checked)
                {
                    query = "SELECT * FROM std WHERE bdate BETWEEN '" + date1 + "' AND '" + date2 + "' AND gender='Male'";
                }
                else if (femaleRBtn.Checked)
                {
                    query = "SELECT * FROM std WHERE bdate BETWEEN '" + date1 + "' AND '" + date2 + "' AND gender='Female'";
                }
                else
                {
                    query = "SELECT * FROM std WHERE bdate BETWEEN '" + date1 + "' AND '" + date2 + "'";
                }

                command = new SqlCommand(query);
                fillGrid(command);
            }

            else
            {
                if (maleRBtn.Checked)
                {
                    query = "SELECT * FROM std WHERE gender='Male'";
                }
                else if (femaleRBtn.Checked)
                {
                    query = "SELECT * FROM std WHERE gender='Female'";
                }
                else
                {
                    query = "SELECT * FROM std";
                }

                command = new SqlCommand(query);
                fillGrid(command);
            }
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\student_list.txt";

            using (var writer = new StreamWriter(path))
            {
                if (!File.Exists(path))
                {
                    File.Create(path);
                }

                DateTime bdate;

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count - 1; j++)
                    {
                        if (j==5)
                        {
                            bdate = Convert.ToDateTime(dataGridView1.Rows[i].Cells[j].Value.ToString());
                            writer.Write("\t" + bdate.ToString("dd-mm-yyyy") + "\t" + "|");
                        }
                        else if (j == dataGridView1.Columns.Count - 3)
                        {
                            writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString());
                        }
                        else
                        {
                            writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                        }
                    }
                    writer.WriteLine("");
                }

                writer.Close();
                MessageBox.Show("Data Exported");
            }
        }
    }
}
