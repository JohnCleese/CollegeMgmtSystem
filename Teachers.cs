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
    public partial class Teachers : Form
    {
        public Teachers()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ksawe\OneDrive\Dokumenty\collegedb.mdf;Integrated Security=True;Connect Timeout=30");

        private void Populate()
        {
            Con.Open();
            string query = "select * from TeacherTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            teacherDGV.DataSource = ds.Tables[0];
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
            depTeacher.ValueMember = "DepName";
            depTeacher.DataSource = dt;
            Con.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (teacherName.Text == "" || phoneTeacher.Text == "" || teacherId.Text == "")
                {
                    MessageBox.Show("Do not leave blank fields!");
                }
                else
                {
                    Con.Open();
                    SqlCommand cmd = new($"insert into TeacherTbl values({Int64.Parse(teacherId.Text)},'{teacherName.Text}','{genderTeacher.SelectedItem.ToString()}','{dateDobTeacher.Text}','{phoneTeacher.Text}','{depTeacher.SelectedItem.ToString()}','{adressTeacher.Text}')", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher has been added successfully");
                    Con.Close();
                    Populate();
                }
            }
            catch
            {
                MessageBox.Show("Something happened");
            }
        }

        private void Teachers_Load(object sender, EventArgs e)
        {
            FillDepartment();
            Populate();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EditTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                if (teacherId.Text == "")
                {
                    MessageBox.Show("Enter teacher Id to edit");
                }
                else
                {
                    Con.Open();
                    string query = $"update TeacherTbl set TeacherName='{teacherName.Text}',GenderTeacher='{genderTeacher.Text}',DateDOBTeacher='{dateDobTeacher.Text}',PhoneTeacher='{phoneTeacher.Text}',DepTeacher='{depTeacher.Text}',AddTeacher='{depTeacher.Text}' where Id={Int64.Parse(teacherId.Text)}";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher edited by id Successfully");
                    Con.Close();
                    Populate();
                }
            }
            catch
            {
                MessageBox.Show("Something happened");
            }
        }

        private void DeleteTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                if (teacherId.Text == "")
                {
                    MessageBox.Show("Enter teacher Id");
                }
                else
                {
                    Con.Open();
                    string query = $"delete from TeacherTbl where Id={Int64.Parse(teacherId.Text)}";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher Deleted Successfully");
                    Con.Close();
                    Populate();
                }
            }
            catch
            {
                MessageBox.Show("Something happened");
            }
        }

        private void TeacherDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            teacherId.Text = teacherDGV.SelectedRows[0].Cells[0].Value.ToString();
            teacherName.Text = teacherDGV.SelectedRows[0].Cells[1].Value.ToString();
            depTeacher.Text = teacherDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            MainForm home = new MainForm();
            home.Show();
            this.Hide();
        }
    }
}
