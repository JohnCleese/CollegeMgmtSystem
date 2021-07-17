
namespace CollegeMgmtSystemTutorial
{
    partial class Department
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
            this.DeleteDepartmentButton = new System.Windows.Forms.Button();
            this.EditDepartmentButton = new System.Windows.Forms.Button();
            this.AddDepartmentButton = new System.Windows.Forms.Button();
            this.departmentDGV = new System.Windows.Forms.DataGridView();
            this.depDuration = new System.Windows.Forms.TextBox();
            this.depDesc = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Home = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.depName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.departmentDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeleteDepartmentButton
            // 
            this.DeleteDepartmentButton.BackColor = System.Drawing.Color.Azure;
            this.DeleteDepartmentButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteDepartmentButton.Location = new System.Drawing.Point(229, 480);
            this.DeleteDepartmentButton.Name = "DeleteDepartmentButton";
            this.DeleteDepartmentButton.Size = new System.Drawing.Size(104, 42);
            this.DeleteDepartmentButton.TabIndex = 61;
            this.DeleteDepartmentButton.Text = "Delete";
            this.DeleteDepartmentButton.UseVisualStyleBackColor = false;
            this.DeleteDepartmentButton.Click += new System.EventHandler(this.DeleteDepartmentButton_Click);
            // 
            // EditDepartmentButton
            // 
            this.EditDepartmentButton.BackColor = System.Drawing.Color.Azure;
            this.EditDepartmentButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditDepartmentButton.Location = new System.Drawing.Point(119, 480);
            this.EditDepartmentButton.Name = "EditDepartmentButton";
            this.EditDepartmentButton.Size = new System.Drawing.Size(104, 42);
            this.EditDepartmentButton.TabIndex = 60;
            this.EditDepartmentButton.Text = "Edit";
            this.EditDepartmentButton.UseVisualStyleBackColor = false;
            this.EditDepartmentButton.Click += new System.EventHandler(this.EditDepartmentButton_Click);
            // 
            // AddDepartmentButton
            // 
            this.AddDepartmentButton.BackColor = System.Drawing.Color.Azure;
            this.AddDepartmentButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddDepartmentButton.Location = new System.Drawing.Point(9, 480);
            this.AddDepartmentButton.Name = "AddDepartmentButton";
            this.AddDepartmentButton.Size = new System.Drawing.Size(104, 42);
            this.AddDepartmentButton.TabIndex = 59;
            this.AddDepartmentButton.Text = "Add";
            this.AddDepartmentButton.UseVisualStyleBackColor = false;
            this.AddDepartmentButton.Click += new System.EventHandler(this.AddDepartmentButton_Click);
            // 
            // departmentDGV
            // 
            this.departmentDGV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.departmentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departmentDGV.Location = new System.Drawing.Point(432, 116);
            this.departmentDGV.Name = "departmentDGV";
            this.departmentDGV.RowTemplate.Height = 25;
            this.departmentDGV.Size = new System.Drawing.Size(493, 354);
            this.departmentDGV.TabIndex = 58;
            this.departmentDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.departmentDGV_CellContentClick);
            // 
            // depDuration
            // 
            this.depDuration.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.depDuration.Location = new System.Drawing.Point(164, 230);
            this.depDuration.Name = "depDuration";
            this.depDuration.Size = new System.Drawing.Size(242, 39);
            this.depDuration.TabIndex = 54;
            // 
            // depDesc
            // 
            this.depDesc.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.depDesc.Location = new System.Drawing.Point(164, 173);
            this.depDesc.Name = "depDesc";
            this.depDesc.Size = new System.Drawing.Size(242, 39);
            this.depDesc.TabIndex = 48;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 531);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(923, 27);
            this.panel2.TabIndex = 44;
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
            this.panel1.Size = new System.Drawing.Size(923, 100);
            this.panel1.TabIndex = 43;
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
            this.label3.Size = new System.Drawing.Size(152, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Department";
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(12, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 32);
            this.label8.TabIndex = 53;
            this.label8.Text = "Duration";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(10, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 32);
            this.label5.TabIndex = 47;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(10, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 32);
            this.label4.TabIndex = 45;
            this.label4.Text = "Name";
            // 
            // depName
            // 
            this.depName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.depName.Location = new System.Drawing.Point(164, 116);
            this.depName.Name = "depName";
            this.depName.Size = new System.Drawing.Size(242, 39);
            this.depName.TabIndex = 46;
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(923, 558);
            this.Controls.Add(this.DeleteDepartmentButton);
            this.Controls.Add(this.EditDepartmentButton);
            this.Controls.Add(this.AddDepartmentButton);
            this.Controls.Add(this.departmentDGV);
            this.Controls.Add(this.depDuration);
            this.Controls.Add(this.depDesc);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.depName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Department";
            this.Text = "Department";
            this.Load += new System.EventHandler(this.Department_Load);
            ((System.ComponentModel.ISupportInitialize)(this.departmentDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteDepartmentButton;
        private System.Windows.Forms.Button EditDepartmentButton;
        private System.Windows.Forms.Button AddDepartmentButton;
        private System.Windows.Forms.DataGridView departmentDGV;
        private System.Windows.Forms.TextBox depDuration;
        private System.Windows.Forms.TextBox depDesc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox depName;
    }
}