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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ksawe\OneDrive\Dokumenty\collegedb.mdf;Integrated Security=True;Connect Timeout=30");

        private void Users_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void Populate()
        {
            Con.Open();
            string query = "select * from UserTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            userDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(uidTb.Text=="" || unameTb.Text=="" || upassTb.Text == "")
                {
                    MessageBox.Show("Do not leave blank fields!");
                }
                else
                {
                    Con.Open();
                    SqlCommand cmd = new($"insert into UserTbl values({uidTb.Text},'{unameTb.Text}','{upassTb.Text}')", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User has been added successfully");
                    Con.Close();
                    Populate();
                }
            }
            catch
            {
                MessageBox.Show("Something happened");
            }
        }

        private void UserDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            uidTb.Text = userDGV.SelectedRows[0].Cells[0].Value.ToString();
            unameTb.Text = userDGV.SelectedRows[0].Cells[1].Value.ToString();
            upassTb.Text = userDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void Label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(uidTb.Text == "")
                {
                    MessageBox.Show("Enter user Id");
                }
                else
                {
                    Con.Open();
                    string query = $"delete from UserTbl where Id={uidTb.Text}";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Deleted Successfully");
                    Con.Close();
                    Populate();
                }
            }
            catch
            {
                MessageBox.Show("Something happened");
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (uidTb.Text == "")
                {
                    MessageBox.Show("Enter user Id to edit");
                }
                else
                {
                    Con.Open();
                    string query = $"update UserTbl set UserName='{unameTb.Text}',UserPassword='{upassTb.Text}' where Id={uidTb.Text};";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User edited by id Successfully");
                    Con.Close();
                    Populate();
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
    }
}
