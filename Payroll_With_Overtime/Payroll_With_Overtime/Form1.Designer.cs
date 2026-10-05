namespace Payroll_With_Overtime
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
            this.lblgrosspay = new System.Windows.Forms.Label();
            this.lblgrosspayoutput = new System.Windows.Forms.Label();
            this.txthourlypayrate = new System.Windows.Forms.TextBox();
            this.lblhourlypayrate = new System.Windows.Forms.Label();
            this.txthoursworked = new System.Windows.Forms.TextBox();
            this.lblhoursworked = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btncalculateGrosspay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblgrosspay
            // 
            this.lblgrosspay.AutoSize = true;
            this.lblgrosspay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgrosspay.Location = new System.Drawing.Point(69, 231);
            this.lblgrosspay.Name = "lblgrosspay";
            this.lblgrosspay.Size = new System.Drawing.Size(99, 24);
            this.lblgrosspay.TabIndex = 92;
            this.lblgrosspay.Text = "Gross pay:";
            // 
            // lblgrosspayoutput
            // 
            this.lblgrosspayoutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblgrosspayoutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblgrosspayoutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgrosspayoutput.Location = new System.Drawing.Point(73, 272);
            this.lblgrosspayoutput.Name = "lblgrosspayoutput";
            this.lblgrosspayoutput.Size = new System.Drawing.Size(387, 76);
            this.lblgrosspayoutput.TabIndex = 91;
            this.lblgrosspayoutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txthourlypayrate
            // 
            this.txthourlypayrate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txthourlypayrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthourlypayrate.Location = new System.Drawing.Point(223, 166);
            this.txthourlypayrate.Name = "txthourlypayrate";
            this.txthourlypayrate.Size = new System.Drawing.Size(237, 31);
            this.txthourlypayrate.TabIndex = 90;
            // 
            // lblhourlypayrate
            // 
            this.lblhourlypayrate.AutoSize = true;
            this.lblhourlypayrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhourlypayrate.Location = new System.Drawing.Point(69, 169);
            this.lblhourlypayrate.Name = "lblhourlypayrate";
            this.lblhourlypayrate.Size = new System.Drawing.Size(146, 24);
            this.lblhourlypayrate.TabIndex = 89;
            this.lblhourlypayrate.Text = "Hourly pay rate :";
            this.lblhourlypayrate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txthoursworked
            // 
            this.txthoursworked.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txthoursworked.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthoursworked.Location = new System.Drawing.Point(223, 115);
            this.txthoursworked.Name = "txthoursworked";
            this.txthoursworked.Size = new System.Drawing.Size(238, 31);
            this.txthoursworked.TabIndex = 88;
            // 
            // lblhoursworked
            // 
            this.lblhoursworked.AutoSize = true;
            this.lblhoursworked.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhoursworked.Location = new System.Drawing.Point(69, 118);
            this.lblhoursworked.Name = "lblhoursworked";
            this.lblhoursworked.Size = new System.Drawing.Size(153, 24);
            this.lblhoursworked.TabIndex = 87;
            this.lblhoursworked.Text = "Hourse Worked :";
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Red;
            this.btnexit.Location = new System.Drawing.Point(339, 388);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(121, 39);
            this.btnexit.TabIndex = 110;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Yellow;
            this.btnclear.Location = new System.Drawing.Point(206, 388);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(121, 39);
            this.btnclear.TabIndex = 109;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btncalculateGrosspay
            // 
            this.btncalculateGrosspay.BackColor = System.Drawing.Color.Green;
            this.btncalculateGrosspay.ForeColor = System.Drawing.Color.White;
            this.btncalculateGrosspay.Location = new System.Drawing.Point(73, 388);
            this.btncalculateGrosspay.Name = "btncalculateGrosspay";
            this.btncalculateGrosspay.Size = new System.Drawing.Size(121, 39);
            this.btncalculateGrosspay.TabIndex = 108;
            this.btncalculateGrosspay.Text = "Calculate Gross Pay";
            this.btncalculateGrosspay.UseVisualStyleBackColor = false;
            this.btncalculateGrosspay.Click += new System.EventHandler(this.btncalculateGrosspay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(136, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 29);
            this.label1.TabIndex = 111;
            this.label1.Text = "Payroll With Overtime";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 482);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculateGrosspay);
            this.Controls.Add(this.lblgrosspay);
            this.Controls.Add(this.lblgrosspayoutput);
            this.Controls.Add(this.txthourlypayrate);
            this.Controls.Add(this.lblhourlypayrate);
            this.Controls.Add(this.txthoursworked);
            this.Controls.Add(this.lblhoursworked);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblgrosspay;
        private System.Windows.Forms.Label lblgrosspayoutput;
        private System.Windows.Forms.TextBox txthourlypayrate;
        private System.Windows.Forms.Label lblhourlypayrate;
        private System.Windows.Forms.TextBox txthoursworked;
        private System.Windows.Forms.Label lblhoursworked;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btncalculateGrosspay;
        private System.Windows.Forms.Label label1;
    }
}

