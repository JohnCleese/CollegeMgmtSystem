
namespace CollegeMgmtSystemTutorial
{
    partial class Student
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
            this.Label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Home = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.studentId = new System.Windows.Forms.TextBox();
            this.studentName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.studentGender = new System.Windows.Forms.ComboBox();
            this.studentDOB = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.studentPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.studentFee = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.studentDGV = new System.Windows.Forms.DataGridView();
            this.AddStudent = new System.Windows.Forms.Button();
            this.EditStudent = new System.Windows.Forms.Button();
            this.DeleteStudent = new System.Windows.Forms.Button();
            this.studentDepartment = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label2.Location = new System.Drawing.Point(897, 9);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.Home);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 100);
            this.panel1.TabIndex = 1;
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Azure;
            this.Home.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Home.Location = new System.Drawing.Point(434, 43);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(104, 42);
            this.Home.TabIndex = 22;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Student";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 531);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(939, 27);
            this.panel2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Id";
            // 
            // studentId
            // 
            this.studentId.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.studentId.Location = new System.Drawing.Point(166, 119);
            this.studentId.Name = "studentId";
            this.studentId.Size = new System.Drawing.Size(242, 39);
            this.studentId.TabIndex = 5;
            // 
            // studentName
            // 
            this.studentName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.studentName.Location = new System.Drawing.Point(166, 176);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(242, 39);
            this.studentName.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(12, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(11, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 32);
            this.label6.TabIndex = 8;
            this.label6.Text = "Gender";
            // 
            // studentGender
            // 
            this.studentGender.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.studentGender.FormattingEnabled = true;
            this.studentGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.studentGender.Location = new System.Drawing.Point(166, 228);
            this.studentGender.Name = "studentGender";
            this.studentGender.Size = new System.Drawing.Size(242, 40);
            this.studentGender.TabIndex = 9;
            // 
            // studentDOB
            // 
            this.studentDOB.CalendarFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.studentDOB.Location = new System.Drawing.Point(166, 292);
            this.studentDOB.Name = "studentDOB";
            this.studentDOB.Size = new System.Drawing.Size(200, 23);
            this.studentDOB.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(11, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 32);
            this.label7.TabIndex = 11;
            this.label7.Text = "Dob";
            // 
            // studentPhone
            // 
            this.studentPhone.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.studentPhone.Location = new System.Drawing.Point(166, 331);
            this.studentPhone.Name = "studentPhone";
            this.studentPhone.Size = new System.Drawing.Size(242, 39);
            this.studentPhone.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(12, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 32);
            this.label8.TabIndex = 12;
            this.label8.Text = "Phone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(12, 381);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 32);
            this.label9.TabIndex = 14;
            this.label9.Text = "Department";
            // 
            // studentFee
            // 
            this.studentFee.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.studentFee.Location = new System.Drawing.Point(166, 438);
            this.studentFee.Name = "studentFee";
            this.studentFee.Size = new System.Drawing.Size(242, 39);
            this.studentFee.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(12, 441);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 32);
            this.label10.TabIndex = 16;
            this.label10.Text = "Fees";
            // 
            // studentDGV
            // 
            this.studentDGV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.studentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDGV.Location = new System.Drawing.Point(434, 119);
            this.studentDGV.Name = "studentDGV";
            this.studentDGV.RowTemplate.Height = 25;
            this.studentDGV.Size = new System.Drawing.Size(493, 354);
            this.studentDGV.TabIndex = 18;
            // 
            // AddStudent
            // 
            this.AddStudent.BackColor = System.Drawing.Color.Azure;
            this.AddStudent.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddStudent.Location = new System.Drawing.Point(11, 483);
            this.AddStudent.Name = "AddStudent";
            this.AddStudent.Size = new System.Drawing.Size(104, 42);
            this.AddStudent.TabIndex = 19;
            this.AddStudent.Text = "Add";
            this.AddStudent.UseVisualStyleBackColor = false;
            this.AddStudent.Click += new System.EventHandler(this.AddStudent_Click);
            // 
            // EditStudent
            // 
            this.EditStudent.BackColor = System.Drawing.Color.Azure;
            this.EditStudent.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditStudent.Location = new System.Drawing.Point(121, 483);
            this.EditStudent.Name = "EditStudent";
            this.EditStudent.Size = new System.Drawing.Size(104, 42);
            this.EditStudent.TabIndex = 20;
            this.EditStudent.Text = "Edit";
            this.EditStudent.UseVisualStyleBackColor = false;
            this.EditStudent.Click += new System.EventHandler(this.EditStudent_Click);
            // 
            // DeleteStudent
            // 
            this.DeleteStudent.BackColor = System.Drawing.Color.Azure;
            this.DeleteStudent.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteStudent.Location = new System.Drawing.Point(231, 483);
            this.DeleteStudent.Name = "DeleteStudent";
            this.DeleteStudent.Size = new System.Drawing.Size(104, 42);
            this.DeleteStudent.TabIndex = 21;
            this.DeleteStudent.Text = "Delete";
            this.DeleteStudent.UseVisualStyleBackColor = false;
            this.DeleteStudent.Click += new System.EventHandler(this.DeleteStudent_Click);
            // 
            // studentDepartment
            // 
            this.studentDepartment.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.studentDepartment.FormattingEnabled = true;
            this.studentDepartment.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.studentDepartment.Location = new System.Drawing.Point(166, 378);
            this.studentDepartment.Name = "studentDepartment";
            this.studentDepartment.Size = new System.Drawing.Size(242, 40);
            this.studentDepartment.TabIndex = 22;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(939, 558);
            this.Controls.Add(this.studentDepartment);
            this.Controls.Add(this.DeleteStudent);
            this.Controls.Add(this.EditStudent);
            this.Controls.Add(this.AddStudent);
            this.Controls.Add(this.studentDGV);
            this.Controls.Add(this.studentFee);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.studentPhone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.studentDOB);
            this.Controls.Add(this.studentGender);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.studentName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.studentId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Student";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox studentId;
        private System.Windows.Forms.TextBox studentName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox studentGender;
        private System.Windows.Forms.DateTimePicker studentDOB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox studentPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox studentFee;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView studentDGV;
        private System.Windows.Forms.Button AddStudent;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button EditStudent;
        private System.Windows.Forms.Button DeleteStudent;
        private System.Windows.Forms.ComboBox studentDepartment;
    }
}