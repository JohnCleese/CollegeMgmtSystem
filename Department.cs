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
    public partial class Department : Form
    {
        public Department()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ksawe\OneDrive\Dokumenty\collegedb.mdf;Integrated Security=True;Connect Timeout=30");

        private void Populate()
        {
            Con.Open();
            string query = "select * from DepartmentTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            departmentDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void AddDepartmentButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (depName.Text == "" || depDesc.Text == "" || depDuration.Text == "")
                {
                    MessageBox.Show("Do not leave blank fields!");
                }
                else
                {
                    Con.Open();
                    SqlCommand cmd = new($"insert into DepartmentTbl values('{depName.Text}','{depDesc.Text}','{depDuration.Text}')", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Department has been added successfully");
                    Con.Close();
                    Populate();
                }
            }
            catch
            {
                MessageBox.Show("Something happened");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void departmentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Department_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            MainForm home = new MainForm();
            home.Show();
            this.Hide();
        }

        private void EditDepartmentButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (depName.Text == "")
                {
                    MessageBox.Show("Enter department name to edit");
                }
                else
                {
                    Con.Open();
                    string query = $"update DepartmentTbl set DepDuration= '{depDuration.Text}',DepDesc= '{depDesc.Text}' where DepName= '{depName.Text}';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Department edited by name Successfully");
                    Con.Close();
                    Populate();
                }
            }
            catch
            {
                MessageBox.Show("Something happened");
            }
        }

        private void DeleteDepartmentButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (depName.Text == "")
                {
                    MessageBox.Show("Enter department name");
                }
                else
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand($"delete from DepartmentTbl where DepName='{depName.Text}';", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Department deleted by name successfully");
                    Con.Close();
                    Populate();
                }
            }
            catch
            {
                MessageBox.Show("Something happened");
            }
        }
    }
}
