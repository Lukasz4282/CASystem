namespace CA_Management
{
    partial class frmLect
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFunction = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogout.Font = new System.Drawing.Font("SimSun", 12F);
            this.btnLogout.Location = new System.Drawing.Point(50, 132);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(86, 30);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("SimSun", 12F);
            this.btnSubmit.Location = new System.Drawing.Point(209, 132);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(154, 30);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 12F);
            this.label1.Location = new System.Drawing.Point(47, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECT FUNCTION:";
            // 
            // cbFunction
            // 
            this.cbFunction.FormattingEnabled = true;
            this.cbFunction.Items.AddRange(new object[] {
            "ADD COURSE",
            "ADD MODULE",
            "MANAGE CA"});
            this.cbFunction.Location = new System.Drawing.Point(209, 48);
            this.cbFunction.Name = "cbFunction";
            this.cbFunction.Size = new System.Drawing.Size(154, 20);
            this.cbFunction.TabIndex = 3;
            // 
            // frmLect
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnLogout;
            this.ClientSize = new System.Drawing.Size(394, 223);
            this.Controls.Add(this.cbFunction);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label1);
            this.Name = "frmLect";
            this.Text = "LECTURER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFunction;
    }
}