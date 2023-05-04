
using StudentManagement.MainForm;
using System;
using System.Windows.Forms;
namespace StudentManagement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            LoginForm loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Main_Form());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
