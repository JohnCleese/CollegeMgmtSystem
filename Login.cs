using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CollegeMgmtSystemTutorial
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ksawe\OneDrive\Dokumenty\collegedb.mdf;Integrated Security=True;Connect Timeout=30");
            Con.Open();
            SqlCommand cmd = new SqlCommand($"select * from UserTbl where UserName='{userName.Text}' and UserPassword='{passWord.Text}'", Con);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                Con.Close();
                MainForm Mform = new MainForm();
                Mform.Show();
                this.Hide();
            }
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
