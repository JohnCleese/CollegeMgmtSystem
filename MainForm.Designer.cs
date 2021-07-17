
namespace CollegeMgmtSystemTutorial
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Student = new System.Windows.Forms.Button();
            this.Teachers = new System.Windows.Forms.Button();
            this.Department = new System.Windows.Forms.Button();
            this.Fees = new System.Windows.Forms.Button();
            this.Users = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.Label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 100);
            this.panel1.TabIndex = 0;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label2.Location = new System.Drawing.Point(637, 9);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(30, 32);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "X";
            this.Label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "College Management System";
            // 
            // Student
            // 
            this.Student.BackColor = System.Drawing.Color.Azure;
            this.Student.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Student.Location = new System.Drawing.Point(59, 165);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(126, 78);
            this.Student.TabIndex = 1;
            this.Student.Text = "Student";
            this.Student.UseVisualStyleBackColor = false;
            this.Student.Click += new System.EventHandler(this.Student_Click);
            // 
            // Teachers
            // 
            this.Teachers.BackColor = System.Drawing.Color.Azure;
            this.Teachers.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Teachers.Location = new System.Drawing.Point(259, 129);
            this.Teachers.Name = "Teachers";
            this.Teachers.Size = new System.Drawing.Size(126, 78);
            this.Teachers.TabIndex = 2;
            this.Teachers.Text = "Teachers";
            this.Teachers.UseVisualStyleBackColor = false;
            this.Teachers.Click += new System.EventHandler(this.Teachers_Click);
            // 
            // Department
            // 
            this.Department.BackColor = System.Drawing.Color.Azure;
            this.Department.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Department.Location = new System.Drawing.Point(46, 294);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(160, 78);
            this.Department.TabIndex = 3;
            this.Department.Text = "Department";
            this.Department.UseVisualStyleBackColor = false;
            this.Department.Click += new System.EventHandler(this.Department_Click);
            // 
            // Fees
            // 
            this.Fees.BackColor = System.Drawing.Color.Azure;
            this.Fees.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Fees.Location = new System.Drawing.Point(310, 265);
            this.Fees.Name = "Fees";
            this.Fees.Size = new System.Drawing.Size(160, 78);
            this.Fees.TabIndex = 4;
            this.Fees.Text = "Fees";
            this.Fees.UseVisualStyleBackColor = false;
            this.Fees.Click += new System.EventHandler(this.Fees_Click);
            // 
            // Users
            // 
            this.Users.BackColor = System.Drawing.Color.Azure;
            this.Users.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Users.Location = new System.Drawing.Point(498, 154);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(126, 78);
            this.Users.TabIndex = 5;
            this.Users.Text = "Users";
            this.Users.UseVisualStyleBackColor = false;
            this.Users.Click += new System.EventHandler(this.Users_Click);
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.Azure;
            this.Logout.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Logout.Location = new System.Drawing.Point(577, 394);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(106, 44);
            this.Logout.TabIndex = 6;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.BackgroundImage = global::CollegeMgmtSystemTutorial.Properties.Resources.cropped_fallon_michael_qmlGWIaIgpo_unsplash_scaled_1;
            this.ClientSize = new System.Drawing.Size(703, 450);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Users);
            this.Controls.Add(this.Fees);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.Teachers);
            this.Controls.Add(this.Student);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Student;
        private System.Windows.Forms.Button Teachers;
        private System.Windows.Forms.Button Department;
        private System.Windows.Forms.Button Fees;
        private System.Windows.Forms.Button Users;
        private System.Windows.Forms.Button Logout;
    }
}