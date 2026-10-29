namespace assignment_file
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
            this.btn_create_newfile = new System.Windows.Forms.Button();
            this.btnreadingOtherfunction = new System.Windows.Forms.Button();
            this.btndeleteTheFile = new System.Windows.Forms.Button();
            this.btndeleteitemfile = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_create_newfile
            // 
            this.btn_create_newfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create_newfile.Location = new System.Drawing.Point(46, 131);
            this.btn_create_newfile.Margin = new System.Windows.Forms.Padding(2);
            this.btn_create_newfile.Name = "btn_create_newfile";
            this.btn_create_newfile.Size = new System.Drawing.Size(160, 48);
            this.btn_create_newfile.TabIndex = 1;
            this.btn_create_newfile.Text = "create new file";
            this.btn_create_newfile.UseVisualStyleBackColor = true;
            this.btn_create_newfile.Click += new System.EventHandler(this.btn_create_newfile_Click);
            // 
            // btnreadingOtherfunction
            // 
            this.btnreadingOtherfunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreadingOtherfunction.Location = new System.Drawing.Point(226, 131);
            this.btnreadingOtherfunction.Margin = new System.Windows.Forms.Padding(2);
            this.btnreadingOtherfunction.Name = "btnreadingOtherfunction";
            this.btnreadingOtherfunction.Size = new System.Drawing.Size(241, 48);
            this.btnreadingOtherfunction.TabIndex = 2;
            this.btnreadingOtherfunction.Text = "Reading other function";
            this.btnreadingOtherfunction.UseVisualStyleBackColor = true;
            this.btnreadingOtherfunction.Click += new System.EventHandler(this.button1_Click);
            // 
            // btndeleteTheFile
            // 
            this.btndeleteTheFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeleteTheFile.Location = new System.Drawing.Point(46, 207);
            this.btndeleteTheFile.Margin = new System.Windows.Forms.Padding(2);
            this.btndeleteTheFile.Name = "btndeleteTheFile";
            this.btndeleteTheFile.Size = new System.Drawing.Size(160, 48);
            this.btndeleteTheFile.TabIndex = 3;
            this.btndeleteTheFile.Text = "Delete the file";
            this.btndeleteTheFile.UseVisualStyleBackColor = true;
            this.btndeleteTheFile.Click += new System.EventHandler(this.deletethefile_Click);
            // 
            // btndeleteitemfile
            // 
            this.btndeleteitemfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeleteitemfile.Location = new System.Drawing.Point(226, 207);
            this.btndeleteitemfile.Margin = new System.Windows.Forms.Padding(2);
            this.btndeleteitemfile.Name = "btndeleteitemfile";
            this.btndeleteitemfile.Size = new System.Drawing.Size(241, 48);
            this.btndeleteitemfile.TabIndex = 4;
            this.btndeleteitemfile.Text = "Delete the item file";
            this.btndeleteitemfile.UseVisualStyleBackColor = true;
            this.btndeleteitemfile.Click += new System.EventHandler(this.deleteitemfile_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(503, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(209, 329);
            this.listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 469);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btndeleteitemfile);
            this.Controls.Add(this.btndeleteTheFile);
            this.Controls.Add(this.btnreadingOtherfunction);
            this.Controls.Add(this.btn_create_newfile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_create_newfile;
        private System.Windows.Forms.Button btnreadingOtherfunction;
        private System.Windows.Forms.Button btndeleteTheFile;
        private System.Windows.Forms.Button btndeleteitemfile;
        private System.Windows.Forms.ListBox listBox1;
    }
}

