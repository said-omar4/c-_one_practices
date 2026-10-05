namespace Test_Score_Average
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
            this.txttest3 = new System.Windows.Forms.TextBox();
            this.lbltest3 = new System.Windows.Forms.Label();
            this.txttest2 = new System.Windows.Forms.TextBox();
            this.lbltest2 = new System.Windows.Forms.Label();
            this.txttest1 = new System.Windows.Forms.TextBox();
            this.lbltest1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblaverage = new System.Windows.Forms.Label();
            this.lblaverageoutput = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txttest3
            // 
            this.txttest3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttest3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttest3.Location = new System.Drawing.Point(159, 131);
            this.txttest3.Name = "txttest3";
            this.txttest3.Size = new System.Drawing.Size(237, 31);
            this.txttest3.TabIndex = 61;
            this.txttest3.TextChanged += new System.EventHandler(this.txtscore3_TextChanged);
            // 
            // lbltest3
            // 
            this.lbltest3.AutoSize = true;
            this.lbltest3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltest3.Location = new System.Drawing.Point(15, 134);
            this.lbltest3.Name = "lbltest3";
            this.lbltest3.Size = new System.Drawing.Size(126, 24);
            this.lbltest3.TabIndex = 60;
            this.lbltest3.Text = "Test Score 3 :";
            this.lbltest3.Click += new System.EventHandler(this.lblscore3_Click);
            // 
            // txttest2
            // 
            this.txttest2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttest2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttest2.Location = new System.Drawing.Point(159, 81);
            this.txttest2.Name = "txttest2";
            this.txttest2.Size = new System.Drawing.Size(237, 31);
            this.txttest2.TabIndex = 59;
            this.txttest2.TextChanged += new System.EventHandler(this.txtscore2_TextChanged);
            // 
            // lbltest2
            // 
            this.lbltest2.AutoSize = true;
            this.lbltest2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltest2.Location = new System.Drawing.Point(15, 82);
            this.lbltest2.Name = "lbltest2";
            this.lbltest2.Size = new System.Drawing.Size(126, 24);
            this.lbltest2.TabIndex = 58;
            this.lbltest2.Text = "Test Score 2 :";
            this.lbltest2.Click += new System.EventHandler(this.lblscore2_Click);
            // 
            // txttest1
            // 
            this.txttest1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttest1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttest1.Location = new System.Drawing.Point(159, 30);
            this.txttest1.Name = "txttest1";
            this.txttest1.Size = new System.Drawing.Size(237, 31);
            this.txttest1.TabIndex = 57;
            this.txttest1.TextChanged += new System.EventHandler(this.txtscore1_TextChanged);
            // 
            // lbltest1
            // 
            this.lbltest1.AutoSize = true;
            this.lbltest1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltest1.Location = new System.Drawing.Point(15, 31);
            this.lbltest1.Name = "lbltest1";
            this.lbltest1.Size = new System.Drawing.Size(126, 24);
            this.lbltest1.TabIndex = 56;
            this.lbltest1.Text = "Test Score 1 :";
            this.lbltest1.Click += new System.EventHandler(this.lblscore1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(151, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 29);
            this.label1.TabIndex = 121;
            this.label1.Text = "Test Score Average";
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Red;
            this.btnexit.Location = new System.Drawing.Point(348, 424);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(131, 49);
            this.btnexit.TabIndex = 120;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Yellow;
            this.btnclear.Location = new System.Drawing.Point(200, 424);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(131, 49);
            this.btnclear.TabIndex = 119;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Green;
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(54, 424);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(131, 49);
            this.btnCalculate.TabIndex = 118;
            this.btnCalculate.Text = "Calculate Average";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btncalculateGrosspay_Click);
            // 
            // lblaverage
            // 
            this.lblaverage.AutoSize = true;
            this.lblaverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaverage.Location = new System.Drawing.Point(15, 180);
            this.lblaverage.Name = "lblaverage";
            this.lblaverage.Size = new System.Drawing.Size(91, 24);
            this.lblaverage.TabIndex = 117;
            this.lblaverage.Text = "Average :";
            // 
            // lblaverageoutput
            // 
            this.lblaverageoutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblaverageoutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblaverageoutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaverageoutput.ForeColor = System.Drawing.Color.Green;
            this.lblaverageoutput.Location = new System.Drawing.Point(19, 222);
            this.lblaverageoutput.Name = "lblaverageoutput";
            this.lblaverageoutput.Size = new System.Drawing.Size(387, 76);
            this.lblaverageoutput.TabIndex = 116;
            this.lblaverageoutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblaverage);
            this.groupBox1.Controls.Add(this.lblaverageoutput);
            this.groupBox1.Controls.Add(this.txttest3);
            this.groupBox1.Controls.Add(this.lbltest3);
            this.groupBox1.Controls.Add(this.txttest2);
            this.groupBox1.Controls.Add(this.lbltest2);
            this.groupBox1.Controls.Add(this.txttest1);
            this.groupBox1.Controls.Add(this.lbltest1);
            this.groupBox1.Location = new System.Drawing.Point(54, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 318);
            this.groupBox1.TabIndex = 122;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Three Test Scores";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 518);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttest3;
        private System.Windows.Forms.Label lbltest3;
        private System.Windows.Forms.TextBox txttest2;
        private System.Windows.Forms.Label lbltest2;
        private System.Windows.Forms.TextBox txttest1;
        private System.Windows.Forms.Label lbltest1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblaverage;
        private System.Windows.Forms.Label lblaverageoutput;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

