
namespace CollegeMgmtSystemTutorial
{
    partial class Teachers
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
            this.DeleteTeacher = new System.Windows.Forms.Button();
            this.EditTeacher = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.teacherDGV = new System.Windows.Forms.DataGridView();
            this.adressTeacher = new System.Windows.Forms.TextBox();
            this.phoneTeacher = new System.Windows.Forms.TextBox();
            this.dateDobTeacher = new System.Windows.Forms.DateTimePicker();
            this.genderTeacher = new System.Windows.Forms.ComboBox();
            this.teacherName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Home = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.teacherId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.depTeacher = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.teacherDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeleteTeacher
            // 
            this.DeleteTeacher.BackColor = System.Drawing.Color.Azure;
            this.DeleteTeacher.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteTeacher.Location = new System.Drawing.Point(231, 483);
            this.DeleteTeacher.Name = "DeleteTeacher";
            this.DeleteTeacher.Size = new System.Drawing.Size(104, 42);
            this.DeleteTeacher.TabIndex = 41;
            this.DeleteTeacher.Text = "Delete";
            this.DeleteTeacher.UseVisualStyleBackColor = false;
            this.DeleteTeacher.Click += new System.EventHandler(this.DeleteTeacher_Click);
            // 
            // EditTeacher
            // 
            this.EditTeacher.BackColor = System.Drawing.Color.Azure;
            this.EditTeacher.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditTeacher.Location = new System.Drawing.Point(121, 483);
            this.EditTeacher.Name = "EditTeacher";
            this.EditTeacher.Size = new System.Drawing.Size(104, 42);
            this.EditTeacher.TabIndex = 40;
            this.EditTeacher.Text = "Edit";
            this.EditTeacher.UseVisualStyleBackColor = false;
            this.EditTeacher.Click += new System.EventHandler(this.EditTeacher_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Azure;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddButton.Location = new System.Drawing.Point(11, 483);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(104, 42);
            this.AddButton.TabIndex = 39;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // teacherDGV
            // 
            this.teacherDGV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.teacherDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacherDGV.Location = new System.Drawing.Point(434, 119);
            this.teacherDGV.Name = "teacherDGV";
            this.teacherDGV.RowTemplate.Height = 25;
            this.teacherDGV.Size = new System.Drawing.Size(493, 354);
            this.teacherDGV.TabIndex = 38;
            this.teacherDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TeacherDGV_CellContentClick);
            // 
            // adressTeacher
            // 
            this.adressTeacher.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adressTeacher.Location = new System.Drawing.Point(166, 438);
            this.adressTeacher.Name = "adressTeacher";
            this.adressTeacher.Size = new System.Drawing.Size(242, 39);
            this.adressTeacher.TabIndex = 37;
            // 
            // phoneTeacher
            // 
            this.phoneTeacher.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneTeacher.Location = new System.Drawing.Point(166, 331);
            this.phoneTeacher.Name = "phoneTeacher";
            this.phoneTeacher.Size = new System.Drawing.Size(242, 39);
            this.phoneTeacher.TabIndex = 33;
            // 
            // dateDobTeacher
            // 
            this.dateDobTeacher.CalendarFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateDobTeacher.Location = new System.Drawing.Point(166, 292);
            this.dateDobTeacher.Name = "dateDobTeacher";
            this.dateDobTeacher.Size = new System.Drawing.Size(200, 23);
            this.dateDobTeacher.TabIndex = 30;
            // 
            // genderTeacher
            // 
            this.genderTeacher.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genderTeacher.FormattingEnabled = true;
            this.genderTeacher.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderTeacher.Location = new System.Drawing.Point(166, 228);
            this.genderTeacher.Name = "genderTeacher";
            this.genderTeacher.Size = new System.Drawing.Size(242, 40);
            this.genderTeacher.TabIndex = 29;
            // 
            // teacherName
            // 
            this.teacherName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teacherName.Location = new System.Drawing.Point(166, 176);
            this.teacherName.Name = "teacherName";
            this.teacherName.Size = new System.Drawing.Size(242, 39);
            this.teacherName.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 531);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(939, 27);
            this.panel2.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.Home);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 100);
            this.panel1.TabIndex = 22;
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
            this.label3.Size = new System.Drawing.Size(101, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Teacher";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(897, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(12, 441);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 32);
            this.label10.TabIndex = 36;
            this.label10.Text = "Adress";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(12, 381);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 32);
            this.label9.TabIndex = 34;
            this.label9.Text = "Department";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(12, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 32);
            this.label8.TabIndex = 32;
            this.label8.Text = "Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(11, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 32);
            this.label7.TabIndex = 31;
            this.label7.Text = "Dob";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(11, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 32);
            this.label6.TabIndex = 28;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(12, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 32);
            this.label5.TabIndex = 26;
            this.label5.Text = "Name";
            // 
            // teacherId
            // 
            this.teacherId.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teacherId.Location = new System.Drawing.Point(166, 119);
            this.teacherId.Name = "teacherId";
            this.teacherId.Size = new System.Drawing.Size(242, 39);
            this.teacherId.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 32);
            this.label4.TabIndex = 24;
            this.label4.Text = "Id";
            // 
            // depTeacher
            // 
            this.depTeacher.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.depTeacher.FormattingEnabled = true;
            this.depTeacher.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.depTeacher.Location = new System.Drawing.Point(166, 381);
            this.depTeacher.Name = "depTeacher";
            this.depTeacher.Size = new System.Drawing.Size(242, 40);
            this.depTeacher.TabIndex = 42;
            // 
            // Teachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(939, 558);
            this.Controls.Add(this.depTeacher);
            this.Controls.Add(this.DeleteTeacher);
            this.Controls.Add(this.EditTeacher);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.teacherDGV);
            this.Controls.Add(this.adressTeacher);
            this.Controls.Add(this.phoneTeacher);
            this.Controls.Add(this.dateDobTeacher);
            this.Controls.Add(this.genderTeacher);
            this.Controls.Add(this.teacherName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.teacherId);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Teachers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teachers";
            this.Load += new System.EventHandler(this.Teachers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teacherDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteTeacher;
        private System.Windows.Forms.Button EditTeacher;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView teacherDGV;
        private System.Windows.Forms.TextBox adressTeacher;
        private System.Windows.Forms.TextBox phoneTeacher;
        private System.Windows.Forms.DateTimePicker dateDobTeacher;
        private System.Windows.Forms.ComboBox genderTeacher;
        private System.Windows.Forms.TextBox teacherName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox teacherId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox depTeacher;
    }
}