namespace StudentTabApp
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.StudentDetails = new System.Windows.Forms.TabPage();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.CA = new System.Windows.Forms.TabPage();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnMoveCAs = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblListOfMod = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.StudentDetails.SuspendLayout();
            this.CA.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.StudentDetails);
            this.tabControl1.Controls.Add(this.CA);
            this.tabControl1.Location = new System.Drawing.Point(197, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(541, 278);
            this.tabControl1.TabIndex = 0;
            // 
            // StudentDetails
            // 
            this.StudentDetails.Controls.Add(this.txtDate);
            this.StudentDetails.Controls.Add(this.txtName);
            this.StudentDetails.Controls.Add(this.lblDate);
            this.StudentDetails.Controls.Add(this.lblName);
            this.StudentDetails.Location = new System.Drawing.Point(4, 25);
            this.StudentDetails.Name = "StudentDetails";
            this.StudentDetails.Padding = new System.Windows.Forms.Padding(3);
            this.StudentDetails.Size = new System.Drawing.Size(533, 249);
            this.StudentDetails.TabIndex = 0;
            this.StudentDetails.Text = "Week Details";
            this.StudentDetails.UseVisualStyleBackColor = true;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(124, 56);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(185, 22);
            this.txtDate.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(124, 16);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(185, 22);
            this.txtName.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(11, 56);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(47, 18);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date: ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(11, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(75, 18);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Week No:";
            // 
            // CA
            // 
            this.CA.Controls.Add(this.btnRemoveItem);
            this.CA.Controls.Add(this.btnMoveCAs);
            this.CA.Controls.Add(this.listBox2);
            this.CA.Controls.Add(this.listBox1);
            this.CA.Controls.Add(this.label1);
            this.CA.Controls.Add(this.lblListOfMod);
            this.CA.Location = new System.Drawing.Point(4, 25);
            this.CA.Name = "CA";
            this.CA.Padding = new System.Windows.Forms.Padding(3);
            this.CA.Size = new System.Drawing.Size(533, 249);
            this.CA.TabIndex = 1;
            this.CA.Text = "CA";
            this.CA.UseVisualStyleBackColor = true;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(244, 123);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(42, 38);
            this.btnRemoveItem.TabIndex = 5;
            this.btnRemoveItem.Text = "<<";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnMoveCAs
            // 
            this.btnMoveCAs.Location = new System.Drawing.Point(244, 68);
            this.btnMoveCAs.Name = "btnMoveCAs";
            this.btnMoveCAs.Size = new System.Drawing.Size(42, 38);
            this.btnMoveCAs.TabIndex = 4;
            this.btnMoveCAs.Text = ">>";
            this.btnMoveCAs.UseVisualStyleBackColor = true;
            this.btnMoveCAs.Click += new System.EventHandler(this.btnMoveCAs_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(327, 24);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(172, 196);
            this.listBox2.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(29, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(172, 196);
            this.listBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Due on selected week";
            // 
            // lblListOfMod
            // 
            this.lblListOfMod.AutoSize = true;
            this.lblListOfMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListOfMod.Location = new System.Drawing.Point(73, 3);
            this.lblListOfMod.Name = "lblListOfMod";
            this.lblListOfMod.Size = new System.Drawing.Size(72, 18);
            this.lblListOfMod.TabIndex = 0;
            this.lblListOfMod.Text = "List of CA";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(816, 161);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(78, 28);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(754, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Process Student";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(12, 38);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(160, 244);
            this.listBox3.TabIndex = 2;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveToFile.Location = new System.Drawing.Point(754, 77);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(140, 28);
            this.btnSaveToFile.TabIndex = 3;
            this.btnSaveToFile.Text = "Save to file";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.Location = new System.Drawing.Point(754, 116);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(140, 28);
            this.btnAddStudent.TabIndex = 4;
            this.btnAddStudent.Text = "Add student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 337);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.btnSaveToFile);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.StudentDetails.ResumeLayout(false);
            this.StudentDetails.PerformLayout();
            this.CA.ResumeLayout(false);
            this.CA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage StudentDetails;
        private System.Windows.Forms.TabPage CA;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblListOfMod;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnMoveCAs;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.Button btnAddStudent;
    }
}

