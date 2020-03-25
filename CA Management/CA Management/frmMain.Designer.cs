namespace CA_Management
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbSelect = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdLecturer = new System.Windows.Forms.RadioButton();
            this.rdStudent = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(44, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECT USER";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbSelect
            // 
            this.cbSelect.Font = new System.Drawing.Font("SimSun", 12F);
            this.cbSelect.FormattingEnabled = true;
            this.cbSelect.Location = new System.Drawing.Point(182, 131);
            this.cbSelect.Name = "cbSelect";
            this.cbSelect.Size = new System.Drawing.Size(156, 24);
            this.cbSelect.TabIndex = 1;
            this.cbSelect.SelectedIndexChanged += new System.EventHandler(this.cbSelect_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("SimSun", 12F);
            this.btnExit.Location = new System.Drawing.Point(48, 202);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 33);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("SimSun", 12F);
            this.btnSubmit.Location = new System.Drawing.Point(182, 202);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(156, 33);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdLecturer);
            this.groupBox1.Controls.Add(this.rdStudent);
            this.groupBox1.Font = new System.Drawing.Font("SimSun", 11F);
            this.groupBox1.Location = new System.Drawing.Point(48, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 113);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SELECT USER TYPE";
            // 
            // rdLecturer
            // 
            this.rdLecturer.AutoSize = true;
            this.rdLecturer.Location = new System.Drawing.Point(17, 74);
            this.rdLecturer.Name = "rdLecturer";
            this.rdLecturer.Size = new System.Drawing.Size(89, 19);
            this.rdLecturer.TabIndex = 1;
            this.rdLecturer.TabStop = true;
            this.rdLecturer.Text = "LECTURER";
            this.rdLecturer.UseVisualStyleBackColor = true;
            this.rdLecturer.CheckedChanged += new System.EventHandler(this.rdLecturer_CheckedChanged);
            // 
            // rdStudent
            // 
            this.rdStudent.AutoSize = true;
            this.rdStudent.Location = new System.Drawing.Point(17, 33);
            this.rdStudent.Name = "rdStudent";
            this.rdStudent.Size = new System.Drawing.Size(81, 19);
            this.rdStudent.TabIndex = 0;
            this.rdStudent.TabStop = true;
            this.rdStudent.Text = "STUDENT";
            this.rdStudent.UseVisualStyleBackColor = true;
            this.rdStudent.CheckedChanged += new System.EventHandler(this.rdStudent_CheckedChanged);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(399, 247);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cbSelect);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "CA MANAGEMNT SYSTEM";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSelect;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdLecturer;
        private System.Windows.Forms.RadioButton rdStudent;
    }
}

