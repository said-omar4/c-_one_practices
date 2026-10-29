namespace chapter_3_example__
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
            this.lblresultoutput = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.txtexp = new System.Windows.Forms.TextBox();
            this.lblexp = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.lblsalary = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblresultoutput
            // 
            this.lblresultoutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblresultoutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblresultoutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultoutput.Location = new System.Drawing.Point(158, 247);
            this.lblresultoutput.Name = "lblresultoutput";
            this.lblresultoutput.Size = new System.Drawing.Size(393, 99);
            this.lblresultoutput.TabIndex = 45;
            this.lblresultoutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btncalculate
            // 
            this.btncalculate.BackColor = System.Drawing.Color.Green;
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.ForeColor = System.Drawing.Color.White;
            this.btncalculate.Location = new System.Drawing.Point(158, 383);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(194, 41);
            this.btncalculate.TabIndex = 39;
            this.btncalculate.Text = "Check qualification";
            this.btncalculate.UseVisualStyleBackColor = false;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // txtexp
            // 
            this.txtexp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtexp.Location = new System.Drawing.Point(314, 135);
            this.txtexp.Name = "txtexp";
            this.txtexp.Size = new System.Drawing.Size(237, 29);
            this.txtexp.TabIndex = 37;
            // 
            // lblexp
            // 
            this.lblexp.AutoSize = true;
            this.lblexp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexp.Location = new System.Drawing.Point(154, 135);
            this.lblexp.Name = "lblexp";
            this.lblexp.Size = new System.Drawing.Size(143, 24);
            this.lblexp.TabIndex = 34;
            this.lblexp.Text = "Enter year exp :";
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.Location = new System.Drawing.Point(266, 202);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(187, 29);
            this.lblresult.TabIndex = 33;
            this.lblresult.Text = "Decision result";
            // 
            // txtsalary
            // 
            this.txtsalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalary.Location = new System.Drawing.Point(314, 84);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(237, 29);
            this.txtsalary.TabIndex = 32;
            // 
            // lblsalary
            // 
            this.lblsalary.AutoSize = true;
            this.lblsalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsalary.Location = new System.Drawing.Point(154, 84);
            this.lblsalary.Name = "lblsalary";
            this.lblsalary.Size = new System.Drawing.Size(118, 24);
            this.lblsalary.TabIndex = 31;
            this.lblsalary.Text = "Enter salary :";
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Red;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.White;
            this.btnclear.Location = new System.Drawing.Point(357, 383);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(194, 41);
            this.btnclear.TabIndex = 46;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 517);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.lblresultoutput);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.txtexp);
            this.Controls.Add(this.lblexp);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.txtsalary);
            this.Controls.Add(this.lblsalary);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblresultoutput;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.TextBox txtexp;
        private System.Windows.Forms.Label lblexp;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.TextBox txtsalary;
        private System.Windows.Forms.Label lblsalary;
        private System.Windows.Forms.Button btnclear;
    }
}

