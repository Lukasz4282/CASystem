namespace CA_Management
{
    partial class frmCourse
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCourse = new System.Windows.Forms.Button();
            this.btnSubmitCourse = new System.Windows.Forms.Button();
            this.tbCourseC = new System.Windows.Forms.TextBox();
            this.tbCourseN = new System.Windows.Forms.TextBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 12F);
            this.label1.Location = new System.Drawing.Point(38, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ENTER COURSE CODE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 12F);
            this.label2.Location = new System.Drawing.Point(38, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ENTER COURSE NAME:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 12F);
            this.label3.Location = new System.Drawing.Point(94, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "ENTER YEAR:";
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Font = new System.Drawing.Font("SimSun", 12F);
            this.btnBack.Location = new System.Drawing.Point(41, 201);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCourse
            // 
            this.btnCourse.Font = new System.Drawing.Font("SimSun", 12F);
            this.btnCourse.Location = new System.Drawing.Point(140, 201);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Size = new System.Drawing.Size(132, 23);
            this.btnCourse.TabIndex = 4;
            this.btnCourse.Text = "VIEW  COURSES";
            this.btnCourse.UseVisualStyleBackColor = true;
            // 
            // btnSubmitCourse
            // 
            this.btnSubmitCourse.Font = new System.Drawing.Font("SimSun", 12F);
            this.btnSubmitCourse.Location = new System.Drawing.Point(306, 201);
            this.btnSubmitCourse.Name = "btnSubmitCourse";
            this.btnSubmitCourse.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitCourse.TabIndex = 5;
            this.btnSubmitCourse.Text = "SUBMIT";
            this.btnSubmitCourse.UseVisualStyleBackColor = true;
            // 
            // tbCourseC
            // 
            this.tbCourseC.Font = new System.Drawing.Font("SimSun", 12F);
            this.tbCourseC.Location = new System.Drawing.Point(220, 40);
            this.tbCourseC.Name = "tbCourseC";
            this.tbCourseC.Size = new System.Drawing.Size(161, 26);
            this.tbCourseC.TabIndex = 6;
            // 
            // tbCourseN
            // 
            this.tbCourseN.Font = new System.Drawing.Font("SimSun", 12F);
            this.tbCourseN.Location = new System.Drawing.Point(220, 89);
            this.tbCourseN.Name = "tbCourseN";
            this.tbCourseN.Size = new System.Drawing.Size(160, 26);
            this.tbCourseN.TabIndex = 7;
            // 
            // tbYear
            // 
            this.tbYear.Font = new System.Drawing.Font("SimSun", 12F);
            this.tbYear.Location = new System.Drawing.Point(220, 138);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(161, 26);
            this.tbYear.TabIndex = 8;
            // 
            // frmCourse
            // 
            this.AcceptButton = this.btnSubmitCourse;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(407, 247);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.tbCourseN);
            this.Controls.Add(this.tbCourseC);
            this.Controls.Add(this.btnSubmitCourse);
            this.Controls.Add(this.btnCourse);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCourse";
            this.Text = "COURSE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCourse;
        private System.Windows.Forms.Button btnSubmitCourse;
        private System.Windows.Forms.TextBox tbCourseC;
        private System.Windows.Forms.TextBox tbCourseN;
        private System.Windows.Forms.TextBox tbYear;
    }
}