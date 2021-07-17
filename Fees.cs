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
    public partial class Fees : Form
    {
        public Fees()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ksawe\OneDrive\Dokumenty\collegedb.mdf;Integrated Security=True;Connect Timeout=30");
        private void Populate()
        {
            Con.Open();
            string query = "select * from FeesTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            feeDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void FillStudent()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select Id from StudentTbl", Con);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(string));
            dt.Load(rdr);
            feeStudent.ValueMember = "Id";
            feeStudent.DataSource = dt;
            Con.Close();
        }
        private void StudentNamer(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand($"select * from StudentTbl where Id='{feeStudent.Text}'", Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                feeName.Text = dr["StdName"].ToString();
            }
            Con.Close();
        }
        private void PayFee_Click(object sender, EventArgs e)
        {
            try
            {
                if (feeAmmount.Text == "" || feeStudent.Text == "" || feeName.Text == "" || feePeriod.Text == "")
                {
                    MessageBox.Show("Do not leave blank fields!");
                }
                else
                {
                    Con.Open();
                    SqlCommand cmd = new($"insert into FeesTbl values('{Int64.Parse(feeNum.Text)}','{feeStudent.SelectedItem}','{feeName.Text}','{feePeriod.Text}','{Int64.Parse(feeAmmount.Text)}')", Con);
                    cmd.ExecuteNonQuery();
                    SqlCommand cmd2 = new($"update StudentTbl set StdFees=StdFees-'{Int64.Parse(feeAmmount.Text)}' where Id={Int64.Parse(feeStudent.Text)}", Con);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Fee has been paid successfully");
                    Con.Close();
                    Populate();
                }
            }
            catch
            {
                MessageBox.Show("Something happened");
            }
        }

        private void Fees_Load(object sender, EventArgs e)
        {
            Populate();
            FillStudent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DeleteFee_Click(object sender, EventArgs e)
        {
            try
            {
                if (feeNum.Text == "" || feeStudent.Text == "")
                {
                    MessageBox.Show("Enter student Id and fee Num");
                }
                else
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand($"select FeeAmmount from FeesTbl where FeeNum='{feeNum.Text}'", Con);
                    SqlCommand cmd2 = new($"update StudentTbl set StdFees=StdFees+{cmd.ExecuteScalar()} where Id={Int64.Parse(feeStudent.Text)}", Con);
                    cmd2.ExecuteNonQuery();
                    SqlCommand cmd3 = new SqlCommand($"delete from FeesTbl where FeeNum='{Int64.Parse(feeNum.Text)}';", Con);
                    cmd3.ExecuteNonQuery();
                    MessageBox.Show("Fee payment Deleted Successfully");
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
