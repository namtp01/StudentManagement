using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using StudentManagement.Entity;
using System.Data.SqlClient;

namespace StudentManagement
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            userPictureBox.Image = Image.FromFile("../../images/user.jpg");
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            MY_DB conn = new MY_DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM login WHERE username=@user AND password=@pass", conn.getConnection);
            command.Parameters.Add("@user", SqlDbType.VarChar).Value = txtUsername.Text;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = txtPassword.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
