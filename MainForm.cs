using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeMgmtSystemTutorial
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Login Mform = new Login();
            Mform.Show();
            this.Hide();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Student_Click(object sender, EventArgs e)
        {
            Student Mform = new Student();
            Mform.Show();
            this.Hide();
        }

        private void Department_Click(object sender, EventArgs e)
        {
            Department Mform = new Department();
            Mform.Show();
            this.Hide();
        }

        private void Teachers_Click(object sender, EventArgs e)
        {
            Teachers Mform = new Teachers();
            Mform.Show();
            this.Hide();
        }

        private void Fees_Click(object sender, EventArgs e)
        {
            Fees Mform = new Fees();
            Mform.Show();
            this.Hide();
        }

        private void Users_Click(object sender, EventArgs e)
        {
            Users Mform = new Users();
            Mform.Show();
            this.Hide();
        }
    }
}
