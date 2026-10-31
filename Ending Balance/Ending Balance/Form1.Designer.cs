namespace Ending_Balance
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
            this.lblstarting = new System.Windows.Forms.Label();
            this.txtstarting = new System.Windows.Forms.TextBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.lblendingbalance = new System.Windows.Forms.Label();
            this.txtnumbermonth = new System.Windows.Forms.TextBox();
            this.lblnumbermonth = new System.Windows.Forms.Label();
            this.EndingBlanceOutput = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblstarting
            // 
            this.lblstarting.AutoSize = true;
            this.lblstarting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstarting.Location = new System.Drawing.Point(59, 70);
            this.lblstarting.Name = "lblstarting";
            this.lblstarting.Size = new System.Drawing.Size(135, 20);
            this.lblstarting.TabIndex = 0;
            this.lblstarting.Text = "Starting Balance :";
            // 
            // txtstarting
            // 
            this.txtstarting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtstarting.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstarting.Location = new System.Drawing.Point(226, 66);
            this.txtstarting.Name = "txtstarting";
            this.txtstarting.Size = new System.Drawing.Size(192, 29);
            this.txtstarting.TabIndex = 1;
            // 
            // btncalculate
            // 
            this.btncalculate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btncalculate.Location = new System.Drawing.Point(58, 417);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(112, 33);
            this.btncalculate.TabIndex = 2;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = false;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // lblendingbalance
            // 
            this.lblendingbalance.AutoSize = true;
            this.lblendingbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblendingbalance.Location = new System.Drawing.Point(59, 359);
            this.lblendingbalance.Name = "lblendingbalance";
            this.lblendingbalance.Size = new System.Drawing.Size(129, 20);
            this.lblendingbalance.TabIndex = 3;
            this.lblendingbalance.Text = "Ending Balance :";
            // 
            // txtnumbermonth
            // 
            this.txtnumbermonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnumbermonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumbermonth.Location = new System.Drawing.Point(226, 116);
            this.txtnumbermonth.Name = "txtnumbermonth";
            this.txtnumbermonth.Size = new System.Drawing.Size(192, 29);
            this.txtnumbermonth.TabIndex = 6;
            // 
            // lblnumbermonth
            // 
            this.lblnumbermonth.AutoSize = true;
            this.lblnumbermonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumbermonth.Location = new System.Drawing.Point(59, 120);
            this.lblnumbermonth.Name = "lblnumbermonth";
            this.lblnumbermonth.Size = new System.Drawing.Size(140, 20);
            this.lblnumbermonth.TabIndex = 5;
            this.lblnumbermonth.Text = "Number of month :";
            // 
            // EndingBlanceOutput
            // 
            this.EndingBlanceOutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.EndingBlanceOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndingBlanceOutput.Location = new System.Drawing.Point(226, 357);
            this.EndingBlanceOutput.Name = "EndingBlanceOutput";
            this.EndingBlanceOutput.Size = new System.Drawing.Size(192, 29);
            this.EndingBlanceOutput.TabIndex = 7;
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnclear.Location = new System.Drawing.Point(185, 417);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(112, 33);
            this.btnclear.TabIndex = 8;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnexit.Location = new System.Drawing.Point(312, 417);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(112, 33);
            this.btnexit.TabIndex = 9;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(60, 165);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(357, 173);
            this.lstOutput.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 490);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.EndingBlanceOutput);
            this.Controls.Add(this.txtnumbermonth);
            this.Controls.Add(this.lblnumbermonth);
            this.Controls.Add(this.lblendingbalance);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.txtstarting);
            this.Controls.Add(this.lblstarting);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblstarting;
        private System.Windows.Forms.TextBox txtstarting;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Label lblendingbalance;
        private System.Windows.Forms.TextBox txtnumbermonth;
        private System.Windows.Forms.Label lblnumbermonth;
        private System.Windows.Forms.Label EndingBlanceOutput;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.ListBox lstOutput;
    }
}

