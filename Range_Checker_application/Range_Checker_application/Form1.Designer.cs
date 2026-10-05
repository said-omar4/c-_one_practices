namespace Range_Checker_application
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
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btncheckqualification = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbldecisionrange = new System.Windows.Forms.Label();
            this.lblrangedecision = new System.Windows.Forms.Label();
            this.txtrangename = new System.Windows.Forms.TextBox();
            this.lblrangename = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Red;
            this.btnexit.Location = new System.Drawing.Point(281, 362);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(179, 39);
            this.btnexit.TabIndex = 107;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Yellow;
            this.btnclear.Location = new System.Drawing.Point(281, 315);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(179, 39);
            this.btnclear.TabIndex = 106;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btncheckqualification
            // 
            this.btncheckqualification.BackColor = System.Drawing.Color.Green;
            this.btncheckqualification.ForeColor = System.Drawing.Color.White;
            this.btncheckqualification.Location = new System.Drawing.Point(92, 315);
            this.btncheckqualification.Name = "btncheckqualification";
            this.btncheckqualification.Size = new System.Drawing.Size(179, 86);
            this.btncheckqualification.TabIndex = 105;
            this.btncheckqualification.Text = "Check Qualification";
            this.btncheckqualification.UseVisualStyleBackColor = false;
            this.btncheckqualification.Click += new System.EventHandler(this.btncheckqualification_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(159, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 29);
            this.label1.TabIndex = 104;
            this.label1.Text = "Range Checker App";
            // 
            // lbldecisionrange
            // 
            this.lbldecisionrange.AutoSize = true;
            this.lbldecisionrange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldecisionrange.Location = new System.Drawing.Point(88, 213);
            this.lbldecisionrange.Name = "lbldecisionrange";
            this.lbldecisionrange.Size = new System.Drawing.Size(144, 24);
            this.lbldecisionrange.TabIndex = 103;
            this.lbldecisionrange.Text = "Range Decision";
            // 
            // lblrangedecision
            // 
            this.lblrangedecision.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblrangedecision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblrangedecision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrangedecision.ForeColor = System.Drawing.Color.Green;
            this.lblrangedecision.Location = new System.Drawing.Point(92, 253);
            this.lblrangedecision.Name = "lblrangedecision";
            this.lblrangedecision.Size = new System.Drawing.Size(368, 42);
            this.lblrangedecision.TabIndex = 102;
            this.lblrangedecision.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtrangename
            // 
            this.txtrangename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtrangename.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrangename.Location = new System.Drawing.Point(92, 166);
            this.txtrangename.Name = "txtrangename";
            this.txtrangename.Size = new System.Drawing.Size(368, 31);
            this.txtrangename.TabIndex = 101;
            // 
            // lblrangename
            // 
            this.lblrangename.AutoSize = true;
            this.lblrangename.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrangename.Location = new System.Drawing.Point(88, 127);
            this.lblrangename.Name = "lblrangename";
            this.lblrangename.Size = new System.Drawing.Size(382, 24);
            this.lblrangename.TabIndex = 100;
            this.lblrangename.Text = "Enter an integer i the range of 1 throught 10 :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 450);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncheckqualification);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbldecisionrange);
            this.Controls.Add(this.lblrangedecision);
            this.Controls.Add(this.txtrangename);
            this.Controls.Add(this.lblrangename);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btncheckqualification;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbldecisionrange;
        private System.Windows.Forms.Label lblrangedecision;
        private System.Windows.Forms.TextBox txtrangename;
        private System.Windows.Forms.Label lblrangename;
    }
}

