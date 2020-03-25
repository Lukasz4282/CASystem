namespace CA_Management
{
    partial class frmCA
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
            this.cbCAOptions = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbModName = new System.Windows.Forms.TextBox();
            this.tbCAName = new System.Windows.Forms.TextBox();
            this.numPercentage = new System.Windows.Forms.NumericUpDown();
            this.dtDueDate = new System.Windows.Forms.DateTimePicker();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnViewCA = new System.Windows.Forms.Button();
            this.btnSubmitCA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPercentage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 12F);
            this.label1.Location = new System.Drawing.Point(61, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECT OPTION: ";
            // 
            // cbCAOptions
            // 
            this.cbCAOptions.Font = new System.Drawing.Font("SimSun", 12F);
            this.cbCAOptions.FormattingEnabled = true;
            this.cbCAOptions.Items.AddRange(new object[] {
            "ADD CA",
            "CHANGE DUE DATE",
            "DELETE CA"});
            this.cbCAOptions.Location = new System.Drawing.Point(214, 32);
            this.cbCAOptions.Name = "cbCAOptions";
            this.cbCAOptions.Size = new System.Drawing.Size(200, 24);
            this.cbCAOptions.TabIndex = 1;
            this.cbCAOptions.SelectedIndexChanged += new System.EventHandler(this.cbCAOptions_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 12F);
            this.label2.Location = new System.Drawing.Point(85, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "MODULE NAME:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 12F);
            this.label3.Location = new System.Drawing.Point(117, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "CA NAME:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun", 12F);
            this.label4.Location = new System.Drawing.Point(109, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "DUE DATE:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SimSun", 12F);
            this.label5.Location = new System.Drawing.Point(37, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "TOTAL PERCENTAGE: ";
            // 
            // tbModName
            // 
            this.tbModName.Font = new System.Drawing.Font("SimSun", 12F);
            this.tbModName.Location = new System.Drawing.Point(214, 91);
            this.tbModName.Name = "tbModName";
            this.tbModName.Size = new System.Drawing.Size(200, 26);
            this.tbModName.TabIndex = 6;
            // 
            // tbCAName
            // 
            this.tbCAName.Font = new System.Drawing.Font("SimSun", 12F);
            this.tbCAName.Location = new System.Drawing.Point(214, 146);
            this.tbCAName.Name = "tbCAName";
            this.tbCAName.Size = new System.Drawing.Size(200, 26);
            this.tbCAName.TabIndex = 7;
            // 
            // numPercentage
            // 
            this.numPercentage.Font = new System.Drawing.Font("SimSun", 12F);
            this.numPercentage.Location = new System.Drawing.Point(214, 249);
            this.numPercentage.Name = "numPercentage";
            this.numPercentage.Size = new System.Drawing.Size(200, 26);
            this.numPercentage.TabIndex = 8;
            // 
            // dtDueDate
            // 
            this.dtDueDate.CalendarFont = new System.Drawing.Font("SimSun", 12F);
            this.dtDueDate.Location = new System.Drawing.Point(214, 199);
            this.dtDueDate.Name = "dtDueDate";
            this.dtDueDate.Size = new System.Drawing.Size(200, 21);
            this.dtDueDate.TabIndex = 9;
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Font = new System.Drawing.Font("SimSun", 12F);
            this.btnBack.Location = new System.Drawing.Point(40, 333);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnViewCA
            // 
            this.btnViewCA.Font = new System.Drawing.Font("SimSun", 12F);
            this.btnViewCA.Location = new System.Drawing.Point(169, 333);
            this.btnViewCA.Name = "btnViewCA";
            this.btnViewCA.Size = new System.Drawing.Size(95, 23);
            this.btnViewCA.TabIndex = 11;
            this.btnViewCA.Text = "VIEW CA";
            this.btnViewCA.UseVisualStyleBackColor = true;
            // 
            // btnSubmitCA
            // 
            this.btnSubmitCA.Font = new System.Drawing.Font("SimSun", 12F);
            this.btnSubmitCA.Location = new System.Drawing.Point(302, 333);
            this.btnSubmitCA.Name = "btnSubmitCA";
            this.btnSubmitCA.Size = new System.Drawing.Size(112, 23);
            this.btnSubmitCA.TabIndex = 12;
            this.btnSubmitCA.Text = "ADD CA";
            this.btnSubmitCA.UseVisualStyleBackColor = true;
            // 
            // frmCA
            // 
            this.AcceptButton = this.btnSubmitCA;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(474, 399);
            this.Controls.Add(this.btnSubmitCA);
            this.Controls.Add(this.btnViewCA);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dtDueDate);
            this.Controls.Add(this.numPercentage);
            this.Controls.Add(this.tbCAName);
            this.Controls.Add(this.tbModName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCAOptions);
            this.Controls.Add(this.label1);
            this.Name = "frmCA";
            this.Text = "CA MANAGER";
            this.Load += new System.EventHandler(this.frmCA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPercentage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCAOptions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbModName;
        private System.Windows.Forms.TextBox tbCAName;
        private System.Windows.Forms.NumericUpDown numPercentage;
        private System.Windows.Forms.DateTimePicker dtDueDate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnViewCA;
        private System.Windows.Forms.Button btnSubmitCA;
    }
}