
namespace CollegeMgmtSystemTutorial
{
    partial class Fees
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
            this.DeleteFee = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.PayFee = new System.Windows.Forms.Button();
            this.feeDGV = new System.Windows.Forms.DataGridView();
            this.feeAmmount = new System.Windows.Forms.TextBox();
            this.feePeriod = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.feeNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.feeStudent = new System.Windows.Forms.ComboBox();
            this.feeName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.feeDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeleteFee
            // 
            this.DeleteFee.BackColor = System.Drawing.Color.Azure;
            this.DeleteFee.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteFee.Location = new System.Drawing.Point(231, 483);
            this.DeleteFee.Name = "DeleteFee";
            this.DeleteFee.Size = new System.Drawing.Size(104, 42);
            this.DeleteFee.TabIndex = 61;
            this.DeleteFee.Text = "Delete";
            this.DeleteFee.UseVisualStyleBackColor = false;
            this.DeleteFee.Click += new System.EventHandler(this.DeleteFee_Click);
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
            // PayFee
            // 
            this.PayFee.BackColor = System.Drawing.Color.Azure;
            this.PayFee.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PayFee.Location = new System.Drawing.Point(11, 483);
            this.PayFee.Name = "PayFee";
            this.PayFee.Size = new System.Drawing.Size(104, 42);
            this.PayFee.TabIndex = 59;
            this.PayFee.Text = "Pay";
            this.PayFee.UseVisualStyleBackColor = false;
            this.PayFee.Click += new System.EventHandler(this.PayFee_Click);
            // 
            // feeDGV
            // 
            this.feeDGV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.feeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.feeDGV.Location = new System.Drawing.Point(434, 119);
            this.feeDGV.Name = "feeDGV";
            this.feeDGV.RowTemplate.Height = 25;
            this.feeDGV.Size = new System.Drawing.Size(493, 406);
            this.feeDGV.TabIndex = 58;
            // 
            // feeAmmount
            // 
            this.feeAmmount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.feeAmmount.Location = new System.Drawing.Point(166, 331);
            this.feeAmmount.Name = "feeAmmount";
            this.feeAmmount.Size = new System.Drawing.Size(242, 39);
            this.feeAmmount.TabIndex = 53;
            // 
            // feePeriod
            // 
            this.feePeriod.CalendarFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.feePeriod.Location = new System.Drawing.Point(166, 292);
            this.feePeriod.Name = "feePeriod";
            this.feePeriod.Size = new System.Drawing.Size(200, 23);
            this.feePeriod.TabIndex = 50;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 531);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(939, 27);
            this.panel2.TabIndex = 43;
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
            this.panel1.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Account";
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
            this.label8.Location = new System.Drawing.Point(12, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 32);
            this.label8.TabIndex = 52;
            this.label8.Text = "Amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(11, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 32);
            this.label7.TabIndex = 51;
            this.label7.Text = "Period";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(11, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 32);
            this.label6.TabIndex = 48;
            this.label6.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(12, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 32);
            this.label5.TabIndex = 46;
            this.label5.Text = "StdId";
            // 
            // feeNum
            // 
            this.feeNum.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.feeNum.Location = new System.Drawing.Point(166, 119);
            this.feeNum.Name = "feeNum";
            this.feeNum.Size = new System.Drawing.Size(242, 39);
            this.feeNum.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 32);
            this.label4.TabIndex = 44;
            this.label4.Text = "Num";
            // 
            // feeStudent
            // 
            this.feeStudent.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.feeStudent.FormattingEnabled = true;
            this.feeStudent.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.feeStudent.Location = new System.Drawing.Point(166, 173);
            this.feeStudent.Name = "feeStudent";
            this.feeStudent.Size = new System.Drawing.Size(121, 40);
            this.feeStudent.TabIndex = 49;
            this.feeStudent.SelectionChangeCommitted += new System.EventHandler(this.StudentNamer);
            this.feeStudent.TextUpdate += new System.EventHandler(this.StudentNamer);
            this.feeStudent.Click += new System.EventHandler(this.StudentNamer);
            // 
            // feeName
            // 
            this.feeName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.feeName.Location = new System.Drawing.Point(166, 233);
            this.feeName.Name = "feeName";
            this.feeName.Size = new System.Drawing.Size(242, 39);
            this.feeName.TabIndex = 47;
            this.feeName.Click += new System.EventHandler(this.StudentNamer);
            this.feeName.MouseCaptureChanged += new System.EventHandler(this.StudentNamer);
            // 
            // Fees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(939, 558);
            this.Controls.Add(this.DeleteFee);
            this.Controls.Add(this.PayFee);
            this.Controls.Add(this.feeDGV);
            this.Controls.Add(this.feeAmmount);
            this.Controls.Add(this.feePeriod);
            this.Controls.Add(this.feeStudent);
            this.Controls.Add(this.feeName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.feeNum);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fees";
            this.Load += new System.EventHandler(this.Fees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.feeDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteFee;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button PayFee;
        private System.Windows.Forms.DataGridView feeDGV;
        private System.Windows.Forms.TextBox feeAmmount;
        private System.Windows.Forms.DateTimePicker feePeriod;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox feeNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox feeStudent;
        private System.Windows.Forms.TextBox feeName;
    }
}