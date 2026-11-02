namespace BMI_Programm_Calculator
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
            this.textheight = new System.Windows.Forms.TextBox();
            this.lblheight = new System.Windows.Forms.Label();
            this.textweight = new System.Windows.Forms.TextBox();
            this.lblweight = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.ListBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.BTNEXIT = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textheight
            // 
            this.textheight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textheight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textheight.Location = new System.Drawing.Point(215, 127);
            this.textheight.Margin = new System.Windows.Forms.Padding(2);
            this.textheight.Name = "textheight";
            this.textheight.Size = new System.Drawing.Size(194, 26);
            this.textheight.TabIndex = 7;
            // 
            // lblheight
            // 
            this.lblheight.AutoSize = true;
            this.lblheight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheight.Location = new System.Drawing.Point(35, 125);
            this.lblheight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblheight.Name = "lblheight";
            this.lblheight.Size = new System.Drawing.Size(126, 20);
            this.lblheight.TabIndex = 9;
            this.lblheight.Text = "Enter Height(M):";
            // 
            // textweight
            // 
            this.textweight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textweight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textweight.Location = new System.Drawing.Point(215, 88);
            this.textweight.Margin = new System.Windows.Forms.Padding(2);
            this.textweight.Name = "textweight";
            this.textweight.Size = new System.Drawing.Size(194, 26);
            this.textweight.TabIndex = 6;
            // 
            // lblweight
            // 
            this.lblweight.AutoSize = true;
            this.lblweight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblweight.Location = new System.Drawing.Point(35, 88);
            this.lblweight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblweight.Name = "lblweight";
            this.lblweight.Size = new System.Drawing.Size(176, 20);
            this.lblweight.TabIndex = 8;
            this.lblweight.Text = "Enter  The Weight(kg) : ";
            // 
            // Output
            // 
            this.Output.FormattingEnabled = true;
            this.Output.Location = new System.Drawing.Point(39, 176);
            this.Output.Margin = new System.Windows.Forms.Padding(2);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(370, 147);
            this.Output.TabIndex = 10;
            // 
            // btncalculate
            // 
            this.btncalculate.BackColor = System.Drawing.Color.Blue;
            this.btncalculate.Location = new System.Drawing.Point(39, 345);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(118, 37);
            this.btncalculate.TabIndex = 11;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = false;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Yellow;
            this.btnclear.Location = new System.Drawing.Point(165, 345);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(118, 37);
            this.btnclear.TabIndex = 12;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // BTNEXIT
            // 
            this.BTNEXIT.BackColor = System.Drawing.Color.Red;
            this.BTNEXIT.Location = new System.Drawing.Point(291, 345);
            this.BTNEXIT.Name = "BTNEXIT";
            this.BTNEXIT.Size = new System.Drawing.Size(118, 37);
            this.BTNEXIT.TabIndex = 13;
            this.BTNEXIT.Text = "Exit";
            this.BTNEXIT.UseVisualStyleBackColor = false;
            this.BTNEXIT.Click += new System.EventHandler(this.BTNEXIT_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 52);
            this.panel1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(82, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "BMI CALCULATOR PROGRAMM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 404);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BTNEXIT);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.textheight);
            this.Controls.Add(this.lblheight);
            this.Controls.Add(this.textweight);
            this.Controls.Add(this.lblweight);
            this.Controls.Add(this.Output);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textheight;
        private System.Windows.Forms.Label lblheight;
        private System.Windows.Forms.TextBox textweight;
        private System.Windows.Forms.Label lblweight;
        private System.Windows.Forms.ListBox Output;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button BTNEXIT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}

