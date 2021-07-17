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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }
        SqlConnection Con = new(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ksawe\OneDrive\Dokumenty\collegedb.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "select * from StudentTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            studentDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void FillDepartment()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select DepName from DepartmentTbl", Con);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("DepName", typeof(string));
            dt.Load(rdr);
            studentDepartment.ValueMember = "DepName";
            studentDepartment.DataSource = dt;
            Con.Close();
        }

        private void AddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                if (studentId.Text == "" || studentName.Text == "" || studentPhone.Text == "")
                {
                    MessageBox.Show("Do not leave blank fields!");
                }
                else
                {
                    Con.Open();
                    SqlCommand cmd = new($"insert into StudentTbl values({Int64.Parse(studentId.Text)},'{studentName.Text}','{studentGender.SelectedItem.ToString()}','{studentDOB.Text}','{studentPhone.Text}','{studentDepartment.SelectedItem.ToString()}',{Int64.Parse(studentFee.Text)})", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student has been added successfully");
                    Con.Close();
                    populate();
                }
            }
            catch
            {
                MessageBox.Show("Something happened");
            }
        }

        private void DeleteStudent_Click(object sender, EventArgs e)
        {
            try
            {
                if (studentId.Text == "")
                {
                    MessageBox.Show("Enter student Id");
                }
                else
                {
                    Con.Open();
                    string query = $"delete from StudentTbl where Id={Int64.Parse(studentId.Text)};";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Deleted Successfully");
                    Con.Close();
                    populate();
                }
            }
            catch
            {
                MessageBox.Show("Something happened");
            }
        }

        private void Student_Load(object sender, EventArgs e)
        {
            FillDepartment();
            populate();
        }

        private void EditStudent_Click(object sender, EventArgs e)
        {
            try
            {
                if (studentId.Text == "")
                {
                    MessageBox.Show("Enter student Id to edit");
                }
                else
                {
                    Con.Open();
                    string query = $"update StudentTbl set StdName='{studentName.Text}',StdGender='{studentGender.Text}',StdDOB='{studentDOB.Text}',StdPhone='{studentPhone.Text}',StdDep='{studentDepartment.Text}',StdFees='{studentFee.Text}' where Id={Int64.Parse(studentId.Text)};";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student edited by id Successfully");
                    Con.Close();
                    populate();
                }
            }
            catch
            {
                MessageBox.Show("Something happened");
            }
        }

        private void Home_Click(object sender, EventArgs e)
        {
            MainForm home = new MainForm();
            home.Show();
            this.Hide();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
