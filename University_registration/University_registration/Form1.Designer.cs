namespace University_registration
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.tblnameoutput = new System.Windows.Forms.Label();
            this.txtcourses = new System.Windows.Forms.TextBox();
            this.lblcourses = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.txttransport = new System.Windows.Forms.TextBox();
            this.lbltransport = new System.Windows.Forms.Label();
            this.txtlevel = new System.Windows.Forms.TextBox();
            this.lbllevel = new System.Windows.Forms.Label();
            this.tblidoutput = new System.Windows.Forms.Label();
            this.tblcoursesoutput = new System.Windows.Forms.Label();
            this.lbldiscountoutput = new System.Windows.Forms.Label();
            this.lbltransportoutput = new System.Windows.Forms.Label();
            this.lblstudyoutput = new System.Windows.Forms.Label();
            this.lbltutionoutput = new System.Windows.Forms.Label();
            this.lblfinaloutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(172, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 29);
            this.label1.TabIndex = 126;
            this.label1.Text = "Regitration Fee System";
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Red;
            this.btnexit.Location = new System.Drawing.Point(435, 384);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(153, 49);
            this.btnexit.TabIndex = 125;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Yellow;
            this.btnclear.Location = new System.Drawing.Point(254, 384);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(153, 49);
            this.btnclear.TabIndex = 124;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Green;
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(73, 384);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(153, 49);
            this.btnCalculate.TabIndex = 123;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // tblnameoutput
            // 
            this.tblnameoutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tblnameoutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tblnameoutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblnameoutput.ForeColor = System.Drawing.Color.Green;
            this.tblnameoutput.Location = new System.Drawing.Point(73, 467);
            this.tblnameoutput.Name = "tblnameoutput";
            this.tblnameoutput.Size = new System.Drawing.Size(249, 36);
            this.tblnameoutput.TabIndex = 133;
            this.tblnameoutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tblnameoutput.Click += new System.EventHandler(this.lblaverageoutput_Click);
            // 
            // txtcourses
            // 
            this.txtcourses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcourses.Location = new System.Drawing.Point(351, 207);
            this.txtcourses.Name = "txtcourses";
            this.txtcourses.Size = new System.Drawing.Size(237, 31);
            this.txtcourses.TabIndex = 132;
            // 
            // lblcourses
            // 
            this.lblcourses.AutoSize = true;
            this.lblcourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcourses.Location = new System.Drawing.Point(69, 214);
            this.lblcourses.Name = "lblcourses";
            this.lblcourses.Size = new System.Drawing.Size(234, 24);
            this.lblcourses.TabIndex = 131;
            this.lblcourses.Text = "Enter Number of Courses :";
            // 
            // txtid
            // 
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(351, 157);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(237, 31);
            this.txtid.TabIndex = 130;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(69, 161);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(154, 24);
            this.lblid.TabIndex = 129;
            this.lblid.Text = "Enter Student Id :";
            // 
            // txtname
            // 
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(351, 106);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(237, 31);
            this.txtname.TabIndex = 128;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(69, 110);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(190, 24);
            this.lblname.TabIndex = 127;
            this.lblname.Text = "Enter Student Name :";
            // 
            // txttransport
            // 
            this.txttransport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttransport.Location = new System.Drawing.Point(351, 310);
            this.txttransport.Name = "txttransport";
            this.txttransport.Size = new System.Drawing.Size(237, 31);
            this.txttransport.TabIndex = 140;
            // 
            // lbltransport
            // 
            this.lbltransport.AutoSize = true;
            this.lbltransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltransport.Location = new System.Drawing.Point(69, 317);
            this.lbltransport.Name = "lbltransport";
            this.lbltransport.Size = new System.Drawing.Size(131, 24);
            this.lbltransport.TabIndex = 139;
            this.lbltransport.Text = "Transport fee :";
            // 
            // txtlevel
            // 
            this.txtlevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtlevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlevel.Location = new System.Drawing.Point(351, 258);
            this.txtlevel.Name = "txtlevel";
            this.txtlevel.Size = new System.Drawing.Size(237, 31);
            this.txtlevel.TabIndex = 136;
            // 
            // lbllevel
            // 
            this.lbllevel.AutoSize = true;
            this.lbllevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllevel.Location = new System.Drawing.Point(69, 262);
            this.lbllevel.Name = "lbllevel";
            this.lbllevel.Size = new System.Drawing.Size(167, 24);
            this.lbllevel.TabIndex = 135;
            this.lbllevel.Text = "Enter Study Level :";
            // 
            // tblidoutput
            // 
            this.tblidoutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tblidoutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tblidoutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblidoutput.ForeColor = System.Drawing.Color.Green;
            this.tblidoutput.Location = new System.Drawing.Point(73, 523);
            this.tblidoutput.Name = "tblidoutput";
            this.tblidoutput.Size = new System.Drawing.Size(249, 36);
            this.tblidoutput.TabIndex = 141;
            this.tblidoutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tblcoursesoutput
            // 
            this.tblcoursesoutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tblcoursesoutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tblcoursesoutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblcoursesoutput.ForeColor = System.Drawing.Color.Green;
            this.tblcoursesoutput.Location = new System.Drawing.Point(73, 578);
            this.tblcoursesoutput.Name = "tblcoursesoutput";
            this.tblcoursesoutput.Size = new System.Drawing.Size(249, 36);
            this.tblcoursesoutput.TabIndex = 143;
            this.tblcoursesoutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbldiscountoutput
            // 
            this.lbldiscountoutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbldiscountoutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbldiscountoutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiscountoutput.ForeColor = System.Drawing.Color.Green;
            this.lbldiscountoutput.Location = new System.Drawing.Point(339, 523);
            this.lbldiscountoutput.Name = "lbldiscountoutput";
            this.lbldiscountoutput.Size = new System.Drawing.Size(249, 36);
            this.lbldiscountoutput.TabIndex = 146;
            this.lbldiscountoutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbltransportoutput
            // 
            this.lbltransportoutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbltransportoutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltransportoutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltransportoutput.ForeColor = System.Drawing.Color.Green;
            this.lbltransportoutput.Location = new System.Drawing.Point(339, 467);
            this.lbltransportoutput.Name = "lbltransportoutput";
            this.lbltransportoutput.Size = new System.Drawing.Size(249, 36);
            this.lbltransportoutput.TabIndex = 145;
            this.lbltransportoutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblstudyoutput
            // 
            this.lblstudyoutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblstudyoutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblstudyoutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudyoutput.ForeColor = System.Drawing.Color.Green;
            this.lblstudyoutput.Location = new System.Drawing.Point(73, 633);
            this.lblstudyoutput.Name = "lblstudyoutput";
            this.lblstudyoutput.Size = new System.Drawing.Size(249, 36);
            this.lblstudyoutput.TabIndex = 144;
            this.lblstudyoutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbltutionoutput
            // 
            this.lbltutionoutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbltutionoutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltutionoutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltutionoutput.ForeColor = System.Drawing.Color.Green;
            this.lbltutionoutput.Location = new System.Drawing.Point(339, 578);
            this.lbltutionoutput.Name = "lbltutionoutput";
            this.lbltutionoutput.Size = new System.Drawing.Size(249, 36);
            this.lbltutionoutput.TabIndex = 147;
            this.lbltutionoutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblfinaloutput
            // 
            this.lblfinaloutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblfinaloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblfinaloutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfinaloutput.ForeColor = System.Drawing.Color.Green;
            this.lblfinaloutput.Location = new System.Drawing.Point(339, 633);
            this.lblfinaloutput.Name = "lblfinaloutput";
            this.lblfinaloutput.Size = new System.Drawing.Size(249, 36);
            this.lblfinaloutput.TabIndex = 148;
            this.lblfinaloutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 685);
            this.Controls.Add(this.lblfinaloutput);
            this.Controls.Add(this.lbltutionoutput);
            this.Controls.Add(this.lbldiscountoutput);
            this.Controls.Add(this.lbltransportoutput);
            this.Controls.Add(this.lblstudyoutput);
            this.Controls.Add(this.tblcoursesoutput);
            this.Controls.Add(this.tblidoutput);
            this.Controls.Add(this.txttransport);
            this.Controls.Add(this.lbltransport);
            this.Controls.Add(this.txtlevel);
            this.Controls.Add(this.lbllevel);
            this.Controls.Add(this.tblnameoutput);
            this.Controls.Add(this.txtcourses);
            this.Controls.Add(this.lblcourses);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label tblnameoutput;
        private System.Windows.Forms.TextBox txtcourses;
        private System.Windows.Forms.Label lblcourses;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txttransport;
        private System.Windows.Forms.Label lbltransport;
        private System.Windows.Forms.TextBox txtlevel;
        private System.Windows.Forms.Label lbllevel;
        private System.Windows.Forms.Label tblidoutput;
        private System.Windows.Forms.Label tblcoursesoutput;
        private System.Windows.Forms.Label lbldiscountoutput;
        private System.Windows.Forms.Label lbltransportoutput;
        private System.Windows.Forms.Label lblstudyoutput;
        private System.Windows.Forms.Label lbltutionoutput;
        private System.Windows.Forms.Label lblfinaloutput;
    }
}

