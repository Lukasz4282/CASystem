namespace CA_Management
{
    partial class frmModules
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
            this.tbModuleC = new System.Windows.Forms.TextBox();
            this.tbModuleN = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSubmitModule = new System.Windows.Forms.Button();
            this.btnModule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 12F);
            this.label1.Location = new System.Drawing.Point(32, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ENTER MODULE CODE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 12F);
            this.label2.Location = new System.Drawing.Point(33, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ENTER MODULE NAME:";
            // 
            // tbModuleC
            // 
            this.tbModuleC.Font = new System.Drawing.Font("SimSun", 12F);
            this.tbModuleC.Location = new System.Drawing.Point(220, 34);
            this.tbModuleC.Name = "tbModuleC";
            this.tbModuleC.Size = new System.Drawing.Size(139, 26);
            this.tbModuleC.TabIndex = 2;
            // 
            // tbModuleN
            // 
            this.tbModuleN.Font = new System.Drawing.Font("SimSun", 12F);
            this.tbModuleN.Location = new System.Drawing.Point(220, 89);
            this.tbModuleN.Name = "tbModuleN";
            this.tbModuleN.Size = new System.Drawing.Size(139, 26);
            this.tbModuleN.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Font = new System.Drawing.Font("SimSun", 12F);
            this.btnBack.Location = new System.Drawing.Point(35, 159);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(77, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnSubmitModule
            // 
            this.btnSubmitModule.Font = new System.Drawing.Font("SimSun", 12F);
            this.btnSubmitModule.Location = new System.Drawing.Point(266, 159);
            this.btnSubmitModule.Name = "btnSubmitModule";
            this.btnSubmitModule.Size = new System.Drawing.Size(93, 23);
            this.btnSubmitModule.TabIndex = 5;
            this.btnSubmitModule.Text = "SUBMIT";
            this.btnSubmitModule.UseVisualStyleBackColor = true;
            // 
            // btnModule
            // 
            this.btnModule.Font = new System.Drawing.Font("SimSun", 12F);
            this.btnModule.Location = new System.Drawing.Point(129, 159);
            this.btnModule.Name = "btnModule";
            this.btnModule.Size = new System.Drawing.Size(122, 23);
            this.btnModule.TabIndex = 6;
            this.btnModule.Text = "VIEW MODULES";
            this.btnModule.UseVisualStyleBackColor = true;
            // 
            // frmModules
            // 
            this.AcceptButton = this.btnSubmitModule;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(400, 211);
            this.Controls.Add(this.btnModule);
            this.Controls.Add(this.btnSubmitModule);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tbModuleN);
            this.Controls.Add(this.tbModuleC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmModules";
            this.Text = "MODULES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbModuleC;
        private System.Windows.Forms.TextBox tbModuleN;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSubmitModule;
        private System.Windows.Forms.Button btnModule;
    }
}