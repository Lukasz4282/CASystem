namespace CA_Management
{
    partial class frmStudent
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbShowAll = new System.Windows.Forms.RadioButton();
            this.rbShowDue = new System.Windows.Forms.RadioButton();
            this.checkCompleted = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbChoose = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkCompleted);
            this.groupBox1.Controls.Add(this.rbShowDue);
            this.groupBox1.Controls.Add(this.rbShowAll);
            this.groupBox1.Font = new System.Drawing.Font("SimSun", 12F);
            this.groupBox1.Location = new System.Drawing.Point(148, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FILTER";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbShowAll
            // 
            this.rbShowAll.AutoSize = true;
            this.rbShowAll.Location = new System.Drawing.Point(14, 25);
            this.rbShowAll.Name = "rbShowAll";
            this.rbShowAll.Size = new System.Drawing.Size(122, 20);
            this.rbShowAll.TabIndex = 0;
            this.rbShowAll.TabStop = true;
            this.rbShowAll.Text = "SHOW ALL CA ";
            this.rbShowAll.UseVisualStyleBackColor = true;
            // 
            // rbShowDue
            // 
            this.rbShowDue.AutoSize = true;
            this.rbShowDue.Location = new System.Drawing.Point(175, 25);
            this.rbShowDue.Name = "rbShowDue";
            this.rbShowDue.Size = new System.Drawing.Size(170, 20);
            this.rbShowDue.TabIndex = 1;
            this.rbShowDue.TabStop = true;
            this.rbShowDue.Text = "SHOW DUE THIS WEEK";
            this.rbShowDue.UseVisualStyleBackColor = true;
            // 
            // checkCompleted
            // 
            this.checkCompleted.AutoSize = true;
            this.checkCompleted.Location = new System.Drawing.Point(13, 60);
            this.checkCompleted.Name = "checkCompleted";
            this.checkCompleted.Size = new System.Drawing.Size(139, 20);
            this.checkCompleted.TabIndex = 2;
            this.checkCompleted.Text = "HIDE COMPLETED";
            this.checkCompleted.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 11F);
            this.label1.Location = new System.Drawing.Point(173, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHOOSE MODULE";
            // 
            // cbChoose
            // 
            this.cbChoose.Font = new System.Drawing.Font("SimSun", 11F);
            this.cbChoose.FormattingEnabled = true;
            this.cbChoose.Items.AddRange(new object[] {
            "SHOW ALL"});
            this.cbChoose.Location = new System.Drawing.Point(323, 114);
            this.cbChoose.Name = "cbChoose";
            this.cbChoose.Size = new System.Drawing.Size(200, 23);
            this.cbChoose.TabIndex = 2;
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 400);
            this.Controls.Add(this.cbChoose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmStudent";
            this.Text = "STUDENT CA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkCompleted;
        private System.Windows.Forms.RadioButton rbShowDue;
        private System.Windows.Forms.RadioButton rbShowAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbChoose;
    }
}